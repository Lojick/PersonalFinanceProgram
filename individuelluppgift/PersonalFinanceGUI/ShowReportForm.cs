using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalFinanceGUI
{
    public partial class ShowReportForm : Form
    {
        // Konstruktor som tar emot inkomst- och utgiftsvärden för att visa i etiketter (labels)
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

            // Tilldelar inkomstvärden till respektive etikett i formuläret
            lblYearIncome.Text = yearIncome;
            lblMonthIncome.Text = monthIncome;
            lblWeekIncome.Text = weekIncome;
            lblDayIncome.Text = dayIncome;

            // Tilldelar utgiftsvärden till respektive etikett i formuläret
            lblYearExpense.Text = yearExpense;
            lblMonthExpense.Text = monthExpense;
            lblWeekExpense.Text = weekExpense;
            lblDayExpense.Text = dayExpense;
        }

        // Händelse för när formuläret laddas
        private void Form2_Load(object sender, EventArgs e)
        {
            // Kan användas för framtida logik vid formulärets laddning om det behövs
        }

        // Klickhändelser för respektive etikett. Dessa är tomma men kan användas om det behövs.
        private void lblYearIncome_Click(object sender, EventArgs e) { }

        private void lblMonthIncome_Click(object sender, EventArgs e) { }

        private void lblWeekIncome_Click(object sender, EventArgs e) { }

        private void lblDayIncome_Click(object sender, EventArgs e) { }

        private void lblYearExpense_Click(object sender, EventArgs e) { }

        private void lblMonthExpense_Click(object sender, EventArgs e) { }

        private void lblWeekExpense_Click(object sender, EventArgs e) { }

        private void lblDayExpense_Click(object sender, EventArgs e) { }

        // Klickhändelse för "Tillbaka"-knappen
        private void btnReturnFromReport_Click(object sender, EventArgs e)
        {
            this.Close(); // Stänger formuläret och återgår till huvudvyn
        }
    }
}
