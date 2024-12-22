using PersonalFinanceProgram;

namespace PersonalFinanceGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Event som körs när formuläret laddas
        private void Form1_Load(object sender, EventArgs e)
        {
            // Ladda all data när programmet startar så att vår transaktionshistorik inte försvinner
            SaveAndLoadData loadData = new SaveAndLoadData();
            loadData.LoadData();

            // Visa huvudmenyn vid start och dölj panelen för att lägga till transaktioner
            mainPanel.Visible = true;
        }

        // Metod för att hantera visning av specifika paneler
        private void ShowPanel(Panel panelToShow)
        {
            // Dölj alla paneler (för tillfället bara mainPanel men kan utökas)
            mainPanel.Visible = false;

            // Visa den specifika panelen som skickas in i metoden
            panelToShow.Visible = true;
        }

        // Klickhändelse för "Lägg till transaktioner"
        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            // Öppnar AddTransactionForm som en modal dialogruta
            AddTransactionForm addTransactionForm = new AddTransactionForm();
            addTransactionForm.ShowDialog();
        }

        // Klickhändelse för "Ta bort transaktioner"
        private void btnRemoveTransaction_Click(object sender, EventArgs e)
        {
            // Öppnar RemoveTransactionForm som en modal dialogruta
            RemoveTransactionForm removeTransactionForm = new RemoveTransactionForm();
            removeTransactionForm.ShowDialog();
        }

        // Klickhändelse för "Visa rapport"
        private void btnShowReport_Click(object sender, EventArgs e)
        {
            // Skapa en instans av TransactionReport för att hämta utgifter och inkomster
            TransactionReport report = new TransactionReport();

            // Hämta rapportdata för utgifter och inkomster
            var (yearSpent, monthSpent, weekSpent, daySpent) = report.GetExpenseReport();
            var (yearIncome, monthIncome, weekIncome, dayIncome) = report.GetIncomeReport();

            // Skapa och visa ShowReportForm, skicka in rapportdata
            ShowReportForm showReportForm = new ShowReportForm(
                yearIncome, monthIncome, weekIncome, dayIncome,
                yearSpent, monthSpent, weekSpent, daySpent
            );
            showReportForm.ShowDialog(); // Visa ShowReportForm som en dialog
        }

        // Klickhändelse för "Visa kontobalans"
        private void btnShowBalance_Click(object sender, EventArgs e)
        {
            // Skapa en instans av Balance för att hämta kontobalansen
            Balance balanceManager = new Balance();
            decimal balance = balanceManager.GetBalance();

            // Skapa och visa ShowBalanceForm, skicka in balansen
            ShowBalanceForm balanceForm = new ShowBalanceForm(balance);
            balanceForm.ShowDialog();
        }

        // Klickhändelse för "Stäng programmet"
        private void btnCloseProgram_Click(object sender, EventArgs e)
        {
            Close(); // Stänger applikationen
        }

        // Klickhändelse för "Gå tillbaka" i panelen för att lägga till transaktioner
        private void btnReturnToMain_Click(object sender, EventArgs e)
        {
            mainPanel.Visible = true; // Visar huvudmenyn igen
        }

        // Event som hanterar målning av huvudpanelen (om det behövs)
        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            // Logik för att måla huvudpanelen (valfritt)
        }
    }
}
