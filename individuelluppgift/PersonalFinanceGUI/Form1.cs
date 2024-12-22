using PersonalFinanceProgram;

namespace PersonalFinanceGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Event som k�rs n�r formul�ret laddas
        private void Form1_Load(object sender, EventArgs e)
        {
            // Ladda all data n�r programmet startar s� att v�r transaktionshistorik inte f�rsvinner
            SaveAndLoadData loadData = new SaveAndLoadData();
            loadData.LoadData();

            // Visa huvudmenyn vid start och d�lj panelen f�r att l�gga till transaktioner
            mainPanel.Visible = true;
        }

        // Metod f�r att hantera visning av specifika paneler
        private void ShowPanel(Panel panelToShow)
        {
            // D�lj alla paneler (f�r tillf�llet bara mainPanel men kan ut�kas)
            mainPanel.Visible = false;

            // Visa den specifika panelen som skickas in i metoden
            panelToShow.Visible = true;
        }

        // Klickh�ndelse f�r "L�gg till transaktioner"
        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            // �ppnar AddTransactionForm som en modal dialogruta
            AddTransactionForm addTransactionForm = new AddTransactionForm();
            addTransactionForm.ShowDialog();
        }

        // Klickh�ndelse f�r "Ta bort transaktioner"
        private void btnRemoveTransaction_Click(object sender, EventArgs e)
        {
            // �ppnar RemoveTransactionForm som en modal dialogruta
            RemoveTransactionForm removeTransactionForm = new RemoveTransactionForm();
            removeTransactionForm.ShowDialog();
        }

        // Klickh�ndelse f�r "Visa rapport"
        private void btnShowReport_Click(object sender, EventArgs e)
        {
            // Skapa en instans av TransactionReport f�r att h�mta utgifter och inkomster
            TransactionReport report = new TransactionReport();

            // H�mta rapportdata f�r utgifter och inkomster
            var (yearSpent, monthSpent, weekSpent, daySpent) = report.GetExpenseReport();
            var (yearIncome, monthIncome, weekIncome, dayIncome) = report.GetIncomeReport();

            // Skapa och visa ShowReportForm, skicka in rapportdata
            ShowReportForm showReportForm = new ShowReportForm(
                yearIncome, monthIncome, weekIncome, dayIncome,
                yearSpent, monthSpent, weekSpent, daySpent
            );
            showReportForm.ShowDialog(); // Visa ShowReportForm som en dialog
        }

        // Klickh�ndelse f�r "Visa kontobalans"
        private void btnShowBalance_Click(object sender, EventArgs e)
        {
            // Skapa en instans av Balance f�r att h�mta kontobalansen
            Balance balanceManager = new Balance();
            decimal balance = balanceManager.GetBalance();

            // Skapa och visa ShowBalanceForm, skicka in balansen
            ShowBalanceForm balanceForm = new ShowBalanceForm(balance);
            balanceForm.ShowDialog();
        }

        // Klickh�ndelse f�r "St�ng programmet"
        private void btnCloseProgram_Click(object sender, EventArgs e)
        {
            Close(); // St�nger applikationen
        }

        // Klickh�ndelse f�r "G� tillbaka" i panelen f�r att l�gga till transaktioner
        private void btnReturnToMain_Click(object sender, EventArgs e)
        {
            mainPanel.Visible = true; // Visar huvudmenyn igen
        }

        // Event som hanterar m�lning av huvudpanelen (om det beh�vs)
        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            // Logik f�r att m�la huvudpanelen (valfritt)
        }
    }
}
