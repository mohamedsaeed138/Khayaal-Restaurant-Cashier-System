
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Khayaal_SAHM
{
    public static class Formatter
    {
        /// <summary>
        /// to Put any text in Foramt "Mmmmmmm Ssssssss" and erased the first and last space if was existed
        /// </summary>
        /// <example> "  MMsassa ssaddedAS" => "Mmsassa Ssaddedas"</example>
        /// <example> "  MMsassa ssaddedAS" => "Mmsassa Ssaddedas"</example>
        /// <param name="String"></param>
        /// <returns></returns>
        public static string Special_Formatting(this string String) => String == string.Empty ? string.Empty :

                            string.Join(" ", String.Trim().Split(' ')

                            .Where(x => !string.IsNullOrWhiteSpace(x))

                            .Select(x => char.ToUpper(x[0]) + x.ToLower().Substring(1)).ToArray<string>()
                           );



        /// <summary>
        /// بيقرب اي سترينج من تنسيق الفلوت لأقرب رقمين عشريين
        /// </summary>
        /// <example>زي مثلا تيكست بوكس بياخد سعر او كمية فلازم يتقرب قبل ما تتبعت للداتا بيز</example>
        /// <param name="String">Float string Need TO BE ROUNDED </param>
        /// <returns>Sring</returns>
        public static string Float(string String)//not_Avtivated
        {

            return Math.Round(float.Parse(String), 2).ToString();
        }
        /// <summary>
        /// Correct The Date_Time_Picker Value Formating
        /// For Using it in a Sql Query
        /// </summary>
        /// <param name="Date">The Date_Time_Picker Value</param>
        /// <param name="Case">The Case Of Formatting</param>
        /// <returns>String</returns>
        public static string Date_Formating(DateTime Date, string Case = "Normal", DateTime? Time = null)//activated
        {
            string Correct_Date;
            if (Case == "From_Payment")
                Correct_Date = $"{Date.Year}-{Date.Month}-{Date.Day} 00:00:00";
            else if (Case == "To_Payment")
                Correct_Date = $"{Date.Year}-{Date.Month}-{Date.Day} 23:59:59";
            else if (Time != null && Case == "Normal")
                Correct_Date = $"{Date.Year}-{Date.Month}-{Date.Day} {Time?.Hour}:{Time?.Minute}:{Time?.Second}";
            else
                Correct_Date = $"{Date.Year}-{Date.Month}-{Date.Day} {Date.Hour}:{Date.Minute}:{Date.Second}";
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
        /// <summary>
        /// Check there is no any intersections With Other Bookings Date Ranges
        /// </summary>
        /// <param name="Bookings">List of Booking of the same table</param>
        /// <returns>bool</returns>




        public static void Check_Connection(SqlConnection conn)
        {

            if (conn.State == ConnectionState.Open)
                conn.Close();

        }

    }



}

