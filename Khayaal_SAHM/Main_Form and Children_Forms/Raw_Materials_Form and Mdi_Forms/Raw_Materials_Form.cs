using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace Khayaal_SAHM.Main_Form_and_Children_Forms.Raw_Materials_Form_and_Mdi_Forms
{
    public partial class Raw_Materials_Form : Form
    {
        static SqlConnection conn = new SqlConnection(Connection_String.Value);


        private void Search_Text_Box_TextChanged(object sender, EventArgs e)
        {

            Choose_Query();
        }

        public Raw_Materials_Form()
        {
            InitializeComponent();
            Reload();
        }
        void Reload()
        {
            Sorting_Combo_Box.SelectedIndex = 0;
            Fill_Category_Combo_Box();
            Fill_Table($"SELECT [Name] ,[Category] ,[Qty] ,[Id] from CR.Raw_Materials ORDER BY [Name]");

        }


        public void Fill_Category_Combo_Box()
        {
            Category_Combo_Box.DataSource = null;
            Formatter.Check_Connection(conn);
            SqlDataAdapter da2 = new SqlDataAdapter($"SELECT [Category] FROM CR.Raw_Materials Group BY [Category] ORDER BY [Category] ASC;", conn);
            DataTable dt2 = new DataTable();
            conn.Open();
            da2.Fill(dt2);
            conn.Close();
            DataRow row2 = dt2.NewRow();
            dt2.Rows.InsertAt(row2, 0);
            row2["Category"] = "All";
            Category_Combo_Box.DataSource = dt2;
            Category_Combo_Box.DisplayMember = "Category";
            Category_Combo_Box.Text = "All";
        }


        void Fill_Table(string Query)
        {
            Formatter.Check_Connection(conn);

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
            Raw_Material_Table.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {

                Raw_Material_Table.Rows.Add((string)row[0], (string)row[1], (double)row[2], (int)row[3]);
            }
            try
            {
                Table_Croll_Bar.Maximum = Raw_Material_Table.Rows.Count - 1;
            }
            catch { }
            Count_Value_Label.Text = $"{Raw_Material_Table.Rows.Count}";
        }
        void Choose_Query()
        {
            string Qty = Formatter.String(Qty_Search_Text_Box.Text);
            string Category = Category_Combo_Box.Text;
            string Search = Formatter.String(Search_Text_Box.Text);
            if (Search_Text_Box.Text == "" && Category_Combo_Box.Text == "All" && Qty == "" && Sorting_Combo_Box.Text == "Name")
                Fill_Table($"select [Name] , [Category],[Qty] ,[Id] from CR.Raw_Materials ORDER BY [Name]");
            else if (Search_Text_Box.Text == "" && Category_Combo_Box.Text == "All" && Qty == "" && Sorting_Combo_Box.Text != "Name")
                Fill_Table($"select [Name] ,[Category] ,[Qty] ,[Id] from CR.Raw_Materials ORDER BY [{Sorting_Combo_Box.Text}]");
            else if (Search_Text_Box.Text == "" && Category_Combo_Box.Text == "All" && Qty != "" && Sorting_Combo_Box.Text == "Name")
                Fill_Table($"select [Name] , [Category] ,[Qty] ,[Id] from CR.Raw_Materials WHERE [Qty] <= {Qty} ORDER BY Name ASC;");
            else if (Search_Text_Box.Text == "" && Category_Combo_Box.Text == "All" && Qty != "" && Sorting_Combo_Box.Text != "Name")
                Fill_Table($"select [Name] ,[Category]  ,[Qty] ,[Id] from CR.Raw_Materials  WHERE [Qty] <= {Qty}  ORDER BY [{Sorting_Combo_Box.Text}]");
            else if (Search_Text_Box.Text == "" && Category_Combo_Box.Text != "All" && Qty == "" && Sorting_Combo_Box.Text == "Name")
                Fill_Table($"select [Name] , [Category]  , [Qty] ,[Id] from CR.Raw_Materials WHERE [Category]=N'{Category}' ORDER BY [Name] ASC");
            else if (Search_Text_Box.Text == "" && Category_Combo_Box.Text != "All" && Qty == "" && Sorting_Combo_Box.Text != "Name")
                Fill_Table($"select [Name] , [Category] , [Qty]  ,[Id] from CR.Raw_Materials WHERE [Category]=N'{Category}' ORDER BY [{Sorting_Combo_Box.Text}]");
            else if (Search_Text_Box.Text == "" && Category_Combo_Box.Text != "All" && Qty != "" && Sorting_Combo_Box.Text == "Name")
                Fill_Table($"select [Name] , [Category] , [Qty]  ,[Id] from CR.Raw_Materials  WHERE   [Category]=N'{Category}' AND [Qty] <= {Qty} ORDER BY [Name] ASC");
            else if (Search_Text_Box.Text == "" && Category_Combo_Box.Text != "All" && Qty != "" && Sorting_Combo_Box.Text != "Name")
                Fill_Table($"select [Name]  , [Category] ,[Qty]  ,[Id] from CR.Raw_Materials  WHERE [Qty] <= {Qty}  AND [Category]=N'{Category}' ORDER BY [{Sorting_Combo_Box.Text}]");
            else if (Search_Text_Box.Text != "" && Category_Combo_Box.Text == "All" && Qty == "" && Sorting_Combo_Box.Text == "Name")
                Fill_Table($"select [Name] , [Category] ,[Qty]  ,[Id] from CR.Raw_Materials WHERE  [Name] LIKE N'%{Search}%'  ORDER BY [Name] ASC ");
            else if (Search_Text_Box.Text != "" && Category_Combo_Box.Text == "All" && Qty == "" && Sorting_Combo_Box.Text != "Name")
                Fill_Table($"select [Name] , [Category] , [Qty] ,[Id] from CR.Raw_Materials WHERE  [Name] LIKE N'%{Search}%' ORDER BY [{Sorting_Combo_Box.Text}]");
            else if (Search_Text_Box.Text != "" && Category_Combo_Box.Text == "All" && Qty != "" && Sorting_Combo_Box.Text == "Name")
                Fill_Table($"select [Name] , [Category] ,[Qty] ,[Id] from CR.Raw_Materials  WHERE [Qty] <= {Qty} AND [Name] LIKE N'%{Search}%' ORDER BY [Name] ASC");
            else if (Search_Text_Box.Text != "" && Category_Combo_Box.Text == "All" && Qty != "" && Sorting_Combo_Box.Text != "Name")
                Fill_Table($"select [Name] ,[Category] ,[Qty] ,[Id] from CR.Raw_Materials  WHERE [Qty] <= {Qty} AND [Name] LIKE N'%{Search}%' ORDER BY [{Sorting_Combo_Box.Text}]");
            else if (Search_Text_Box.Text != "" && Category_Combo_Box.Text != "All" && Qty == "" && Sorting_Combo_Box.Text == "Name")
                Fill_Table($"select [Name] , [Category] ,[Qty] ,[Id] from CR.Raw_Materials WHERE [Category]=N'{Category}' AND [Name] LIKE N'%{Search}%' ORDER BY [Name] ASC");
            else if (Search_Text_Box.Text != "" && Category_Combo_Box.Text != "All" && Qty == "" && Sorting_Combo_Box.Text != "Name")
                Fill_Table($"select [Name] ,[Category] ,[Qty] ,[Id] from CR.Raw_Materials WHERE [Category]=N'{Category}' AND [Name] LIKE N'%{Search}%' ORDER BY [{Sorting_Combo_Box.Text}]");
            else if (Search_Text_Box.Text != "" && Category_Combo_Box.Text != "All" && Qty != "" && Sorting_Combo_Box.Text == "Name")
                Fill_Table($"select [Name] , [Category] ,[Qty] ,[Id] from CR.Raw_Materials  WHERE [Qty] <= {Qty} AND [Category]=N'{Category}' AND [Name] LIKE N'%{Search}%' ORDER BY [Name] ASC");
            else
                Fill_Table($"select [Name] , [Category] ,[Qty] ,[Id] from CR.Raw_Materials  WHERE [Qty] <= {Qty} AND [Name] LIKE N'%{Search}%'  ORDER BY [{Sorting_Combo_Box.Text}]");

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
                Table_Croll_Bar.Maximum = Raw_Material_Table.Rows.Count - 1;

                Raw_Material_Table.FirstDisplayedScrollingRowIndex = Raw_Material_Table.Rows[e.NewValue].Index;
            }
            catch { }

        }

        private void Best_Seller_Table_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                Table_Croll_Bar.Maximum = Raw_Material_Table.Rows.Count - 1;
            }
            catch { }
        }

        private void Best_Seller_Table_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            try
            {
                Table_Croll_Bar.Maximum = Raw_Material_Table.Rows.Count - 1;
            }
            catch { }
        }





        private void Sorting_Combo_Box_TextChanged(object sender, EventArgs e)
        {
            Choose_Query();
        }

        private void Qty_Search_Text_Box_TextChanged(object sender, EventArgs e)
        {
            Choose_Query();
        }

        private void Qty_Search_Text_Box_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((!char.IsDigit(e.KeyChar) && e.KeyChar != 8))

            {
                e.Handled = true;
            }
        }

        private void Category_Combo_Box_SelectedValueChanged(object sender, EventArgs e)
        {
            Choose_Query();
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            Add_Edit_RMF_Mdi_Form form = new Add_Edit_RMF_Mdi_Form();
            form.MdiParent = this.Owner;
            form.Referesh_Current_Form += (obj, ef) =>
            {
                this.Reload();
            };
            form.ShowDialog();
        }

        private void Raw_Material_Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = Raw_Material_Table.Rows[e.RowIndex];
                string name = (string)row.Cells[0].Value;
                string category = (string)row.Cells[1].Value;
                int id = (int)row.Cells[3].Value;
                if (Raw_Material_Table.Columns[e.ColumnIndex].Name == "Edit")
                {
                    Add_Edit_RMF_Mdi_Form form = new Add_Edit_RMF_Mdi_Form(name, category, id);
                    form.MdiParent = this.Owner;
                    form.Referesh_Current_Form += (obj2, ef) =>
                    {
                        this.Reload();
                    };
                    form.ShowDialog();
                }
                else if (Raw_Material_Table.Columns[e.ColumnIndex].Name == "Delete")
                {
                    try
                    {
                        string Query = $"DELETE CR.Items_Relations WHERE Raw_Id={id};\nDELETE CR.Raw_Materials Where Id={id};";
                        Formatter.Check_Connection(conn);
                        SqlCommand Delete = new SqlCommand(Query, conn);
                        conn.Open();
                        Delete.ExecuteNonQuery();
                        conn.Close();
                        Choose_Query();
                        MessageBox.Show("Successfully Done!");
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

            for (int i = 0; i < Raw_Material_Table.ColumnCount; i++)
            {
                Work_Sheet.Cells[1, i + 1] = Raw_Material_Table.Columns[i].HeaderText;
            }


            for (int j = 0; j < Raw_Material_Table.Rows.Count; j++)
            {
                for (int i = 0; i < Raw_Material_Table.Columns.Count; i++)
                {
                    Work_Sheet.Cells[j + 2, i + 1] = Raw_Material_Table.Rows[j].Cells[i].Value.ToString();
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

                for (int i = 0, k = 0; i < Raw_Material_Table.ColumnCount - 2; i++, k++)
                {
                    if (i == 3)
                    {
                        k--;
                        continue;
                    }
                    Work_Sheet.Cells[1, k + 1] = Raw_Material_Table.Columns[i].HeaderText;




                }


                for (int j = 0; j < Raw_Material_Table.Rows.Count; j++)
                {
                    for (int i = 0, m = 0; i < Raw_Material_Table.Columns.Count - 2; i++, m++)
                    {
                        if (i == 3)
                        {
                            m--;
                            continue;
                        }
                        Work_Sheet.Cells[j + 2, m + 1] = Raw_Material_Table.Rows[j].Cells[i].Value.ToString();

                    }

                }
                Work_Sheet.Columns.AutoFit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
