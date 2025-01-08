using Npgsql;
using Microsoft.Extensions.Configuration;
using System;

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
                    throw new Exception("Connection string är tom eller saknas i appsettings.json.");
                }

                // Skapa och returnera en NpgsqlConnection
                return new NpgsqlConnection(connectionString);
            }
            catch (Exception ex)
            {
                // Logga och kasta vidare ett tydligt felmeddelande
                throw new Exception("Fel vid skapande av databasanslutning: " + ex.Message, ex);
            }
        }
    }
}
