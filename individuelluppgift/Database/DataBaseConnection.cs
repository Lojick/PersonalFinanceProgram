using System;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace PersonalFinanceProgram
{
    public static class DatabaseConnection
    {
        /// <summary>
        /// Skapar och returnerar en NpgsqlConnection för att ansluta till PostgreSQL.
        /// ConnectionString hämtas från appsettings.json.
        /// </summary>
        public static NpgsqlConnection GetConnection()
        {
            try
            {
                // Bygg konfiguration för att läsa appsettings.json
                var builder = new ConfigurationBuilder()
                    .SetBasePath(AppContext.BaseDirectory) // Basväg för projektet
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true); // Kräver att filen finns

                var config = builder.Build();

                // Hämta connection string från appsettings.json
                string connectionString = config.GetConnectionString("DefaultConnection");
                if (string.IsNullOrEmpty(connectionString))
                {
                    throw new Exception(
                        "Connection string är tom eller saknas i appsettings.json."
                    );
                }

                // Skapa och returnera en NpgsqlConnection
                return new NpgsqlConnection(connectionString);
            }
            catch (Exception ex)
            {
                // Logga och kasta vidare ett tydligt felmeddelande
                Console.WriteLine($"Fel vid skapande av databasanslutning: {ex.Message}");
                throw new Exception("Ett fel inträffade vid skapande av databasanslutning.", ex);
            }
        }

        //Metod som skapar tabeller.
        public static void LoadTables()
        {
            try
            {
                using (var connection = GetConnection())
                {
                    try
                    {
                        connection.Open();
                    }
                    catch (Exception ex)
                    {
                        // Fel vid öppning av anslutningen
                        Console.WriteLine($"Fel vid öppning av anslutning: {ex.Message}");
                        throw new Exception("Kunde inte öppna anslutningen till databasen.", ex);
                    }

                    string createTables =
                        @"
                        -- Tabell för användare
                        CREATE TABLE IF NOT EXISTS users (
                            userid SERIAL PRIMARY KEY,
                            name VARCHAR(50) NOT NULL UNIQUE, -- Användarens namn ska vara unikt
                            hashedPassword TEXT NOT NULL
                        );

                        -- Tabell för transaktioner
                        CREATE TABLE IF NOT EXISTS transactions (
                            transactionid SERIAL PRIMARY KEY,
                            userid INTEGER NOT NULL REFERENCES users(userid) ON DELETE CASCADE, -- Raderar transaktioner om en användare tas bort.
                            amount DECIMAL(10, 2) NOT NULL, -- Begränsar till två decimaler
                            type TEXT NOT NULL,
                            dateTime TIMESTAMP NOT NULL -- Lagrar både datum och tid
                        );
                        ";

                    try
                    {
                        using (var command = new NpgsqlCommand(createTables, connection))
                        {
                            command.ExecuteNonQuery();
                            Console.WriteLine("Tables created successfully.");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Fel vid exekvering av SQL-kommandot
                        Console.WriteLine($"Fel vid skapande av tabeller: {ex.Message}");
                        throw new Exception("Ett fel inträffade vid skapande av tabeller.", ex);
                    }
                }
            }
            catch (Exception ex)
            {
                // Logga och kasta vidare generella fel vid databasoperationen
                Console.WriteLine($"Ett fel inträffade i LoadTables: {ex.Message}");
                throw new Exception("Ett oväntat fel inträffade vid laddning av tabeller.", ex);
            }
        }
    }
}
