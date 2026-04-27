#include <stdio.h>

int count_digits(long long n) {
    if (n == 0)
        return 0;
    else
        return 1 + count_digits(n / 10);
}

int main() {
    long long number = 12345;
    printf("Брой цифри на %lld е: %d\n", number, count_digits(number));
    return 0;
}
