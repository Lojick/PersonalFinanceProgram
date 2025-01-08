using System;
using PersonalFinanceProgram;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PersonalFinanceGUI
{
    public partial class RemoveTransactionForm : Form
    {
        public RemoveTransactionForm()
        {
            InitializeComponent(); // Initierar alla komponenter i formuläret
            LoadTransactions();    // Ladda och visa alla transaktioner i listboxen vid formulärets start

            // Ställ in teckensnittet för listboxen
            listboxTransactions.Font = new Font("Consolas", 10);
        }

        // Metod för att ladda transaktioner till listboxen
        private void LoadTransactions()
        {
            try
            {
                // Hämta transaktioner från TransactionManager
                var transactionsWithUserName = TransactionManager.GetTransactions(CurrentUser.UserID);

                // Rensa listboxen innan nya transaktioner läggs till
                listboxTransactions.Items.Clear();

                // Lägg till varje transaktion i listboxen
                foreach (var (UserName, transaction) in transactionsWithUserName)
                {
                    listboxTransactions.Items.Add(
                        $"{transaction.TransactionId}: {transaction.Type} - {transaction.Amount} kr ({transaction.DateTime:yyyy-MM-dd HH:mm})"
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kunde inte ladda transaktioner: {ex.Message}", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Klickhändelse för att ta bort en vald transaktion
        private void btnRemoveTransaction_Click(object sender, EventArgs e)
        {
            if (listboxTransactions.SelectedIndex >= 0) // Kontrollera om en transaktion är vald
            {
                try
                {
                    // Hämta TransactionId från den valda raden
                    var selectedTransaction = listboxTransactions.SelectedItem.ToString();
                    int transactionId = int.Parse(selectedTransaction.Split(':')[0].Trim()); // Extrahera TransactionId

                    // Ta bort transaktionen från databasen
                    TransactionManager.RemoveTransaction(transactionId, CurrentUser.UserID);

                    // Uppdatera listboxen efter borttagning
                    LoadTransactions();

                    MessageBox.Show("Transaktionen har tagits bort.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Kunde inte ta bort transaktionen: {ex.Message}", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Visa ett meddelande om ingen transaktion valts
                MessageBox.Show("Välj en transaktion att ta bort.", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Klickhändelse för att stänga formuläret
        private void btnReturnFromRemoveTransactionForm_Click(object sender, EventArgs e)
        {
            this.Close(); // Stänger formuläret och återgår till föregående vy
        }

        // Händelse för listboxens valändring (valfritt att använda)
        private void listboxTransactions_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lägg till eventuell logik för när ett objekt i listan väljs (valfritt)
        }

        // Händelse som körs när formuläret laddas
        private void RemoveTransactionForm_Load(object sender, EventArgs e)
        {
            // Lägg till logik som körs när formuläret laddas (om nödvändigt)
        }

        // Ytterligare eventhanterare för listboxen (kan tas bort om de inte används)
        private void listboxTransactions_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Tom eventhanterare (kan tas bort om den inte behövs)
        }
    }
}
