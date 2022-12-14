using System;

namespace Khayaal_SAHM
{
    public class Formatter
    {
        public static string String(string String)//not_activated
        {
            if (String == null)
                String = string.Empty;
            else
                String = String;
            return String;
        }
        public static string Float(string String)//not_Avtivated
        {

            return String;
        }
        /// <summary>
        /// Correct The Date_Time_Picker Value Formating
        /// For Using it in a Sql Query
        /// </summary>
        /// <param name="Date">The Date_Time_Picker Value</param>
        /// <param name="Case">The Case Of Formatting</param>
        /// <returns>String</returns>
        public static string Date_Formating(DateTime Date, string Case)//activated
        {
            string Correct_Date;
            if (Case == "From_Payment")
                Correct_Date = $"{Date.Year}-{Date.Month}-{Date.Day} 00:00:00";
            else if (Case == "To_Payment")
                Correct_Date = $"{Date.Year}-{Date.Month}-{Date.Day} 23:59:59";
            else
                Correct_Date = $"{Date.Year}-{Date.Month}-{Date.Day} 23:59:59";
            return Correct_Date;
        }
        //Payment like (Bill,Best_Sales_Purchases)
        /// <summary>
        /// Used For (Validate The Date Range): Ensure That The Start Date is Before The End Date
        /// </summary>
        /// <param name="From">The Start of Range</param>
        /// <param name="To">The End of Range</param>
        /// <returns>Boolean</returns>
        public static bool Check_Payment_Date_Range(DateTime From, DateTime To) => DateTime.Parse(Date_Formating(From, "From_Payment")) < DateTime.Parse(Date_Formating(To, "To_Payment"));//activated





    }
}
