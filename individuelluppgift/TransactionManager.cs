using System;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace PersonalFinanceProgram
{
    public class TransactionManager : Transaction
    {
        // Vi skapar en funktion som lägger till transaktioner till listan.
        public void AddTransaction(decimal amount, string type)
        {
            // Vi skapar ett objekt som representerar en ny transaktion.
            Transaction newTransaction = new Transaction
            {
                Amount = amount,
                Type = type,         // Här använder vi objektinitiering för ett mer organiserat sätt att skapa objekt.
                Date = DateTime.Now  // Sätter datumet till när transaktinen skapas.
            };

            // Lägg till den nya transaktionen i transaktionslistan
            transactionList.Add(newTransaction);
        }

        // Metod för att visa alla transaktioner i en ListBox (GUI) 
        public void ShowTransactions(ListBox listBox) //Använder ListBox från GUI toolbox och listbox som parameter.
        {
            //Rensar alla posters i ListBox innan vi lägger till nya. 
            listBox.Items.Clear();
            
            //Kollar ifall listan är tom.
            if (transactionList.Count == 0) 
            {
                listBox.Items.Add("Du har inte lagt till några transaktioner.");
                return;
            }
            // Loopar genom transaktionslistan för att visa varje transaktion med dess index.
            for (int i = 0; i < transactionList.Count; i++)
            {
                var transaction = transactionList[i]; // Hämtar transaktionen vid index i.

                // Skriv ut transaktionen med ett användarvänligt index (börjar på 1).
                listBox.Items.Add($"{i + 1}: {transaction.Amount:C} - {transaction.Type} - {transaction.Date}");
            }
        }

        public void RemoveTransaction(int index)
        {
            // Kontrollera att indexet är inom giltiga gränser.
            if (index >= 0 && index < transactionList.Count)
            {
                // Ta bort transaktionen vid det angivna indexet.
                transactionList.RemoveAt(index);
                Console.WriteLine("Transaktion borttaget!"); // Bekräfta borttagningen.

                SaveAndLoadData removeData = new SaveAndLoadData();
                removeData.SaveData(); // Anropa den så uppdateras även SaveData när vi tar bort en transaktion.
            }
            else
            {
                Console.WriteLine("Ogiltigt index. Försök igen."); // Hantera ogiltigt index.
            }
        }
    }
}
