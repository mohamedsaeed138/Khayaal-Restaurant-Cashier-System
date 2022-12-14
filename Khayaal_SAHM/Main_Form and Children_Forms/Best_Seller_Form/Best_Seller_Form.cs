using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Khayaal_SAHM.Main_Form_and_Children_Forms.Best_Seller_Form
{
    public partial class Best_Seller_Form : Form
    {
        static SqlConnection conn = new SqlConnection(Connection_String.Value);


        private void Search_Text_Box_TextChanged(object sender, EventArgs e)
        {
            Choose_Query();
        }

        public Best_Seller_Form()
        {
            DateTime Current = DateTime.Now;
            InitializeComponent();
            Fill_Combo_Box();
            From_Date_Picker.Value = Current;
            To_Date_Picker.Value = Current;
            Fill_Table($"SELECT[Name] as [Item],COUNT(Name) as Quntity, [Category] From CR.Bills_Details  GROUP BY Name ,Category ORDER BY Quntity DESC;");

        }
        public void Fill_Combo_Box()
        {
            conn.Open();
            string sql = "select Category from CR.Items GROUP BY Category";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            DataRow row = dt.NewRow();
            dt.Rows.InsertAt(row, 0);
            row["Category"] = "All";
            Category_Combo_Box.DataSource = dt;
            Category_Combo_Box.DisplayMember = "Category";

        }

        void Fill_Table(string Query)
        {

            SqlCommand Command = new SqlCommand(Query, conn);
            SqlDataAdapter da = new SqlDataAdapter(Command);
            DataTable dt = new DataTable();
            conn.Open();
            try { da.Fill(dt); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            conn.Close();
            Best_Seller_Table.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {

                Best_Seller_Table.Rows.Add((string)row[0], (int)row[1], (string)row[2]);
            }
            Count_Value_Label.Text = $"{Best_Seller_Table.Rows.Count}";
        }
        void Choose_Query()
        {
            if (From_Date_Picker.Value.Year > To_Date_Picker.Value.Year && From_Date_Picker.Value.Day > To_Date_Picker.Value.Day && From_Date_Picker.Value.Month > To_Date_Picker.Value.Month)
                MessageBox.Show(From_Date_Picker.Value.TimeOfDay.ToString());
            else if (Category_Combo_Box.Text == "All" && Search_Text_Box.Text == "")
                Fill_Table($"SELECT[Name] as [Item],COUNT(Name) as Quntity, [Category] From CR.Bills_Details WHERE Date BETWEEN '{HDF(From_Date_Picker.Value, "From")}' and '{HDF(To_Date_Picker.Value, "To")}'   GROUP BY Name ,Category ORDER BY Quntity DESC;");
            else if (Category_Combo_Box.Text == "All" && Search_Text_Box.Text != "")
                Fill_Table($"SELECT[Name] as [Item],COUNT(Name) as Quntity, [Category] From CR.Bills_Details WHERE Date BETWEEN '{HDF(From_Date_Picker.Value, "From")}' and '{HDF(To_Date_Picker.Value, "To")}' and Name Like '{Search_Text_Box.Text}%'  GROUP BY Name ,Category ORDER BY Quntity DESC;");
            else if (Category_Combo_Box.Text != "All" && Search_Text_Box.Text == "")
                Fill_Table($"SELECT[Name] as [Item],COUNT(Name) as Quntity, [Category] From CR.Bills_Details WHERE Date BETWEEN '{HDF(From_Date_Picker.Value, "From")}' and '{HDF(To_Date_Picker.Value, "To")}' and Category = N'{Category_Combo_Box.Text}'  GROUP BY Name ,Category ORDER BY Quntity DESC;");
            else if (Category_Combo_Box.Text != "All" && Search_Text_Box.Text != "")
                Fill_Table($"SELECT[Name] as [Item],COUNT(Name) as Quntity, [Category] From CR.Bills_Details WHERE Date BETWEEN '{HDF(From_Date_Picker.Value, "From")}' and '{HDF(To_Date_Picker.Value, "To")}' and Name Like '{Search_Text_Box.Text}%' and Category = N'{Category_Combo_Box.Text}'  GROUP BY Name ,Category ORDER BY Quntity DESC;");
        }







        string HDF(DateTime Date, string Case)//Handle Date Format
        {
            string Correct_Date;
            if (Case == "From")
                Correct_Date = $"{Date.Year}-{Date.Month}-{Date.Day} 00:00:00";
            else
                Correct_Date = $"{Date.Year}-{Date.Month}-{Date.Day} 23:59:59";
            return Correct_Date;
        }

        private void Category_Combo_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            Choose_Query();
        }

        private void From_Date_Picker_ValueChanged(object sender, EventArgs e)
        {
            Choose_Query();
        }

        private void To_Date_Picker_ValueChanged(object sender, EventArgs e)
        {
            Choose_Query();
        }
    }
}
