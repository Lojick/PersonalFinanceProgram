using PersonalFinanceProgram;
namespace PersonalFinanceGUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            //Laddar GUI:n.
            ApplicationConfiguration.Initialize();

            //Laddar upp tabeller.
            DatabaseConnection.LoadTables(); 

            //Öppnar loginrutan.
            Application.Run(new LoginForm());
        }
    }
}