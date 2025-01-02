//using Xunit;
//using PersonalFinanceProgram; // Lägg till ditt huvudprograms namespace här

//namespace PersonalFinanceTest
//{
//    public class LoadDataTests
//    {
//        [Fact]
//        public void LoadData_LoadsAFile()
//        {
//            Transaction.ClearTransactionList();

//            // Vi börjar med att skapa en viss transaktion.
//            Transaction.GetTransactionList().Add(new Transaction { Amount = 150, Type = "Inkomst" });

//            // Vi kommer använda både saveData och LoadData så vi skapar 2 olika objekt.
//            SaveAndLoadData saveTransaction = new SaveAndLoadData();
//            SaveAndLoadData loadTransaction = new SaveAndLoadData();

//            // Anropar vår metod för att spara data och skriva över till en fil.
//            saveTransaction.SaveData();

//            // För att testa att LoadData gör sitt jobb så rensar vi listan och anropar den.
//            Transaction.ClearTransactionList();

//            // LoadData ska läsa innehållet av textfilen och återfylla listan igen med de sparade transaktionerna.
//            saveTransaction.LoadData();

//            Assert.Single(Transaction.GetTransactionList()); // Kollar om det finns exakt ett objekt i listan.
//            Assert.Equal(150, Transaction.GetTransactionList()[0].Amount); // Kollar om Amount för den första transaktionen i listan är exakt 150.
//            Assert.Equal("Inkomst", Transaction.GetTransactionList()[0].Type); // Kollar om Type för den första transaktionen i listan är exakt "Inkomst".
//        }
//    }
//}
