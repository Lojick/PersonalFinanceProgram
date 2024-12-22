using Xunit;
using PersonalFinanceProgram; // Lägg till ditt huvudprograms namespace här
using System;
using System.IO;

namespace PersonalFinanceTest
{
    public class SaveDataTests
    {
        [Fact]
        public void SaveData_SavesAFile()
        {
            Transaction.ClearTransactionList();

            // Vi börjar med att skapa en transaktion som kommer senare läggas till i textfilen.
            Transaction.GetTransactionList().Add(new Transaction { Amount = 150, Type = "Inkomst" });

            // Anropar sedan vår metod som nu sparar transaktionen och skriver in den i textfilen.
            SaveAndLoadData saveTransaction = new SaveAndLoadData();
            saveTransaction.SaveData();

            // Vi skapar först en variabel som innehåller filens sökväg.
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\transaktioner.txt");

            // Sen skapar vi en annan variabel som innehåller filens innehåll.
            // ReadAllText läser också av filen och lagrar innehållet i variabeln.
            string fileContent = File.ReadAllText(filePath);

            // Vi kollar slutligen om fileContent innehåller transaktionen som skapades nyss.
            Assert.Contains("150", fileContent);
            Assert.Contains("Inkomst", fileContent);
        }
    }
}
