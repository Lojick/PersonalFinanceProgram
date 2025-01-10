using System;
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

        // Event som körs när formuläret laddas
        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        // Klickhändelse för "Logga in"-knappen
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            try
            {
                // Försök logga in användaren
                int userId = AccountManager.Login(username, password);
                CurrentUser.SetUser(userId, username); // Sätt den inloggade användaren

                MessageBox.Show($"Välkommen, {CurrentUser.UserName}!");

                // Öppna huvudformuläret och stäng inloggningsformuläret
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

        // Klickhändelse för "Registrera"-knappen
        private void button2_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }

        // Klickhändelse för "Avsluta"-knappen
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Klickhändelse för "Visa lösenord"-checkboxen
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        // Oanvända eventhanterare (kan tas bort om de inte används)
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void txtUsername_TextChanged(object sender, EventArgs e) { }
        private void txtPassword_TextChanged(object sender, EventArgs e) { }
        private void txtUsername_Text(object sender, EventArgs e) { }
        private void txtPassword_Text(object sender, EventArgs e) { }
    }
}
