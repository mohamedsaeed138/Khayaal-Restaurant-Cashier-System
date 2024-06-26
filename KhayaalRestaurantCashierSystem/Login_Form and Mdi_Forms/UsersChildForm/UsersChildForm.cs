﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace Khayaal.Login_Form_and_Mdi_Forms.Users_Child_Form
{
    public partial class UsersChildForm : Form
    {
        static SqlConnection conn = new SqlConnection(ConnectionString.Value);



        public UsersChildForm()
        {
            InitializeComponent();
            Reload();

        }
        public void Reload()
        {
            Fill_Table("SELECT * FROM CR.Users Where Type!=N'Developer مطور' Order By Type desc,Name ASC;");
            Jop_Combo_Box.SelectedIndex = 0;
        }

        void Fill_Table(string Query)
        {
            Formatter.CheckConnection(conn);

            SqlDataAdapter da = new SqlDataAdapter(Query, conn);
            DataTable dt = new DataTable();
            conn.Open();
            try
            {
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Query);
                MessageBox.Show(ex.Message);

                conn.Close();
            }
            conn.Close();
            Users_Table.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {

                Users_Table.Rows.Add((int)row[0], (string)row[3], (string)row[2], (string)row[1]);
            }
            try
            {
                Table_Croll_Bar.Maximum = Users_Table.Rows.Count - 1;
            }
            catch { }
            Count_Value_Label.Text = $"{Users_Table.Rows.Count}";
        }
        void Choose_Query()
        {

            string Jop = Jop_Combo_Box.Text;
            if (Jop == "All الجميع")
                Fill_Table("SELECT * FROM CR.Users Where Type!=N'Developer مطور' Order By Type desc,Name ASC;");
            else
                Fill_Table($"SELECT * FROM CR.Users Where Type=N'{Jop}'  Order By Type desc,Name ASC;");

        }






        private void From_Date_Picker_ValueChanged(object sender, EventArgs e)
        {
            Choose_Query();
        }

        private void To_Date_Picker_ValueChanged(object sender, EventArgs e)
        {
            Choose_Query();
        }



        private void Table_Croll_Bar_Scroll(object sender, ScrollEventArgs e)
        {
            try
            {
                Table_Croll_Bar.Maximum = Users_Table.Rows.Count - 1;

                Users_Table.FirstDisplayedScrollingRowIndex = Users_Table.Rows[e.NewValue].Index;
            }
            catch { }

        }

        private void Best_Seller_Table_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                Table_Croll_Bar.Maximum = Users_Table.Rows.Count - 1;
            }
            catch { }
        }

        private void Best_Seller_Table_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            try
            {
                Table_Croll_Bar.Maximum = Users_Table.Rows.Count - 1;
            }
            catch { }
        }










        private void Raw_Material_Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = Users_Table.Rows[e.RowIndex];
                int id = (int)row.Cells[0].Value;
                string name = (string)row.Cells[1].Value;
                string jop = (string)row.Cells[2].Value;
                string password = (string)row.Cells[3].Value;
                if (Users_Table.Columns[e.ColumnIndex].Index == 4)
                {
                    AddEditUserMdiForm form = new AddEditUserMdiForm(id, jop, name, password);
                    form.MdiParent = this.Owner;
                    form.Referesh_Current_Form += (obj, ef) =>
                    {
                        this.Reload();
                    };
                    form.ShowDialog();
                }
                else if (Users_Table.Columns[e.ColumnIndex].Index == 5)
                {
                    try
                    {
                        string Query = $"DELETE CR.Users WHERE Id={id};";
                        Formatter.CheckConnection(conn);
                        SqlCommand Delete = new SqlCommand(Query, conn);
                        conn.Open();
                        Delete.ExecuteNonQuery();
                        conn.Close();
                        Choose_Query();
                        MessageBox.Show("Successfully Done! !تم بنجاح  ");
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
            }
            catch { }
        }

        private void Export_Excel_Click(object sender, EventArgs e)
        {
            Excel.Application app = new Excel.Application();
            Excel.Workbook Work_Book = app.Workbooks.Add();
            Excel.Worksheet Work_Sheet = null;
            app.Visible = true;
            Work_Sheet = Work_Book.Sheets["Sheet1"];
            Work_Sheet = Work_Book.ActiveSheet;

            for (int i = 0; i < Users_Table.ColumnCount; i++)
            {
                Work_Sheet.Cells[1, i + 1] = Users_Table.Columns[i].HeaderText;
            }


            for (int j = 0; j < Users_Table.Rows.Count; j++)
            {
                for (int i = 0; i < Users_Table.Columns.Count; i++)
                {
                    Work_Sheet.Cells[j + 2, i + 1] = Users_Table.Rows[j].Cells[i].Value.ToString();
                }

            }
            Work_Sheet.Columns.AutoFit();


        }

        private void Edit_Buttton_Click(object sender, EventArgs e)
        {
            try
            {
                Excel.Application app = new Excel.Application();
                Excel.Workbook Work_Book = app.Workbooks.Add();
                Excel.Worksheet Work_Sheet = null;
                app.Visible = true;
                Work_Sheet = Work_Book.Sheets["Sheet1"];
                Work_Sheet = Work_Book.ActiveSheet;

                for (int i = 0; i < Users_Table.ColumnCount - 2; i++)
                {

                    Work_Sheet.Cells[1, i + 1] = Users_Table.Columns[i].HeaderText;




                }


                for (int j = 0; j < Users_Table.Rows.Count; j++)
                {
                    for (int i = 0; i < Users_Table.Columns.Count - 2; i++)
                    {

                        Work_Sheet.Cells[j + 2, i + 1] = Users_Table.Rows[j].Cells[i].Value.ToString();

                    }

                }
                Work_Sheet.Columns.AutoFit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void Btn_Maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void Add_Button_Click_1(object sender, EventArgs e)
        {
            AddEditUserMdiForm form = new AddEditUserMdiForm();
            form.MdiParent = this.Owner;
            form.Referesh_Current_Form += (obj, ef) =>
            {
                this.Reload();
            };
            form.ShowDialog();
        }

        private void Jop_Combo_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            Choose_Query();
        }
    }
}
