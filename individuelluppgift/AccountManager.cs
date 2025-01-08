using System.Data;
using BCrypt.Net;
using Npgsql;

namespace PersonalFinanceProgram
{
    public static class AccountManager
    {
        // Registrerar en ny användare med en initial transaktion
        public static void RegisterUser(string name, string password, decimal initialAmount)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open(); // Öppnar anslutningen
                }
                catch (Exception ex)
                {
                    throw new Exception("Fel vid öppning av databasanslutning: " + ex.Message);
                }

                using (var transaction = connection.BeginTransaction()) // Börjar SQL-transaktionen
                {
                    try
                    {
                        // Hasha lösenordet
                        var hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

                        // Lägg till användaren i databasen
                        var addUserQuery = "INSERT INTO users (name, hashedPassword) VALUES (@name, @hashedPassword) RETURNING userid";
                        int userId;

                        using (var command = new NpgsqlCommand(addUserQuery, connection, transaction))
                        {
                            try
                            {
                                command.Parameters.AddWithValue("name", name);
                                command.Parameters.AddWithValue("hashedPassword", hashedPassword);
                                userId = Convert.ToInt32(command.ExecuteScalar());
                            }
                            catch (Exception ex)
                            {
                                throw new Exception("Fel vid registrering av användaren: " + ex.Message);
                            }
                        }

                        // Lägg till en initial transaktion
                        var addTransactionQuery = "INSERT INTO transactions (userid, amount, type, dateTime) VALUES (@userid, @amount, @type, @dateTime)";

                        using (var command = new NpgsqlCommand(addTransactionQuery, connection, transaction))
                        {
                            try
                            {
                                command.Parameters.AddWithValue("userid", userId);
                                command.Parameters.AddWithValue("amount", initialAmount);
                                command.Parameters.AddWithValue("type", "Inkomst");
                                command.Parameters.AddWithValue("dateTime", DateTime.Now);
                                command.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                throw new Exception("Fel vid skapande av initial transaktion: " + ex.Message);
                            }
                        }

                        // Commit om allt lyckas
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback(); // Rollback vid fel
                        throw new Exception("Fel vid transaktionshantering: " + ex.Message);
                    }
                }
            }
        }

        // Logga in användare
        public static int Login(string name, string password)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open(); // Öppnar anslutningen
                }
                catch (Exception ex)
                {
                    throw new Exception("Fel vid öppning av databasanslutning: " + ex.Message);
                }

                var query = "SELECT userid, hashedPassword FROM users WHERE name = @name";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("name", name);

                        using (var reader = command.ExecuteReader())
                        {
                            try
                            {
                                if (reader.Read())
                                {
                                    var hashedPassword = reader.GetString(1); // Hämtar hashat lösenord
                                    if (BCrypt.Net.BCrypt.Verify(password, hashedPassword))
                                    {
                                        return reader.GetInt32(0); // Returnerar användar-ID om lösenordet stämmer
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                throw new Exception("Fel vid verifiering av användaren: " + ex.Message);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Fel vid körning av inloggningsfrågan: " + ex.Message);
                    }
                }
            }

            throw new Exception("Ogiltigt användarnamn eller lösenord."); // Om inga resultat hittas
        }
    }
}
