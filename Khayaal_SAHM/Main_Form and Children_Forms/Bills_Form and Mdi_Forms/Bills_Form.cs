﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Khayaal_SAHM.Main_Form_and_Children_Forms.Bills_Form_and_Mdi_Forms
{
    public partial class Bills_Form : Form
    {
        static SqlConnection conn = new SqlConnection(Connection_String.Value);


        private void Search_Text_Box_TextChanged(object sender, EventArgs e)
        {
            Choose_Query();
        }

        public Bills_Form()
        {
            Reload();
        }
        void Reload()
        {
            InitializeComponent();
            Fill_Table($"select Serial_Number, Cashier_User_Name, Total, Date from CR.Bills;");
            if (Bills_Table.Rows.Count == 0)
            {
                From_Date_Picker.Value = To_Date_Picker.Value = DateTime.Now;
                From_Time_Picker.Value = To_Time_Picker.Value = DateTime.Now;
            }
            else
            {
                To_Time_Picker.Value = new DateTime(2023, 1, 12, 23, 59, 59);
                From_Time_Picker.Value = new DateTime(2023, 1, 12, 0, 0, 0);

                From_Date_Picker.Value = Convert.ToDateTime(Bills_Table.Rows[0].Cells[4].Value);
                To_Date_Picker.Value = Convert.ToDateTime(Bills_Table.Rows[Bills_Table.Rows.Count - 1].Cells[4].Value);

            }
        }



        void Fill_Table(string Query)
        {
            if (ConnectionState.Open == conn.State)
                conn.Close();
            SqlCommand Command = new SqlCommand(Query, conn);
            SqlDataAdapter da = new SqlDataAdapter(Command);
            DataTable dt = new DataTable();
            conn.Open();
            da.Fill(dt);


            conn.Close();
            Bills_Table.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                double total = (double)row[2];

                Bills_Table.Rows.Add((int)row[0], (string)row[1], total, (total * .14 + total), (DateTime)row[3]);


            }
            try
            {
                Table_Croll_Bar.Maximum = Bills_Table.Rows.Count - 1;
            }
            catch { }
            Count_Value_Label.Text = $"{Bills_Table.Rows.Count}";
            Sum_Without_Tax_Value_Label.Text = Formatter.Float($"{Bills_Table.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDouble(t.Cells[2].Value))}") + " $";
            Sum_Total_Value_Label.Text = Formatter.Float($"{Bills_Table.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDouble(t.Cells[3].Value))}") + " $";


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
                string Total = Formatter.String(Total_Search_Text_Box.Text);
                string Serial = Formatter.String(Search_Serial_Number_Text_Box.Text);
                if (Total_Search_Text_Box.Text == "" && Search_Serial_Number_Text_Box.Text == "")
                    Fill_Table($"select Serial_Number, Cashier_User_Name, Total, Date FROM CR.Bills WHERE Date BETWEEN '{From}' and '{To}' ;");
                else if (Total_Search_Text_Box.Text == "" && Search_Serial_Number_Text_Box.Text != "")
                    Fill_Table($"select Serial_Number, Cashier_User_Name, Total, Date FROM CR.Bills WHERE [Serial_Number] LIKE '{Serial}%' AND Date BETWEEN '{From}' and '{To}' ;");
                else if (Total_Search_Text_Box.Text != "" && Search_Serial_Number_Text_Box.Text == "")
                    Fill_Table($"select Serial_Number, Cashier_User_Name, Total, Date FROM CR.Bills WHERE [Total] <= {Total}  AND Date BETWEEN '{From}' and '{To}' ;");
                else
                    Fill_Table($"select Serial_Number, Cashier_User_Name, Total, Date FROM CR.Bills WHERE [Total] <= {Total} AND [Serial_Number] LIKE '{Serial}%' AND Date BETWEEN '{From}' and '{To}' ;");
            }
        }











        private void Search_Text_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && e.KeyChar != 8))

            {
                e.Handled = true;
            }
        }

        private void Table_Croll_Bar_Scroll(object sender, ScrollEventArgs e)
        {
            try
            {
                Table_Croll_Bar.Maximum = Bills_Table.Rows.Count - 1;

                Bills_Table.FirstDisplayedScrollingRowIndex = Bills_Table.Rows[e.NewValue].Index;
            }
            catch { }

        }

        private void Best_Seller_Table_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                Table_Croll_Bar.Maximum = Bills_Table.Rows.Count - 1;
            }
            catch { }
        }

        private void Best_Seller_Table_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            try
            {
                Table_Croll_Bar.Maximum = Bills_Table.Rows.Count - 1;
            }
            catch { }
        }

        private void Total_Search_Text_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && e.KeyChar != 8))

            {
                e.Handled = true;
            }
        }

        private void Total_Search_Text_Box_TextChanged(object sender, EventArgs e)
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

        private void Bills_Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = Bills_Table.Rows[e.RowIndex];
                if (Bills_Table.Columns[e.ColumnIndex].Name == "Print")
                {
                    Print_Form.Print_Form Form = new Print_Form.Print_Form((int)row.Cells[0].Value);
                    Form.Show();
                }
                else if (Bills_Table.Columns[e.ColumnIndex].Name == "Delete")
                {
                    Formatter.Check_Connection(conn);
                    SqlCommand Delete = new SqlCommand($"DELETE CR.Bills_Details Where Serial_No={(int)row.Cells[0].Value};\nDELETE CR.Bills WHERE Serial_Number={(int)row.Cells[0].Value};", conn);
                    conn.Open();
                    Delete.ExecuteNonQuery();

                    conn.Close();
                    Choose_Query();
                    MessageBox.Show("Successfully Done!");
                }
            }
            catch { }


        }

        private void From_Time_Picker_ValueChanged(object sender, EventArgs e)
        {
            Choose_Query();
        }

        private void To_Time_Picker_ValueChanged(object sender, EventArgs e)
        {
            Choose_Query();
        }

        private void Edit_Buttton_Click(object sender, EventArgs e)
        {
            Excel.Application app = new Excel.Application();
            Excel.Workbook Work_Book = app.Workbooks.Add();
            Excel.Worksheet Work_Sheet = null;
            app.Visible = true;
            Work_Sheet = Work_Book.Sheets["Sheet1"];
            Work_Sheet = Work_Book.ActiveSheet;

            for (int i = 0; i < Bills_Table.ColumnCount; i++)
            {
                Work_Sheet.Cells[1, i + 1] = Bills_Table.Columns[i].HeaderText;
            }


            for (int j = 0; j < Bills_Table.Rows.Count; j++)
            {
                for (int i = 0; i < Bills_Table.Columns.Count; i++)
                {
                    Work_Sheet.Cells[j + 2, i + 1] = Bills_Table.Rows[j].Cells[i].Value.ToString();
                }

            }
            Work_Sheet.Columns.AutoFit();
        }


    }
}