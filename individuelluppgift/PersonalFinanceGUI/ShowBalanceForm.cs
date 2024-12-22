using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalFinanceGUI
{
    public partial class ShowBalanceForm : Form
    {
        // Konstruktor för ShowBalanceForm som tar emot "balance" som en parameter.
        // Denna konstruktor används när vi vill visa kontobalansen i ett formulär.
        public ShowBalanceForm(decimal balance)
        {
            InitializeComponent(); 

            // Sätter texten i etiketten "lblBalance" för att visa den aktuella kontobalansen och överför den till en sträng format.
            lblBalance.Text = "Din nuvarande kontobalans: " + balance.ToString("C"); // "C" formatet konverterar värdet till valutaformat.

            // Justerar etikettens position så att den alltid är centrerad, oavsett hur bred texten är (t.ex. vid olika balansbelopp).

            lblBalance.Location = new Point((this.ClientSize.Width - lblBalance.Width) / 2, lblBalance.Location.Y);
        }

        // Händelse som triggas när ShowBalanceForm laddas
        private void ShowBalanceForm_Load(object sender, EventArgs e)
        {
            // Kan användas för framtida logik vid laddning av formuläret.
        }

        // Klickhändelse för "lblBalance" etiketten (tom för närvarande, kan användas vid behov).
        private void lblBalance_Click(object sender, EventArgs e)
        {
        }

        // Klickhändelse för knappen "btnReturnFromBalance" för att stänga formuläret och återgå till huvudformuläret.
        private void btnReturnFromBalance_Click(object sender, EventArgs e)
        {
            this.Close(); // Stänger formuläret.
        }
    }
}
