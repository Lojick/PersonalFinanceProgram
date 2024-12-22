namespace PersonalFinanceProgram
{
    public class Balance : Transaction
    {
        public decimal GetBalance() // Vi skapar en metod som visar oss det nuvarande saldot på kontot.
        {
            decimal balance = 0; // Vi börjar sätta 0 som startsaldo eftersom man man kommer ha inkomster och utgifter.
            
            foreach (var transaction in transactionList) // Loopar igenom listan.
            {
                if (transaction.Type == "Inkomst") // Typen inkomst.
                {
                    balance += transaction.Amount; // T.ex. 0kr + 500kr = Inkomst.
                }
                else if (transaction.Type == "Utgift") // Typen utgift.
                {
                    balance -= transaction.Amount; // T.ex. 0kr - 500kr = Utgift.
                }
            }
            
            return balance; // Efter den loopat igenom alla typer så returneras saldot. Nu har du fått det nuvarande saldot.
        }
    }
}
