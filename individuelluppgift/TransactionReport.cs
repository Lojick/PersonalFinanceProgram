using System;
using System.Collections.Generic;
using Npgsql;

namespace PersonalFinanceProgram
{
    // Klass för att skapa en rapport av utgifter och inkomster
    public static class TransactionReport
    {
        // Metod för att visa utgifter periodsvis (returnera varje variabel som representerar en viss period)
        public static (string yearSpent, string monthSpent, string weekSpent, string daySpent) GetExpenseReport(int userId)
        {
            // Börjar med att sätta värden på 0
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
                                        // Läser raderna ifrån tabellen, tar ut värden ifrån kolumnerna amount och datetime som tillämpas efteråt.
                                        var amount = reader.GetDecimal(0);
                                        var dateTime = reader.GetDateTime(1);
                                        // Logik för att filtrera årsvis, månadsvis, veckovis och dagvis.
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
            // Slutligen returnera och visa årsvis, månadsvis, veckovis och dagvis.
            return (
                $"Årsvis utgift: {yearSpent:C}",
                $"Månadsvis utgift: {monthSpent:C}",
                $"Veckovis utgift: {weekSpent:C}",
                $"Dagvis utgift: {daySpent:C}"
            );
        }

        // Samma logik på denna metoden fast inkomst-baserat istället.
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
