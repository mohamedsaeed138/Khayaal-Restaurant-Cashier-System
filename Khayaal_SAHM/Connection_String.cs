using System;

namespace Khayaal_SAHM
{
    //USE it FOR SQL CONNNECTION OBJECT
    /// <summary>
    /// an example
    /// sqlconnection x=new sqlconnection(Connection_String.Value)
    /// </summary>
    public class Connection_String
    {
        public static string Value = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Environment.CurrentDirectory}\\DataBase\\Restaurant_Cafe.mdf;Integrated Security=True; Connect Timeout = 30";
    }

}
