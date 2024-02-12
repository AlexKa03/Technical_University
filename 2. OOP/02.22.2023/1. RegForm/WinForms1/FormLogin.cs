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
    public partial class FormLogin : Form
    {
        private readonly FormRegister _fr;
        public FormLogin(FormRegister fr)
        {
            InitializeComponent();
            _fr = fr;
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            _fr.Close();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (Accounts.CheckUser(textBoxUserName.Text, textBoxPassword.Text))
                MessageBox.Show("Successful", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                MessageBox.Show("Invalid username or password", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
