using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms1
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            if (Accounts.TryAddUser(textBoxUserName.Text, textBoxPassword.Text))
                MessageBox.Show("Successful", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else 
                MessageBox.Show("Userneame already exists", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin(this);
            formLogin.Show();
            Hide();
        }
    }
}
