using Xunit;
using PersonalFinanceProgram; //Refererar till huvudprojektet

namespace PersonalFinanceTest
{
    public class BalanceTests
    {
        [Fact]
        public void GetBalance_ReturnsCorrectBalance() // Så vi inte blandar ihop med huvudprojektets GetBalance().
        {
            Transaction.ClearTransactionList(); // Varje test vi gör rensar vi listan så vi isolerar det så bra som möjligt.

            // Börjar med att skapa 2 valfria transaktioner och lägga till dem i transactionList via vår metod.
            // Eftersom den ej har en konstruktör så använder vi {}.
            Transaction.GetTransactionList().Add(new Transaction { Amount = 500, Type = "Inkomst" }); // +500
            Transaction.GetTransactionList().Add(new Transaction { Amount = 200, Type = "Utgift" });  // -200

            Balance balance = new Balance();

            // Vi skapar en variabel och tilldelar värdet som vi förväntar oss ska motsvara kontosaldot.
            decimal expectedBalance = 300;

            // Anropar metoden för att hämta det aktuella kontosaldot.
            decimal actualBalance = balance.GetBalance();

            // Kollar om expectedBalance är exakt lika med nuvarande kontosaldot.
            Assert.Equal(expectedBalance, actualBalance);
        }
    }
}
