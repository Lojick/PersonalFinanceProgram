using BCrypt.Net;
using Npgsql;
using PersonalFinanceProgram;

public class UpdateUser
{
    // Uppdaterar användarens profilinformation (namn och lösenord).
 
    public static void UpdateUserProfile(int userId, string newName, string newPassword)
    {
        using (var connection = DatabaseConnection.GetConnection())
        {
            try
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Uppdatera användarnamnet
                        var updateNameQuery = "UPDATE users SET name = @newName WHERE userId = @userId";
                        using (var command = new NpgsqlCommand(updateNameQuery, connection, transaction))
                        {
                            try
                            {
                                command.Parameters.AddWithValue("newName", newName);
                                command.Parameters.AddWithValue("userId", userId);
                                command.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                throw new Exception("Fel vid uppdatering av användarnamnet: " + ex.Message);
                            }
                        }

                        // Uppdatera lösenordet
                        var hashedPassword = BCrypt.Net.BCrypt.HashPassword(newPassword);
                        var updatePasswordQuery = "UPDATE users SET hashedPassword = @hashedPassword WHERE userId = @userId";
                        using (var command = new NpgsqlCommand(updatePasswordQuery, connection, transaction))
                        {
                            try
                            {
                                command.Parameters.AddWithValue("hashedPassword", hashedPassword);
                                command.Parameters.AddWithValue("userId", userId);
                                command.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                throw new Exception("Fel vid uppdatering av lösenordet: " + ex.Message);
                            }
                        }

                        // Bekräfta ändringarna
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        // Rulla tillbaka ändringarna vid fel
                        transaction.Rollback();
                        throw new Exception("Fel vid hantering av transaktion: " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Fel vid öppning av databasanslutning: " + ex.Message);
            }
        }
    }
}
