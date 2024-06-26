﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Khayaal.Main_Form_and_Children_Forms.Raw_Materials_Form_and_Mdi_Forms
{
    public partial class Add_Edit_RMF_Mdi_Form : Form
    {
        int id;
        bool Add = true;
        public event EventHandler Referesh_Current_Form = null;
        private DataTable dt = Select_Category_AS_Data_Table();

        static SqlConnection conn = new SqlConnection(ConnectionString.Value);

        public Add_Edit_RMF_Mdi_Form()
        {
            Reload();
        }
        public Add_Edit_RMF_Mdi_Form(string name, string category, int id)
        {
            Add = false;
            Reload();
            this.id = id;
            Name_Text_Box.Text = name;

            Category_Combo_Box.Text = category;

            Add_Raw_Button.Text = "Edit";
        }

        void Reload()
        {
            this.Controls.Clear();
            InitializeComponent();
            Fill_ComboBox();
        }

        private void Fill_ComboBox(string Category = null)
        {

            if (Category != null && dt != null)
                dt.Rows.Add(Category);
            Category_Combo_Box.DataSource = dt;
            Category_Combo_Box.DisplayMember = "Category";
            if (Category != null)
            {

                Category_Combo_Box.Text = Category;

                Add_Category_Text_Box.Text = string.Empty;
            }

        }

        private void Add_Category_Button_Click(object sender, EventArgs e)
        {
            if (Add_Category_Text_Box.Text != String.Empty)
            {
                string Category = Formatter.SpecialFormatting(Add_Category_Text_Box.Text);
                if (Ensure_No_Duplicated_Categories(Category))
                    Fill_ComboBox(Category);
                else
                {

                    MessageBox.Show("The Category is Already Existed", "Information", MessageBoxButtons.OK);
                    Add_Category_Text_Box.Text = string.Empty;
                }
            }
            else
                MessageBox.Show("Enter a New Category Name", "Error", MessageBoxButtons.OK);
        }
        private bool Ensure_No_Duplicated_Categories(string New_Category)
        {
            bool existed = true;


            foreach (DataRow row in dt.Rows)
            {
                if (Convert.ToString(row[0]) == New_Category)
                {
                    existed = false;
                    Category_Combo_Box.Text = New_Category;
                    break;
                }

            }
            return existed;

        }

        private void Name_Text_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '"' || e.KeyChar == '=' || e.KeyChar == '\'' || e.KeyChar == ';') || (Name_Text_Box.Text.Length >= 50 && e.KeyChar != 8)
          || (e.KeyChar == ' ' && Name_Text_Box.Text.Length == 0))

            {
                e.Handled = true;
            }
        }
        private void Add_Category_Text_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '"' || e.KeyChar == '=' || e.KeyChar == '\'' || e.KeyChar == ';') || (Add_Category_Text_Box.Text.Length >= 50 && e.KeyChar != 8)
         || (e.KeyChar == ' ' && Add_Category_Text_Box.Text.Length == 0))

            {
                e.Handled = true;
            }
        }
        private static DataTable Select_Category_AS_Data_Table()
        {
            conn.Open();
            string sql = "select Category from CR.Raw_Materials GROUP BY Category ORDER BY Category";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;

        }





        private void Add_RMF_Mdi_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referesh_Current_Form?.Invoke(this, e);
        }

        private void Add_Raw_Button_Click_1(object sender, EventArgs e)
        {

            if (Name_Text_Box.Text.Trim() != "")
            {
                string Name = Formatter.SpecialFormatting(Name_Text_Box.Text);
                string Category = Formatter.SpecialFormatting(Category_Combo_Box.Text);

                Formatter.CheckConnection(conn);
                if (Add)
                {




                    string Query = $"INSERT INTO CR.Raw_Materials ([Name],Category,Qty)\r\nVALUES(N'{Name}',N'{Category}',0) ;";
                    SqlCommand Insert_Query = new SqlCommand(Query, conn);
                    try
                    {

                        Formatter.CheckConnection(conn);
                        conn.Open();

                        Insert_Query.ExecuteNonQuery();

                        conn.Close();
                        Name_Text_Box.Text = "";
                        MessageBox.Show("Successfully Done");
                    }

                    catch
                    {
                        MessageBox.Show("There is a Raw Material With Same Name");

                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                else
                {

                    string Query = $"Update CR.Raw_Materials SET Category = N'{Category}',Name=N'{Name}'  WHERE Id ={id};\nUpdate CR.Purchases set Name=N'{Name}',Category=N'{Category}' WHERE Raw_Id= {id};";
                    SqlCommand Update_Query = new SqlCommand(Query, conn);
                    try
                    {


                        Formatter.CheckConnection(conn);
                        conn.Open();

                        Update_Query.ExecuteNonQuery();

                        conn.Close();
                        this.Close();
                        MessageBox.Show("Successfully Done");
                    }

                    catch
                    {
                        MessageBox.Show("There is a Raw Material With Same Name");

                    }
                    finally
                    {
                        conn.Close();
                    }
                }

            }
            else
            {
                MessageBox.Show("Fill Empty Fields");
            }
        }

        private void Add_Edit_RMF_Mdi_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referesh_Current_Form?.Invoke(this, e);
        }


    }
}