using System;
using System.Collections.Generic;

namespace PersonalFinanceProgram
{
    public class Transaction // Klass som innehåller alla fält för en transaktion.
    {
        public decimal Amount { get; set; } // Beloppet för transaktionen.
        public string? Type { get; set; } // Typ av transaktion: "Inkomst" eller "Utgift".
        public DateTime Date { get; set; } = DateTime.Now; // Datum för transaktionen, med standardvärde för aktuellt datum.

        // En skyddad och statisk lista över transaktioner.
        // Eftersom många klasser ärver från Transaction-klassen och vi vill att listan ska vara gemensam och skyddad, gör vi den både protected och static.
        protected static List<Transaction> transactionList = new List<Transaction>();

        //Metod som ska hämta transactionList för att möjliggöra tester.
        public static List<Transaction> GetTransactionList()
        {
            return transactionList; // Returnerar listan
        }

        // Metod som ska tömma transactionList.
        public static void ClearTransactionList()
        {
            transactionList.Clear();
            Console.WriteLine("transactionList cleared. Count: " + transactionList.Count); // Debug-meddelande för att visa att listan är tömd.
        }
    }
}
