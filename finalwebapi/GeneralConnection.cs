namespace finalwebapi
{
    public class GeneralConnection
    {
        public static string datasource = @"KCT-L-441\SQLEXPRESS";
        public static string database = "User_jain";
        public static string username = "sa";
        public static string password = "password";



        public static string connStringPass()
        {
            return @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;" + "User ID=" + username + ";" + "Password=" + password;

                     


        }

        public static string connStringWithoutPass()
        {
            return @"Data Source=" + datasource + 
                ";Initial Catalog=" + database + 
                ";Persist Security Info=True;" +
                "Integrated Security=SSPI";



        }
        
    }
}
