import tkinter as tk
from tkinter import messagebox
import sympy


# ===== RSA funcs =====
def generate_keys(p: int, q: int, public_key: int):
    """Връща ((e, n), (d, n)) = (public_key, secret_key)"""
    n = p * q
    phi_n = (p - 1) * (q - 1)

    if sympy.gcd(public_key, phi_n) != 1: # GCD е най-голям общ делител
        raise ValueError("Публичният ключ не е взаимно прост с φ(N).")

    secret_key = sympy.mod_inverse(public_key, phi_n)  # d = e^(-1) mod φ(N) | Stackoverflow FTW: https://stackoverflow.com/questions/72179719/rsa-algorithm-1-mod-phi-1
    return (public_key, n), (secret_key, n)


def sign_message(message: str, secret_key: int, modulus: int):
    """Подпис за всеки ASCII символ."""
    signature = []
    for ch in message:
        m = ord(ch)
        s = pow(m, secret_key, modulus) # s = m^d mod n
        signature.append(s)
    return signature


def verify_signature(signature, public_key: int, modulus: int):
    """Възстановява текста от подписа (s^e mod n -> m -> chr(m))."""
    chars = []
    for s in signature:
        m = pow(s, public_key, modulus) # m = s^e mod n
        chars.append(chr(m))
    return "".join(chars)


def encrypt_for_receiver(numbers, public_key: int, modulus: int):
    """Криптира списък от числа с публичния ключ на получателя."""
    return [pow(x, public_key, modulus) for x in numbers]


def decrypt_from_receiver(cipher_numbers, secret_key: int, modulus: int):
    """Декриптира списък от числа с тайния ключ на получателя."""
    return [pow(c, secret_key, modulus) for c in cipher_numbers]


# ===== Ключовете от презентацията =====
# A – подписващ
p_a, q_a, pk_a = 5, 47, 79
(PK_A, N_A), (SK_A, N_A_sk) = generate_keys(p_a, q_a, pk_a)

# B – получател
p_b, q_b, pk_b = 139, 89, 91
(PK_B, N_B), (SK_B, N_B_sk) = generate_keys(p_b, q_b, pk_b)


# ===== Tkinter GUI =====

def run_operation():
    op = operation_var.get()
    text = input_text.get("1.0", "end-1c").strip()

    if not text:
        messagebox.showwarning("Грешка", "Моля въведи текст.")
        return

    if op == "enc":
        # ----- КРИПТИРАНЕ -----
        # A подписва със своя таен ключ и модул N_A
        signature = sign_message(text, SK_A, N_A)

        # A криптира подписа с публичния ключ на B и модул N_B
        ciphertext = encrypt_for_receiver(signature, PK_B, N_B)

        out_str = " ".join(str(x) for x in ciphertext)
        output_text.config(state="normal")
        output_text.delete("1.0", "end")
        output_text.insert(
            "1.0",
            out_str + "\n\n(Това е криптограма от A към B – списък от цели числа.)"
        )
        output_text.config(state="disabled")

    else:
        # ----- ДЕКРИПТИРАНЕ -----
        # B получава списък от числа, разделени с интервали
        try:
            cipher_numbers = [int(x) for x in text.split()]
        except ValueError:
            messagebox.showerror(
                "Грешка",
                "При декриптиране се очакват само цели числа, разделени с интервали.",
            )
            return

        # B декриптира със своя таен ключ SK_B, модул N_B -> получава подписа
        recovered_signature = decrypt_from_receiver(cipher_numbers, SK_B, N_B)

        # B верифицира подписа с публичния ключ на A и модул N_A
        recovered_message = verify_signature(recovered_signature, PK_A, N_A)

        output_text.config(state="normal")
        output_text.delete("1.0", "end")
        output_text.insert(
            "1.0",
            "Възстановено съобщение:\n" + recovered_message
        )
        output_text.config(state="disabled")


# Създаване на главния прозорец
window = tk.Tk()
window.title("RSA цифров подпис (A -> B)")

# Рамка за вход
input_frame = tk.LabelFrame(window, text="Входни данни", padx=10, pady=10)
input_frame.pack(fill="both", expand=True, padx=10, pady=5)

input_label = tk.Label(input_frame, text="Текст за криптиране ИЛИ числа за декриптиране:")
input_label.pack(anchor="w")

input_text = tk.Text(input_frame, height=5, width=60)
input_text.pack(fill="both", expand=True)

# Рамка за избор на операция
options_frame = tk.LabelFrame(window, text="Операция", padx=10, pady=5)
options_frame.pack(fill="x", padx=10, pady=5)

operation_var = tk.StringVar(value="enc")  # "enc" или "dec"

rb_encrypt = tk.Radiobutton(
    options_frame, text="Криптиране (подпис + криптиране)",
    variable=operation_var, value="enc"
)
rb_encrypt.pack(side="left", padx=5)

rb_decrypt = tk.Radiobutton(
    options_frame, text="Декриптиране",
    variable=operation_var, value="dec"
)
rb_decrypt.pack(side="left", padx=5)

run_button = tk.Button(options_frame, text="Изпълни", command=run_operation)
run_button.pack(side="right", padx=5)

# Рамка за резултат
output_frame = tk.LabelFrame(window, text="Резултат", padx=10, pady=10)
output_frame.pack(fill="both", expand=True, padx=10, pady=5)

output_text = tk.Text(output_frame, height=7, width=60, state="disabled")
output_text.pack(fill="both", expand=True)

window.mainloop()
