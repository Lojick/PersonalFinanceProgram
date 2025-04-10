using System;
using System.Collections.Generic;
using Npgsql;

namespace PersonalFinanceProgram
{
    public static class TransactionManager
    {
        /// <summary>
        /// Lägger till en transaktion i databasen.
        /// </summary>
        public static void AddTransaction(int userid, decimal amount, string type, DateTime dateTime)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    var addTransactionQuery =
                        "INSERT INTO transactions (userid, amount, type, dateTime) VALUES (@userid, @amount, @type, @dateTime)";

                    using (var command = new NpgsqlCommand(addTransactionQuery, connection))
                    {
                        try
                        {
                            command.Parameters.AddWithValue("userid", userid);
                            command.Parameters.AddWithValue("amount", amount);
                            command.Parameters.AddWithValue("type", type);
                            command.Parameters.AddWithValue("dateTime", dateTime);
                            command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("Fel vid inlägg av transaktion: " + ex.Message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Fel vid öppning av databasanslutning: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// Hämtar och returnerar transaktioner för en användare, tillsammans med användarnamnet.
        /// </summary>
        public static List<(string UserName, Transaction Transaction)> GetTransactions(int userId)
        {
            var results = new List<(string UserName, Transaction Transaction)>();

            using (var connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    var query = @"
                        SELECT u.name, t.transactionid, t.amount, t.type, t.dateTime 
                        FROM users u
                        JOIN transactions t ON u.userid = t.userid
                        WHERE u.userid = @userid";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        try
                        {
                            command.Parameters.AddWithValue("userid", userId);

                            using (var reader = command.ExecuteReader())
                            {
                                try
                                {
                                    while (reader.Read())
                                    {
                                        results.Add((
                                            reader.GetString(0), // UserName
                                            new Transaction
                                            {
                                                TransactionId = reader.GetInt32(1),
                                                UserId = userId,
                                                Amount = reader.GetDecimal(2),
                                                Type = reader.GetString(3),
                                                DateTime = reader.GetDateTime(4),
                                            }
                                        ));
                                    }
                                }
                                catch (Exception ex)
                                {
                                    throw new Exception("Fel vid läsning av transaktioner: " + ex.Message);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("Fel vid exekvering av SELECT-fråga: " + ex.Message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Fel vid öppning av databasanslutning: " + ex.Message);
                }
            }

            return results;
        }

        /// <summary>
        /// Tar bort en transaktion från databasen baserat på transactionid och userid.
        /// </summary>
        public static void RemoveTransaction(int transactionid, int userid)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    var query =
                        "DELETE FROM transactions WHERE transactionid = @transactionid AND userid = @userid";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        try
                        {
                            command.Parameters.AddWithValue("transactionid", transactionid);
                            command.Parameters.AddWithValue("userid", userid);
                            command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("Fel vid radering av transaktion: " + ex.Message);
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
}
