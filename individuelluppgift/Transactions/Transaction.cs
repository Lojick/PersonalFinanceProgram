using System;
using System.Collections.Generic;

namespace PersonalFinanceProgram
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public int UserId { get; set; }
        public decimal Amount { get; set; }
        public string Type { get; set; } // "Inkomst" eller "Utgift"
        public DateTime DateTime { get; set; }

        //Parameterlös konstruktor som jag använder eftersom den behöver vara tom när jag hämtar data från databasen.
        public Transaction() { }
    }
}
