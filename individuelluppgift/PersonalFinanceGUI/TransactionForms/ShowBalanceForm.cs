using System;
using System.Drawing;
using System.Windows.Forms;

namespace PersonalFinanceGUI
{
    public partial class ShowBalanceForm : Form
    {
        /// <summary>
        /// Konstruktor för ShowBalanceForm som tar emot kontobalansen som en parameter.
        /// </summary>
        /// <param name="balance">Kontobalansen som ska visas.</param>
        public ShowBalanceForm(decimal balance)
        {
            InitializeComponent();

            // Sätt texten i lblBalance för att visa kontobalansen
            lblBalance.Text = "Din nuvarande kontobalans: " + balance.ToString("C"); // "C" för valutaformat

            // Centrera etiketten horisontellt baserat på textens bredd
            lblBalance.Location = new Point(
                (this.ClientSize.Width - lblBalance.Width) / 2,
                lblBalance.Location.Y
            );
        }

        /// <summary>
        /// Händelse som triggas när ShowBalanceForm laddas.
        /// </summary>
        private void ShowBalanceForm_Load(object sender, EventArgs e)
        {
            // Logik som ska köras när formuläret laddas (om nödvändigt)
        }

        /// <summary>
        /// Klickhändelse för lblBalance (tom för närvarande, kan användas vid behov).
        /// </summary>
        private void lblBalance_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Klickhändelse för knappen "btnReturnFromBalance" för att stänga formuläret.
        /// </summary>
        private void btnReturnFromBalance_Click(object sender, EventArgs e)
        {
            this.Close(); // Stänger formuläret
        }
    }
}
