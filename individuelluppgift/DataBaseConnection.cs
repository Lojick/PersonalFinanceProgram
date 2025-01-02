using Npgsql;

namespace PersonalFinanceProgram
{
    public static class DatabaseConnection
    {
        // Skapar en variabel som innehåller alla nödvändiga uppgifter för att ansluta till min Dockers-databas.
        // Den är private eftersom informationen är känslig samt static eftersom den ligger utanför GetConnection-metoden.
        // Den är utanför eftersom om jag väljer att ändra exempelvis databas, då kan jag bara ändra här istället för på alla anrop jag gjort med metoden.
        private static string connectionString =
            "Host=localhost;Port=5432;Username=postgres;Password=123;Database=personalfinanceprogram";

        // Metod som använder NpgsqlConnection-klassen som returtyp. NpgsqlConnection hanterar anslutningar till en PostgreSQL-server.
        public static NpgsqlConnection GetConnection()
        {
            try
            {
                return new NpgsqlConnection(connectionString);
            }
            catch (Exception ex)
            {
                throw new Exception("Fel vid skapande av databasanslutning: " + ex.Message);
            }
        }
    }
}
