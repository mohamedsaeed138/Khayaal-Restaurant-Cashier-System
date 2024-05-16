using System;

namespace Khayaal
{
    //USE it FOR SQL CONNNECTION OBJECT
    /// <summary>
    /// an example
    /// sqlconnection x=new sqlconnection(Connection_String.Value)
    /// </summary>
    public static class ConnectionString
    {
        public static readonly string Value = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Environment.CurrentDirectory}\\DataBase\\Restaurant_Cafe.mdf;Integrated Security=True; Connect Timeout = 30";
    }

}
