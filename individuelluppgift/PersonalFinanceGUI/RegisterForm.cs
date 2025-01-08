using System;
using System.Windows.Forms;
using PersonalFinanceProgram; // Importera ditt logikbibliotek

namespace PersonalFinanceGUI
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        // Klickhändelse för att registrera en ny användare
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtRegisterUsername.Text.Trim();
            string password = txtRegisterPassword.Text.Trim();
            decimal initialAmount;

            // Kontrollera att användarnamn och lösenord inte är tomma
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Användarnamn och lösenord får inte vara tomma.", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kontrollera att initialAmount är ett giltigt tal
            if (!decimal.TryParse(txtInitialAmount.Text, out initialAmount))
            {
                MessageBox.Show("Ange ett giltigt startbelopp.", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Använd AccountManager för att registrera användaren
                AccountManager.RegisterUser(username, password, initialAmount);
                MessageBox.Show("Registrering lyckades! Du kan nu logga in.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Stäng formuläret efter registrering
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Registrering misslyckades: {ex.Message}", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Klickhändelse för att stänga formuläret
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); // Stänger formuläret
        }

        // Klickhändelse för "Visa lösenord"-checkbox
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtRegisterPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        // Oanvända eventhanterare (kan tas bort om de inte används)
        private void txtRegisterUsername_TextChanged(object sender, EventArgs e) { }
        private void txtRegisterPassword_TextChanged(object sender, EventArgs e) { }
        private void txtInitialAmount_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
    }
}
