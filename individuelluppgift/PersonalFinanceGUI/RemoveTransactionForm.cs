using System;
using PersonalFinanceProgram;
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
    public partial class RemoveTransactionForm : Form
    {
        private TransactionManager transactionManager = new TransactionManager();

        public RemoveTransactionForm()
        {
            InitializeComponent(); // Initierar alla komponenter i formuläret
            // Ladda och visa alla transaktioner i listboxen när formuläret öppnas.
            transactionManager.ShowTransactions(listboxTransactions);
        }

        // Klickhändelse för att ta bort en vald transaktion
        private void btnRemoveTransaction_Click(object sender, EventArgs e)
        {
            int selectedIndex = listboxTransactions.SelectedIndex;

            // Kontrollera om en transaktion har valts
            if (selectedIndex >= 0)
            {
                // Ta bort vald transaktion och uppdatera listan
                transactionManager.RemoveTransaction(selectedIndex);
                transactionManager.ShowTransactions(listboxTransactions); // Uppdatera listboxen
            }
            else
            {
                // Visa ett meddelande om ingen transaktion valts
                MessageBox.Show("Välj en transaktion att ta bort");
            }
        }

        // Klickhändelse för att stänga formuläret
        private void btnReturnFromRemoveTransactionForm_Click(object sender, EventArgs e)
        {
            this.Close(); // Stänger formuläret och återgår till föregående vy
        }

        // Tomma händelser, redo för eventuell framtida logik eller kan tas bort om de inte används
        private void lblRemoveTransaction_Click(object sender, EventArgs e) { }

        private void listBoxTransactions_SelectedIndexChanged(object sender, EventArgs e) { }

        private void RemoveTransactionForm_Load(object sender, EventArgs e) { }
    }
}
