
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Khayaal
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
        public static string SpecialFormatting(this string String) => String == string.Empty ? string.Empty :

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
        /// <param name="date">The Date_Time_Picker Value</param>
        /// <param name="case">The Case Of Formatting</param>
        /// <returns>String</returns>
        public static string DateFormating(DateTime date, string @case = "Normal", DateTime? time = null)//activated
        {
            string correctDate;
            if (@case == "From_Payment")
                correctDate = $"{date.Year}-{date.Month}-{date.Day} 00:00:00";
            else if (@case == "To_Payment")
                correctDate = $"{date.Year}-{date.Month}-{date.Day} 23:59:59";
            else if (time != null && @case == "Normal")
                correctDate = $"{date.Year}-{date.Month}-{date.Day} {time?.Hour}:{time?.Minute}:{time?.Second}";
            else
                correctDate = $"{date.Year}-{date.Month}-{date.Day} {date.Hour}:{date.Minute}:{date.Second}";
            return correctDate;
        }
        //Payment like (Bill,Best_Sales_Purchases)
        /// <summary>
        /// Used For (Validate The Date Range): Ensure That The Start Date is Before The End Date
        /// </summary>
        /// <param name="from">The Start of Range</param>
        /// <param name="to">The End of Range</param>
        /// <returns>Boolean</returns>
        public static bool CheckPaymentDateRange(DateTime from, DateTime to) => DateTime.Parse(DateFormating(from, "From_Payment")) < DateTime.Parse(DateFormating(to, "To_Payment"));//activated

        
        public static void CheckConnection(SqlConnection sqlConnection)
        {
            if (sqlConnection.State == ConnectionState.Open)
                sqlConnection.Close();
        }

    }



}

