using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Khayaal_SAHM.Main_Form_and_Children_Forms.Best_Sales_Form
{
    public partial class Best_Sales_Form : Form
    {
        static SqlConnection conn = new SqlConnection(Connection_String.Value);


        private void Search_Text_Box_TextChanged(object sender, EventArgs e)
        {
            Choose_Query();
        }
        void Reload()
        {
            InitializeComponent();
            Fill_Combo_Box();
            Fill_Table($"SELECT [Name] as [Item]  , COUNT([Name]) as [Quantity],SUM([Sub_Total]) as [Total] From CR.Bills_Details  GROUP BY [Name]  ORDER BY [Total] , [Quantity]  DESC;");
            if (To_Date_Picker.Value < new DateTime(2022, 1, 1))
                To_Date_Picker.Value = DateTime.Now;
            From_Date_Picker.Value = new DateTime(2022, 1, 1);
            To_Date_Picker.Value = DateTime.Now;
        }
        public Best_Sales_Form()
        {
            Reload();

        }
        public void Fill_Combo_Box()
        {
            Formatter.Check_Connection(conn);
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
            Formatter.Check_Connection(conn);

            SqlCommand Command = new SqlCommand(Query, conn);
            SqlDataAdapter da = new SqlDataAdapter(Command);
            DataTable dt = new DataTable();
            conn.Open();
            da.Fill(dt);


            conn.Close();
            Best_Seller_Table.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                double total = (double)row[2];
                Best_Seller_Table.Rows.Add((string)row[0], (int)row[1], total, (total * .14 + total));
            }
            try
            {
                Table_Croll_Bar.Maximum = Best_Seller_Table.Rows.Count - 1;
            }
            catch { }
            string Qty = Formatter.Float($"{Best_Seller_Table.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[1].Value))}");

            string Total = Formatter.Float($"{Best_Seller_Table.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDouble(t.Cells[2].Value))}");
            double Total_Double = Convert.ToDouble(Total);

            string Total_With_Tax = Formatter.Float($"{Total_Double + Total_Double * .14 / 100}");
            Count_Value_Label.Text = $"{Best_Seller_Table.Rows.Count}";

            Qty_Value_Label.Text = Qty;
            Sum_Total_Value_Label.Text = $"{Total} $";
            With_Tax_Value_Label.Text = Formatter.Float($"{Total_With_Tax}") + " $";
        }
        void Choose_Query()
        {
            if (!(Khayaal_SAHM.Formatter.Check_Payment_Date_Range(From_Date_Picker.Value, To_Date_Picker.Value)))
            {
                From_Date_Picker.Value = To_Date_Picker.Value;
                MessageBox.Show("Data Range Error Change The Date Range!!", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                string From = Khayaal_SAHM.Formatter.Date_Formating(From_Date_Picker.Value, "From_Payment"), To = Khayaal_SAHM.Formatter.Date_Formating(To_Date_Picker.Value, "To_Payment");
                if (Category_Combo_Box.Text == "All" && Search_Text_Box.Text == "")
                    Fill_Table($"SELECT [Name] as [Item]  , COUNT([Name]) as [Quantity],SUM([Sub_Total]) as [Total] From CR.Bills_Details WHERE Date BETWEEN '{From}' and '{To}'  GROUP BY [Name]  ORDER BY [Total] , [Quantity]  DESC;\r\n");
                else if (Category_Combo_Box.Text == "All" && Search_Text_Box.Text != "")
                    Fill_Table($"SELECT [Name] as [Item] , COUNT([Name]) as Quantity,SUM(Sub_Total) as [Total] From CR.Bills_Details WHERE Date BETWEEN '{From}' and '{To}' and [Name] Like '{Khayaal_SAHM.Formatter.String(Search_Text_Box.Text)}%'  GROUP BY [Name]  ORDER BY [Total] , Quantity   DESC;");
                else if (Category_Combo_Box.Text != "All" && Search_Text_Box.Text == "")
                    Fill_Table($"SELECT [Name] as [Item] , COUNT([Name]) as Quantity,SUM(Sub_Total) as [Total] From CR.Bills_Details WHERE Date BETWEEN '{From}' and '{To}' and CR.Get_Item_Category([Name]) = N'{Category_Combo_Box.Text}'  GROUP BY [Name]  ORDER BY [Total] , Quantity  DESC;");
                else if (Category_Combo_Box.Text != "All" && Search_Text_Box.Text != "")
                    Fill_Table($"SELECT [Name] as [Item] , COUNT([Name]) as Quantity,SUM(Sub_Total) as [Total] From CR.Bills_Details WHERE Date BETWEEN '{From}' and '{To}' and [Name] Like '{Khayaal_SAHM.Formatter.String(Search_Text_Box.Text)}%' and CR.Get_Item_Category([Name]) = N'{Category_Combo_Box.Text}'  GROUP BY [Name]  ORDER BY [Total] , Quantity   DESC;");
            }
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
