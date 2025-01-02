using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonalFinanceProgram;

namespace PersonalFinanceGUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            try
            {
                //Försök logga in användaren
                int userId = AccountManager.Login(username, password);
                CurrentUser.SetUser(userId, username); //Sätt den inloggade användaren

                MessageBox.Show($"Välkommen, {CurrentUser.UserName}!");

                //Öppna huvudformuläret och stäng inloggningsformuläret
                Form1 form1 = new Form1();
                this.Hide();
                form1.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Inloggning misslyckades: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterForm registerform = new RegisterForm();
            registerform.ShowDialog();
        }

        private void txtUsername_Text(object sender, EventArgs e)
        {

        }

        private void txtPassword_Text(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
