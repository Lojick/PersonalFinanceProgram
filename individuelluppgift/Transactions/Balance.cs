using Npgsql;

namespace PersonalFinanceProgram
{
    public static class Balance
    {
        public static decimal GetBalance(int userId)
        {
            decimal inkomst = 0; // Här sparar vi summan av inkomster
            decimal utgift = 0;  // Här sparar vi summan av utgifter

            try
            {
                // Skapa och öppna databasanslutningen
                using (var connection = DatabaseConnection.GetConnection())
                {
                    try
                    {
                        connection.Open();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Fel vid öppning av databasanslutning: " + ex.Message);
                    }

                    // Hämta inkomster
                    try
                    {
                        var incomeQuery = "SELECT SUM(amount) FROM transactions WHERE userid = @userid AND type = 'Inkomst'";
                        using (var incomeCmd = new NpgsqlCommand(incomeQuery, connection))
                        {
                            incomeCmd.Parameters.AddWithValue("userid", userId);

                            // Kör SQL-frågan och hämta resultat
                            var result = incomeCmd.ExecuteScalar();

                            // Kontrollera om resultatet är null
                            if (result != null && result != DBNull.Value)
                            {
                                inkomst = Convert.ToDecimal(result); // Konvertera till decimal
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Fel vid hämtning av inkomster: " + ex.Message);
                    }

                    // Hämta utgifter
                    try
                    {
                        var expenseQuery = "SELECT SUM(amount) FROM transactions WHERE userid = @userid AND type = 'Utgift'";
                        using (var expenseCmd = new NpgsqlCommand(expenseQuery, connection))
                        {
                            expenseCmd.Parameters.AddWithValue("userid", userId);

                            // Kör SQL-frågan och hämta resultat
                            var result = expenseCmd.ExecuteScalar();

                            // Kontrollera om resultatet är null
                            if (result != null && result != DBNull.Value)
                            {
                                utgift = Convert.ToDecimal(result); // Konvertera till decimal
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Fel vid hämtning av utgifter: " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ett oväntat fel inträffade vid databasanrop: " + ex.Message);
            }

            // Returnera balansen (inkomst - utgift)
            return inkomst - utgift;
        }
    }
}
