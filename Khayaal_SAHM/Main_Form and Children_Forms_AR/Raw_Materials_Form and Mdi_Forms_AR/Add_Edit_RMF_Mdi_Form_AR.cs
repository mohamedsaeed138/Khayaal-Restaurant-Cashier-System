using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Khayaal_SAHM.Main_Form_and_Children_Forms_AR.Raw_Materials_Form_and_Mdi_Forms_AR
{
    public partial class Add_Edit_RMF_Mdi_Form_AR : Form
    {
        int id;
        bool Add = true;
        public event EventHandler Referesh_Current_Form = null;
        private DataTable dt = Select_Category_AS_Data_Table();

        static SqlConnection conn = new SqlConnection(Connection_String.Value);

        public Add_Edit_RMF_Mdi_Form_AR()
        {
            Reload();
        }
        public Add_Edit_RMF_Mdi_Form_AR(string name, string category, int id)
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
                string Category = Formatter.String(Add_Category_Text_Box.Text);
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
        private void Raw_Name_Text_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ' ' || (Name_Text_Box.Text.Length >= 50 && e.KeyChar != 8))
           || (Name_Text_Box.Text.Length > 1 && Name_Text_Box.Text[Name_Text_Box.Text.Length - 1] == ' ' && e.KeyChar == ' ') || (e.KeyChar == ' ' && Name_Text_Box.Text.Length == 0))

            {
                e.Handled = true;
            }
        }

        private void Add_Category_Text_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ' ' || (Add_Category_Text_Box.Text.Length >= 50 && e.KeyChar != 8))
              || (Add_Category_Text_Box.Text.Length > 1 && Add_Category_Text_Box.Text[Add_Category_Text_Box.Text.Length - 1] == ' ' && e.KeyChar == ' ') || (e.KeyChar == ' ' && Add_Category_Text_Box.Text.Length == 0))

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

            if (Name_Text_Box.Text != "")
            {
                string Name = Formatter.String(Name_Text_Box.Text);
                string Category = Formatter.String(Category_Combo_Box.Text);

                Formatter.Check_Connection(conn);
                if (Add)
                {




                    string Query = $"INSERT INTO CR.Raw_Materials ([Name],Category,Qty)\r\nVALUES(N'{Name}',N'{Category}',0) ;";
                    SqlCommand Insert_Query = new SqlCommand(Query, conn);
                    try
                    {

                        Formatter.Check_Connection(conn);
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

                    string Query = $"Update CR.Raw_Materials SET Category = N'{Category}',Name=N'{Name}'  WHERE Id ={id};";
                    SqlCommand Update_Query = new SqlCommand(Query, conn);
                    try
                    {


                        Formatter.Check_Connection(conn);
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

        private void Name_Text_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ' ' || (Name_Text_Box.Text.Length >= 50 && e.KeyChar != 8))
          || (Name_Text_Box.Text.Length > 1 && Name_Text_Box.Text[Name_Text_Box.Text.Length - 1] == ' ' && e.KeyChar == ' ') || (e.KeyChar == ' ' && Name_Text_Box.Text.Length == 0))

            {
                e.Handled = true;
            }
        }
    }
}