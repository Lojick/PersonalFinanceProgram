using Xunit;
using PersonalFinanceProgram; //Refererar till huvudprojektet

namespace PersonalFinanceTest
{
    public class BalanceTests
    {
        [Fact]
        public void GetBalance_ReturnsCorrectBalance() // S� vi inte blandar ihop med huvudprojektets GetBalance().
        {
            Transaction.ClearTransactionList(); // Varje test vi g�r rensar vi listan s� vi isolerar det s� bra som m�jligt.

            // B�rjar med att skapa 2 valfria transaktioner och l�gga till dem i transactionList via v�r metod.
            // Eftersom den ej har en konstrukt�r s� anv�nder vi {}.
            Transaction.GetTransactionList().Add(new Transaction { Amount = 500, Type = "Inkomst" }); // +500
            Transaction.GetTransactionList().Add(new Transaction { Amount = 200, Type = "Utgift" });  // -200

            Balance balance = new Balance();

            // Vi skapar en variabel och tilldelar v�rdet som vi f�rv�ntar oss ska motsvara kontosaldot.
            decimal expectedBalance = 300;

            // Anropar metoden f�r att h�mta det aktuella kontosaldot.
            decimal actualBalance = balance.GetBalance();

            // Kollar om expectedBalance �r exakt lika med nuvarande kontosaldot.
            Assert.Equal(expectedBalance, actualBalance);
        }
    }
}
