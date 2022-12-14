using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Khayaal_SAHM.Main_Form_and_Children_Forms.Best_Seller_Form
{
    public partial class Best_Sales_Form : Form
    {
        static SqlConnection conn = new SqlConnection(Connection_String.Value);


        private void Search_Text_Box_TextChanged(object sender, EventArgs e)
        {
            Choose_Query();
        }

        public Best_Sales_Form()
        {

            InitializeComponent();

            Fill_Table($"SELECT[Name] as [Item],[Category], COUNT(Name) as Quntity,SUM(Sub_Total) as [Total] From CR.Bills_Details  GROUP BY Name ,Category ORDER BY [Total] , Quntity  DESC;");

            Fill_Combo_Box();
        }
        public void Fill_Combo_Box()
        {
            conn.Open();
            string sql = "SELECT Category FROM CR.Items GROUP BY Category";
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

                Best_Seller_Table.Rows.Add((string)row[0], (string)row[1], (int)row[2], (double)row[3]);
            }
            try
            {
                Table_Croll_Bar.Maximum = Best_Seller_Table.Rows.Count - 1;
            }
            catch { }
            Count_Value_Label.Text = $"{Best_Seller_Table.Rows.Count}";
        }
        void Choose_Query()
        {
            if (From_Date_Picker.Value.Year == To_Date_Picker.Value.Year && From_Date_Picker.Value.Day > To_Date_Picker.Value.Day && From_Date_Picker.Value.Month > To_Date_Picker.Value.Month)
                MessageBox.Show(From_Date_Picker.Value.TimeOfDay.ToString());
            else if (Category_Combo_Box.Text == "All" && Search_Text_Box.Text == "")
                Fill_Table($"SELECT[Name] as [Item],[Category], COUNT(Name) as Quntity,SUM(Sub_Total) as [Total] From CR.Bills_Details WHERE Date BETWEEN '{HDF(From_Date_Picker.Value, "From")}' and '{HDF(To_Date_Picker.Value, "To")}'   GROUP BY Name ,Category ORDER BY [Total] , Quntity   DESC;");
            else if (Category_Combo_Box.Text == "All" && Search_Text_Box.Text != "")
                Fill_Table($"SELECT[Name] as [Item],[Category], COUNT(Name) as Quntity,SUM(Sub_Total) as [Total] From CR.Bills_Details WHERE Date BETWEEN '{HDF(From_Date_Picker.Value, "From")}' and '{HDF(To_Date_Picker.Value, "To")}' and Name Like '{Search_Text_Box.Text}%'  GROUP BY Name ,Category ORDER BY [Total] , Quntity   DESC;");
            else if (Category_Combo_Box.Text != "All" && Search_Text_Box.Text == "")
                Fill_Table($"SELECT[Name] as [Item],[Category], COUNT(Name) as Quntity,SUM(Sub_Total) as [Total] From CR.Bills_Details WHERE Date BETWEEN '{HDF(From_Date_Picker.Value, "From")}' and '{HDF(To_Date_Picker.Value, "To")}' and Category = N'{Category_Combo_Box.Text}'  GROUP BY Name ,Category ORDER BY [Total] , Quntity  DESC;");
            else if (Category_Combo_Box.Text != "All" && Search_Text_Box.Text != "")
                Fill_Table($"SELECT[Name] as [Item],[Category], COUNT(Name) as Quntity,SUM(Sub_Total) as [Total] From CR.Bills_Details WHERE Date BETWEEN '{HDF(From_Date_Picker.Value, "From")}' and '{HDF(To_Date_Picker.Value, "To")}' and Name Like '{Search_Text_Box.Text}%' and Category = N'{Category_Combo_Box.Text}'  GROUP BY Name ,Category ORDER BY [Total] , Quntity   DESC;");
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

        private void Search_Text_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ' ' || (Search_Text_Box.Text.Length >= 50 && e.KeyChar != 8))
           || (Search_Text_Box.Text.Length > 1 && Search_Text_Box.Text[Search_Text_Box.Text.Length - 1] == ' ' && e.KeyChar == ' ') || (e.KeyChar == ' ' && Search_Text_Box.Text.Length == 0))

            {
                e.Handled = true;
            }
        }

        private void Table_Croll_Bar_Scroll(object sender, ScrollEventArgs e)
        {
            try
            {
                Table_Croll_Bar.Maximum = Best_Seller_Table.Rows.Count - 1;

                Best_Seller_Table.FirstDisplayedScrollingRowIndex = Best_Seller_Table.Rows[e.NewValue].Index;
            }
            catch { }

        }

        private void Best_Seller_Table_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                Table_Croll_Bar.Maximum = Best_Seller_Table.Rows.Count - 1;
            }
            catch { }
        }

        private void Best_Seller_Table_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            try
            {
                Table_Croll_Bar.Maximum = Best_Seller_Table.Rows.Count - 1;
            }
            catch { }
        }
    }
}
