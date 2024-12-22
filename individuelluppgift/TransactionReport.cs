using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonalFinanceProgram
{
    // Klass för att skapa en rapport av utgifter och inkomster
    public class TransactionReport : Transaction
    {
        // Metod som hämtar utgiftsrapport för år, månad, vecka och dag
        public (string yearSpent, string monthSpent, string weekSpent, string daySpent) GetExpenseReport()
        {
            // Beräknar totala utgifter för året
            decimal yearSpent = transactionList.Where(t => t.Type == "Utgift" && t.Date.Year == DateTime.Now.Year).Sum(t => t.Amount);
            // Beräknar totala utgifter för månaden
            decimal monthSpent = transactionList.Where(t => t.Type == "Utgift" && t.Date.Month == DateTime.Now.Month).Sum(t => t.Amount);
            // Beräknar totala utgifter för veckan (de senaste 7 dagarna)
            decimal weekSpent = transactionList.Where(t => t.Type == "Utgift" && t.Date >= DateTime.Now.AddDays(-7)).Sum(t => t.Amount);
            // Beräknar totala utgifter för dagen
            decimal daySpent = transactionList.Where(t => t.Type == "Utgift" && t.Date.Date == DateTime.Now.Date).Sum(t => t.Amount);

            // Returnerar utgifter som formaterade strängar
            return (
                $"Årsvis Utgift: {yearSpent:C}",
                $"Månadsvis Utgift: {monthSpent:C}", //Använder :C för att skriva ut i kronor.
                $"Veckovis Utgift: {weekSpent:C}",
                $"Dagvis Utgift: {daySpent:C}"
            );
        }

        // Metod som hämtar inkomstrapport för år, månad, vecka och dag
        public (string yearIncome, string monthIncome, string weekIncome, string dayIncome) GetIncomeReport()
        {
            // Beräknar totala inkomster för året
            decimal yearIncome = transactionList.Where(t => t.Type == "Inkomst" && t.Date.Year == DateTime.Now.Year).Sum(t => t.Amount);
            // Beräknar totala inkomster för månaden
            decimal monthIncome = transactionList.Where(t => t.Type == "Inkomst" && t.Date.Month == DateTime.Now.Month).Sum(t => t.Amount);
            // Beräknar totala inkomster för veckan (de senaste 7 dagarna)
            decimal weekIncome = transactionList.Where(t => t.Type == "Inkomst" && t.Date >= DateTime.Now.AddDays(-7)).Sum(t => t.Amount);
            // Beräknar totala inkomster för dagen
            decimal dayIncome = transactionList.Where(t => t.Type == "Inkomst" && t.Date.Date == DateTime.Now.Date).Sum(t => t.Amount);

            // Returnerar inkomster som formaterade strängar
            return (
                $"Årsvis Inkomst: {yearIncome:C}",
                $"Månadsvis Inkomst: {monthIncome:C}",
                $"Veckovis Inkomst: {weekIncome:C}",
                $"Dagvis Inkomst: {dayIncome:C}"
            );
        }
    }
}








