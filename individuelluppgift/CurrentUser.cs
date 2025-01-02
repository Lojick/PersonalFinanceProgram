namespace PersonalFinanceProgram
{
    public static class CurrentUser
    {
        public static int UserID { get; private set; } // Lagrar användarens ID
        public static string UserName { get; private set; } // Lagrar användarens namn

        // Sätter inloggad användares ID och namn
        public static void SetUser(int userid, string username)
        {
            UserID = userid;
            UserName = username;
        }

        // Loggar ut användaren och återställer värden
        public static void Logout()
        {
            UserID = 0;
            UserName = null;
        }
    }
}
