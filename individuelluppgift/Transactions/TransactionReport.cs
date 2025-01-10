using System;
using System.Collections.Generic;
using Npgsql;

namespace PersonalFinanceProgram
{
    // Klass för att skapa en rapport av utgifter och inkomster
    public static class TransactionReport
    {
        /// <summary>
        /// Genererar en rapport över utgifter årsvis, månadsvis, veckovis och dagvis.
        /// </summary>
        public static (string yearSpent, string monthSpent, string weekSpent, string daySpent) GetExpenseReport(int userId)
        {
            decimal yearSpent = 0;
            decimal monthSpent = 0;
            decimal weekSpent = 0;
            decimal daySpent = 0;

            using (var connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    var expenseQuery = "SELECT amount, dateTime FROM transactions WHERE userid = @userid AND type = 'Utgift'";

                    using (var command = new NpgsqlCommand(expenseQuery, connection))
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
                                        var amount = reader.GetDecimal(0);
                                        var dateTime = reader.GetDateTime(1);

                                        if (dateTime.Year == DateTime.Now.Year) yearSpent += amount;
                                        if (dateTime.Month == DateTime.Now.Month) monthSpent += amount;
                                        if (dateTime >= DateTime.Now.AddDays(-7)) weekSpent += amount;
                                        if (dateTime.Date == DateTime.Now.Date) daySpent += amount;
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

            return (
                $"Årsvis utgift: {yearSpent:C}",
                $"Månadsvis utgift: {monthSpent:C}",
                $"Veckovis utgift: {weekSpent:C}",
                $"Dagvis utgift: {daySpent:C}"
            );
        }

        /// <summary>
        /// Genererar en rapport över inkomster årsvis, månadsvis, veckovis och dagvis.
        /// </summary>
        public static (string yearIncome, string monthIncome, string weekIncome, string dayIncome) GetIncomeReport(int userId)
        {
            decimal yearIncome = 0;
            decimal monthIncome = 0;
            decimal weekIncome = 0;
            decimal dayIncome = 0;

            using (var connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    var incomeQuery = "SELECT amount, dateTime FROM transactions WHERE userid = @userid AND type = 'Inkomst'";

                    using (var command = new NpgsqlCommand(incomeQuery, connection))
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
                                        var amount = reader.GetDecimal(0);
                                        var dateTime = reader.GetDateTime(1);

                                        if (dateTime.Year == DateTime.Now.Year) yearIncome += amount;
                                        if (dateTime.Month == DateTime.Now.Month) monthIncome += amount;
                                        if (dateTime >= DateTime.Now.AddDays(-7)) weekIncome += amount;
                                        if (dateTime.Date == DateTime.Now.Date) dayIncome += amount;
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

            return (
                $"Årsvis inkomst: {yearIncome:C}",
                $"Månadsvis inkomst: {monthIncome:C}",
                $"Veckovis inkomst: {weekIncome:C}",
                $"Dagvis inkomst: {dayIncome:C}"
            );
        }
    }
}

