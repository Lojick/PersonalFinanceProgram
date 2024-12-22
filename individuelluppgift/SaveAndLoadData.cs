using System;
using System.IO;
using System.Transactions;

namespace PersonalFinanceProgram
{
    public class SaveAndLoadData : Transaction
    {
        // Vi vill att denna filväg ska vara privat och konstant så den inte kan ändras.
        // För att undvika att filen ej uppdateras med olika enheter eller program har jag specificerat filvägen extra noggrant.
        public static readonly string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\transaktioner.txt");

        // Metod som sparar transactionList till en fil.
        public void SaveData()
        {
            try
            {
                // Vi använder StreamWriter för att skriva ut varje rad till filen.
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var transaction in transactionList) // Loopar igenom varje transaktion i listan.
                    {
                        // Skriver ut detaljerna för varje transaktion med formaterat datum.
                        writer.WriteLine($"{transaction.Amount} kr , {transaction.Type}, {transaction.Date:yyyy-MM-dd HH:mm:ss}");
                    }
                } // Filen stängs automatiskt här.

                Console.WriteLine("Transaktioner sparade!"); // Bekräftelsemeddelande
            }
            catch (Exception ex)
            {
                // Fångar eventuella fel vid sparandet och skriver ut meddelande.
                Console.WriteLine($"Ett fel uppstod vid sparandet: {ex.Message}");
            }
        }

        // Metod som laddar data från filen och läser in i transactionList.
        public void LoadData()
        {
            // Om filen 'filePath' inte finns, visa meddelande och avbryt.
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Inga sparade transaktioner att ladda.");
                return; // Avbryt om filen inte finns.
            }

            transactionList.Clear(); // Rensa listan innan vi läser in från filen.

            using (StreamReader reader = new StreamReader(filePath)) // Använder StreamReader för att läsa rad för rad.
            {
                string line; // Deklarerar strängen 'line' för att läsa varje rad.

                // Läser in varje rad tills filen är slut.
                while ((line = reader.ReadLine()) != null)
                {
                    // Delar upp raden i delar baserat på kommatecken.
                    string[] parts = line.Split(',');

                    try
                    {
                        // Rensar bort 'kr' och eventuella mellanrum från beloppet så programmet ej kraschar när man startar den.
                        string amountString = parts[0].Replace(" kr", "").Trim();

                        // Skapar en ny transaktion baserat på data från raden.
                        Transaction newTransaction = new Transaction
                        {
                            Amount = decimal.Parse(amountString),
                            Type = parts[1].Trim(),
                            Date = DateTime.Parse(parts[2].Trim())
                        };

                        // Lägger till den nya transaktionen i listan.
                        transactionList.Add(newTransaction);
                    }
                    catch (FormatException ex)
                    {
                        // Felhantering för parsning av data från filen.
                        Console.WriteLine("Fel vid parsning: " + ex);
                    }
                }
            }
        }
    }
}
