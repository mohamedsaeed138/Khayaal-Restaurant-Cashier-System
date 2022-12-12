namespace Khayaal_SAHM
{
    //USE it FOR SQL CONNNECTION OBJECT
    /// <summary>
    /// an example
    /// sqlconnection x=new sqlconnection(Connection_String.Value)
    /// </summary>
    public class Connection_String
    {
        public static string Value = MS;
        private static string HS = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\GitHub\SAHM\Khayaal_SAHM\DataBase\Restaurant_Cafe.mdf;Integrated Security=True;Connect Timeout=30";
        private static string AR = @"";
        private static string KS = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\SAHM\SAHM\Khayaal_SAHM\DataBase\Restaurant_Cafe.mdf;Integrated Security=True;Connect Timeout=30";
        private static string MS = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=E:\SAHM\Khayaal_SAHM\DataBase\Restaurant_Cafe.mdf;Integrated Security = True; Connect Timeout = 30";
        private static string AG = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\SOM DH\SAHM\Khayaal_SAHM\DataBase\Restaurant_Cafe.mdf"";Integrated Security=True";

    }

}
