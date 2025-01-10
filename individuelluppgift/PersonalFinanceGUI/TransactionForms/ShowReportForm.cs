using System;
using System.Windows.Forms;

namespace PersonalFinanceGUI
{
    public partial class ShowReportForm : Form
    {
        /// <summary>
        /// Konstruktor som tar emot inkomst- och utgiftsvärden för att visa i etiketter.
        /// </summary>
        public ShowReportForm(
            string yearIncome,
            string monthIncome,
            string weekIncome,
            string dayIncome,
            string yearExpense,
            string monthExpense,
            string weekExpense,
            string dayExpense
        )
        {
            InitializeComponent(); // Initierar alla komponenter i formuläret

            // Tilldelar inkomstvärden till respektive etikett
            lblYearIncome.Text = yearIncome;
            lblMonthIncome.Text = monthIncome;
            lblWeekIncome.Text = weekIncome;
            lblDayIncome.Text = dayIncome;

            // Tilldelar utgiftsvärden till respektive etikett
            lblYearExpense.Text = yearExpense;
            lblMonthExpense.Text = monthExpense;
            lblWeekExpense.Text = weekExpense;
            lblDayExpense.Text = dayExpense;
        }

        /// <summary>
        /// Händelse för när formuläret laddas.
        /// </summary>
        private void Form2_Load(object sender, EventArgs e)
        {
            // Kan användas för framtida logik vid formulärets laddning
        }

        // Klickhändelser för respektive etikett. Dessa är tomma men kan användas vid behov.
        private void lblYearIncome_Click(object sender, EventArgs e) { }
        private void lblMonthIncome_Click(object sender, EventArgs e) { }
        private void lblWeekIncome_Click(object sender, EventArgs e) { }
        private void lblDayIncome_Click(object sender, EventArgs e) { }
        private void lblYearExpense_Click(object sender, EventArgs e) { }
        private void lblMonthExpense_Click(object sender, EventArgs e) { }
        private void lblWeekExpense_Click(object sender, EventArgs e) { }
        private void lblDayExpense_Click(object sender, EventArgs e) { }

        /// <summary>
        /// Klickhändelse för "Tillbaka"-knappen.
        /// </summary>
        private void btnReturnFromReport_Click(object sender, EventArgs e)
        {
            this.Close(); // Stänger formuläret och återgår till huvudvyn
        }
    }
}
