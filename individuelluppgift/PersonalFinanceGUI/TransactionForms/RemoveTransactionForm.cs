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
        }

        // Metod för att ladda transaktioner till listboxen
        private void LoadTransactions()
        {
            try
            {
                // Hämta transaktioner från TransactionManager
                var transactionsWithUserName = TransactionManager.GetTransactions(CurrentUser.UserID);

                // Rensa listboxen innan nya transaktioner läggs till
                dataGridView1.Rows.Clear();

                // Lägg till varje transaktion i dataGridView
                foreach (var (UserName, transaction) in transactionsWithUserName)
                {
                    dataGridView1.Rows.Add(
                        transaction.TransactionId,
                        UserName,
                        transaction.Type,
                        transaction.Amount,
                        transaction.DateTime.ToString("yyyy-MM-dd HH:mm")
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
            if (dataGridView1.SelectedRows.Count > 0) // Kontrollera om en transaktion är vald
            {
                try
                {
                    // Hämta TransactionId från den valda raden
                    var selectedRow = dataGridView1.SelectedRows[0];
                    int transactionId = Convert.ToInt32(selectedRow.Cells["TransactionID"].Value);

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

        // Händelse som körs när formuläret laddas
        private void RemoveTransactionForm_Load(object sender, EventArgs e)
        {
            // Lägg till logik som körs när formuläret laddas (om nödvändigt)
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Enter(object sender, EventArgs e)
        {
      
        }
    }
}
