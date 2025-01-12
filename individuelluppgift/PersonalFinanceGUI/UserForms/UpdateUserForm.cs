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
    public partial class UpdateUserForm : Form
    {
        public UpdateUserForm()
        {
            InitializeComponent();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Hämta användarinmatning
                string newName = updateName.Text;
                string newPassword = updatePassword.Text;

                // Kontrollera att fälten inte är tomma
                if (string.IsNullOrEmpty(newName) || string.IsNullOrEmpty(newPassword))
                {
                    MessageBox.Show("Fälten får inte vara tomma.", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Anropa metoden för att uppdatera användaruppgifter
                UpdateUser.UpdateUserProfile(CurrentUser.UserID, newName, newPassword);

                // Uppdatera CurrentUser.UserName
                CurrentUser.UpdateCurrentUserName(newName);

                MessageBox.Show("Användaruppgifter uppdaterades!", "Framgång", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ett fel uppstod: {ex.Message}", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateName_TextChanged(object sender, EventArgs e)
        {
            // Event för ändring i textfältet (kan lämnas tomt om det inte behövs)
        }

        private void updatePassword_TextChanged(object sender, EventArgs e)
        {
            // Event för ändring i textfältet (kan lämnas tomt om det inte behövs)
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Event för label2 (kan lämnas tomt om det inte behövs)
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            // Stäng nuvarande form och återgå till föregående
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           updatePassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }
    }
}
