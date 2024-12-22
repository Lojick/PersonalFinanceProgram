//namespace PersonalFinanceProgram
//{
//    using System;

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Skapar objekter för varsin klass så metoderna kan anropas på varsin instans av klassen.
//            TransactionManager manager = new TransactionManager();
//            SaveAndLoadData saveAndLoadData = new SaveAndLoadData();
//            saveAndLoadData.LoadData();
//            TransactionReport report = new TransactionReport();
//            Balance transaction = new Balance();

//            Console.WriteLine("Välkommen till Personal finance program! Navigera med tangenterna 1-5.");
//            while (true)
//            {
//                Meny.ShowMeny(); // Anropar metoden för att visa menyn.
//                ConsoleKeyInfo keyInfo = Console.ReadKey(true); // Vi vill att användaren ska navigera med tangenterna, så vi använder ConsoleKeyInfo-klassen.

//                // Eftersom användaren kommer mötas av 5 olika alternativ, så skapar vi en switch-sats för att implementera metoder och utföra programmet.
//                switch (keyInfo.Key) // 'ConsoleKey.D1' är en typ av enum-lista.
//                {
//                    case ConsoleKey.D1:
//                        Console.Clear();
//                        decimal balance = transaction.GetBalance(); // Eftersom vi vill lagra värdet på balance.
//                        Console.WriteLine($"Nuvarande kontosaldo är: {balance:C}. "); // Skriv ut resultatet.
//                        break;

//                    case ConsoleKey.D2:
//                        Console.Clear();
//                        Console.WriteLine("Välj följande alternativ (Tryck på '1' eller '2').");
//                        Console.WriteLine("1. Sätt in pengar");
//                        Console.WriteLine("2. Ta ut pengar");
//                        ConsoleKeyInfo typeKey = Console.ReadKey(true);
//                        string type = Meny.ChooseAlternatives(typeKey); // Deklarera string type och anropa metoden för att returnera värden "Inkomst eller "Utgift".
//                        Console.Clear();
//                        Console.WriteLine("Ange belopp:");
//                        decimal amount = Convert.ToDecimal(Console.ReadLine());
//                        manager.AddTransaction(amount, type); // Anropar metoden för att hämta amount och type för att skapa en transaktion.
//                        saveAndLoadData.SaveData();
//                        break;

//                    case ConsoleKey.D3:
//                        Console.Clear();
//                        Console.WriteLine("Vilken transaktion vill du ta bort? Skriv numret på listan.");
//                        //manager.ShowTransactions();
//                        int index = int.Parse(Console.ReadLine()) - 1; // Justera användarens inmatning för att passa indexet i listan (t.ex. 1 blir 0).
//                        manager.RemoveTransaction(index); // Anropar metoden.
//                        break;

//                    case ConsoleKey.D4: // Visar inkomster/utgifter årsvis, månadsvis, veckovis och dagvis.
//                        Console.Clear();
//                        report.ShowReport();
//                        break;

//                    case ConsoleKey.D5: // Avslutar programmet.
//                        Console.WriteLine("Avslutar programmet.. Tryck på valfri tangent för att stänga.");
//                        Console.ReadKey();
//                        return;
//                }

//                Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
//                Console.ReadKey(); // Vänta på användarens inmatning innan nästa iteration
//                Console.Clear();
//            }
//        }
//    }
//}
