//using Xunit;
//using PersonalFinanceProgram;

//namespace PersonalFinanceTest
//{
//    public class RemoveTransactionTests
//    {
//        [Fact]
//        public void RemoveTransaction_RemovesTransactionFromList()
//        {
//            // Vi börjar med att tömma listan innan vi testar att ta bort.
//            Transaction.ClearTransactionList();

//            // Sedan testar vi att lägga in en transaktion.
//            Transaction.GetTransactionList().Add(new Transaction { Amount = 100, Type = "Inkomst" });

//            // Anropar metoden och skickar in 0 som argument. Vi antar att vi vill ta bort det första indexet av listan.
//            var manager = new TransactionManager();
//            manager.RemoveTransaction(0);

//            // Kollar om listan är tom efter borttagningen.
//            Assert.Empty(Transaction.GetTransactionList());
//        }
//    }
//}
