using System;
using PersonalFinanceProgram;
using System.Windows.Forms;

namespace PersonalFinanceGUI
{
    public partial class RemoveTransactionForm : Form
    {
        public RemoveTransactionForm()
        {
            InitializeComponent(); // Initierar alla komponenter i formuläret
            LoadTransactions(); // Ladda och visa alla transaktioner i listboxen vid formulärets start
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
                foreach (var (userName, transaction) in transactionsWithUserName)
                {
                    listboxTransactions.Items.Add(
                        $"{userName} - {transaction.TransactionId}: {transaction.Type} - {transaction.Amount} kr ({transaction.DateTime:yyyy-MM-dd HH:mm})"
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
        private void RemoveTransactionForm_Load(object sender, EventArgs e)
        {
            // Här kan du lägga till logik som körs när formuläret laddas.
            // Om det inte behövs kan du låta metoden vara tom.
        }

        private void listboxTransactions_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
