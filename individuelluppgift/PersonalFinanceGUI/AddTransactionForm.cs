using System;
using PersonalFinanceProgram;
using System.Windows.Forms;

namespace PersonalFinanceGUI
{
    public partial class AddTransactionForm : Form
    {
        public AddTransactionForm()
        {
            InitializeComponent();
        }

        // Eventhanterare för "Spara"-knappen
        private void btnSaveTransaction_Click(object sender, EventArgs e)
        {
            // Försök att konvertera texten i txtAmount till en decimal och spara i variabeln "amount"
            if (decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                string type;

                // Kontrollera vilken radioknapp som är vald för att bestämma transaktionstyp
                if (radioSättIn.Checked)
                {
                    type = "Inkomst"; // Om "Sätt in pengar" är valt, sätt typen till "Inkomst"
                }
                else if (radioTaUt.Checked)
                {
                    type = "Utgift"; // Om "Ta ut pengar" är valt, sätt typen till "Utgift"
                }
                else
                {
                    MessageBox.Show("Vänligen välj en transaktionstyp."); // Om ingen typ är vald
                    return;
                }

                // Skapa instanser av TransactionManager och SaveAndLoadData
                TransactionManager manager = new TransactionManager();
                SaveAndLoadData saveData = new SaveAndLoadData();

                // Lägg till transaktionen i listan och spara uppdaterad data
                manager.AddTransaction(amount, type);
                saveData.SaveData();

                // Bekräftelsemeddelande
                MessageBox.Show("Transaktion tillagd!");

                // Återställ fält för en ny transaktion
                txtAmount.Text = string.Empty;
                radioSättIn.Checked = false;
                radioTaUt.Checked = false;
            }
            else
            {
                // Meddelande om ogiltigt belopp
                MessageBox.Show("Vänligen ange ett giltigt belopp");
            }
        }

        // Eventhanterare för "Tillbaka"-knappen
        private void btnReturnFromAddTransaction_Click(object sender, EventArgs e)
        {
            this.Close(); // Stänger formuläret
        }

        // Tomma eventhanterare för andra kontroller (kan tas bort om de inte används)
        private void txtAmount_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void radioTaUt_CheckedChanged(object sender, EventArgs e) { }
        private void radioSättIn_CheckedChanged(object sender, EventArgs e) { }
        private void lblAddTransaction_Click(object sender, EventArgs e) { }
        private void AddTransactionForm_Load(object sender, EventArgs e) { }
    }
}
