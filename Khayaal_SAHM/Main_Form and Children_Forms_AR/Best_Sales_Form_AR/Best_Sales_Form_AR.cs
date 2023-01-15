using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Khayaal_SAHM.Main_Form_and_Children_Forms_AR.Best_Sales_Form_AR
{
    public partial class Best_Sales_Form_AR : Form
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
            if (Best_Sales_Table.Rows.Count == 0)
            {
                From_Date_Picker.Value = To_Date_Picker.Value = DateTime.Now;
                From_Time_Picker.Value = To_Time_Picker.Value = DateTime.Now;
            }
            else
            {
                DataTable x = new DataTable();
                Formatter.Check_Connection(conn);
                SqlDataAdapter Date_Adapter = new SqlDataAdapter("SELECT MIN([Date]),MAX([Date]) FROM CR.Bills;", conn);
                conn.Open();
                Date_Adapter.Fill(x);
                conn.Close();
                To_Time_Picker.Value = new DateTime(2023, 1, 12, 23, 59, 59);
                From_Time_Picker.Value = new DateTime(2023, 1, 12, 0, 0, 0);

                From_Date_Picker.Value = Convert.ToDateTime(x.Rows[0][0]);
                To_Date_Picker.Value = Convert.ToDateTime(x.Rows[0][1]);
            }
        }
        public Best_Sales_Form_AR()
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
            row["Category"] = "الجميع";
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
            Best_Sales_Table.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                double total = (double)row[2];
                Best_Sales_Table.Rows.Add((string)row[0], (int)row[1], total, (total * .14 + total));
            }
            try
            {
                Table_Croll_Bar.Maximum = Best_Sales_Table.Rows.Count - 1;
            }
            catch { }
            string Qty = Formatter.Float($"{Best_Sales_Table.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[1].Value))}");

            string Total = Formatter.Float($"{Best_Sales_Table.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDouble(t.Cells[2].Value))}");
            double Total_Double = Convert.ToDouble(Total);

            string Total_With_Tax = Formatter.Float($"{Total_Double + Total_Double * .14}");
            Count_Value_Label.Text = $"{Best_Sales_Table.Rows.Count}";

            Qty_Value_Label.Text = Qty;
            Sum_Total_Value_Label.Text = $"{Total} $";
            With_Tax_Value_Label.Text = Formatter.Float($"{Total_With_Tax}") + " $";
        }
        void Choose_Query()
        {
            string From = Formatter.Date_Formating(From_Date_Picker.Value, "Normal", From_Time_Picker.Value);
            string To = Formatter.Date_Formating(To_Date_Picker.Value, "Normal", To_Time_Picker.Value);

            if (DateTime.Parse(From) > DateTime.Parse(To))
            {
                From_Time_Picker.Value = To_Time_Picker.Value;
                From_Date_Picker.Value = To_Date_Picker.Value;
                MessageBox.Show("Data Range Error Change The Date Range!!", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (Category_Combo_Box.Text == "الجميع" && Search_Text_Box.Text == "")
                    Fill_Table($"SELECT [Name] as [Item]  , COUNT([Name]) as [Quantity],SUM([Sub_Total]) as [Total] From CR.Bills_Details WHERE Date BETWEEN '{From}' and '{To}'  GROUP BY [Name]  ORDER BY [Total] , [Quantity]  DESC;\r\n");
                else if (Category_Combo_Box.Text == "الجميع" && Search_Text_Box.Text != "")
                    Fill_Table($"SELECT [Name] as [Item] , COUNT([Name]) as Quantity,SUM(Sub_Total) as [Total] From CR.Bills_Details WHERE Date BETWEEN '{From}' and '{To}' and [Name] Like N'%{Khayaal_SAHM.Formatter.String(Search_Text_Box.Text)}%'  GROUP BY [Name]  ORDER BY [Total] , Quantity   DESC;");
                else if (Category_Combo_Box.Text != "الجميع" && Search_Text_Box.Text == "")
                    Fill_Table($"SELECT [Name] as [Item] , COUNT([Name]) as Quantity,SUM(Sub_Total) as [Total] From CR.Bills_Details WHERE Date BETWEEN '{From}' and '{To}' and CR.Get_Item_Category([Name]) = N'{Category_Combo_Box.Text}'  GROUP BY [Name]  ORDER BY [Total] , Quantity  DESC;");
                else if (Category_Combo_Box.Text != "الجميع" && Search_Text_Box.Text != "")
                    Fill_Table($"SELECT [Name] as [Item] , COUNT([Name]) as Quantity,SUM(Sub_Total) as [Total] From CR.Bills_Details WHERE Date BETWEEN '{From}' and '{To}' and [Name] Like N'%{Khayaal_SAHM.Formatter.String(Search_Text_Box.Text)}%' and CR.Get_Item_Category([Name]) = N'{Category_Combo_Box.Text}'  GROUP BY [Name]  ORDER BY [Total] , Quantity   DESC;");
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
           || (e.KeyChar == ' ' && Search_Text_Box.Text.Length == 0))

            {
                e.Handled = true;
            }
        }

        private void Table_Croll_Bar_Scroll(object sender, ScrollEventArgs e)
        {
            try
            {
                Table_Croll_Bar.Maximum = Best_Sales_Table.Rows.Count - 1;

                Best_Sales_Table.FirstDisplayedScrollingRowIndex = Best_Sales_Table.Rows[e.NewValue].Index;
            }
            catch { }

        }

        private void Best_Seller_Table_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                Table_Croll_Bar.Maximum = Best_Sales_Table.Rows.Count - 1;
            }
            catch { }
        }

        private void Best_Seller_Table_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            try
            {
                Table_Croll_Bar.Maximum = Best_Sales_Table.Rows.Count - 1;
            }
            catch { }
        }

        private void Edit_Buttton_Click(object sender, EventArgs e)
        {
            Excel.Application app = new Excel.Application();
            Excel.Workbook Work_Book = app.Workbooks.Add();
            Excel.Worksheet Work_Sheet = null;
            app.Visible = true;
            Work_Sheet = Work_Book.Sheets["Sheet1"];
            Work_Sheet = Work_Book.ActiveSheet;

            for (int i = 0; i < Best_Sales_Table.ColumnCount; i++)
            {
                Work_Sheet.Cells[1, i + 1] = Best_Sales_Table.Columns[i].HeaderText;
            }


            for (int j = 0; j < Best_Sales_Table.Rows.Count; j++)
            {
                for (int i = 0; i < Best_Sales_Table.Columns.Count; i++)
                {
                    Work_Sheet.Cells[j + 2, i + 1] = Best_Sales_Table.Rows[j].Cells[i].Value.ToString();
                }

            }
            Work_Sheet.Columns.AutoFit();
        }

        private void To_Time_Picker_ValueChanged(object sender, EventArgs e)
        {
            Choose_Query();
        }

        private void From_Time_Picker_ValueChanged(object sender, EventArgs e)
        {
            Choose_Query();
        }
    }
}
