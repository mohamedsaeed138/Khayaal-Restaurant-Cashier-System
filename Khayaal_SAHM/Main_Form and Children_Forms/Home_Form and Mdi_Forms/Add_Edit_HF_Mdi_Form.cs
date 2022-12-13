using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Khayaal_SAHM.Main_Form_and_Children_Forms.Home_Form_and_Mdi_Forms
{
    public partial class Add_Edit_HF_Mdi_Form : Form
    {
        private DataTable dt = Select_Category_AS_Data_Table();
        private int Receivede_Item_Id;
        static SqlConnection conn = new SqlConnection(Connection_String.Value);
        public Add_Edit_HF_Mdi_Form(int id, string category, string name, string description, float unite_price)
        {
            InitializeComponent();
            Receivede_Item_Id = id;
            Item_Name_Text_Box.Text = name;
            Unite_Price_Text_Box.Text = $"{unite_price}";
            Fill_ComboBox(category);
            Item_Description_Text_Box.Text = description;
        }
        public Add_Edit_HF_Mdi_Form()
        {
            InitializeComponent();
            Fill_ComboBox();
        }


        private void Add_Mdi_Form_load(object sender, EventArgs e)
        {
            Fill_ComboBox();

        }



        private void Unite_Price_Text_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != 8)
            || (e.KeyChar == '.' && Unite_Price_Text_Box.Text.Contains(".")))
            {
                e.Handled = true;
            }
        }





        private void Item_Description_Text_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ' ' || (Item_Description_Text_Box.Text.Length >= 200 && e.KeyChar != 8))
            || (Item_Description_Text_Box.Text.Length > 1 && Item_Description_Text_Box.Text[Item_Description_Text_Box.Text.Length - 1] == ' ' && e.KeyChar == ' ') || (e.KeyChar == ' ' && Item_Description_Text_Box.Text.Length == 0))

            {
                e.Handled = true;
            }
        }
        private void Fill_ComboBox(string Category = null)
        {

            if (Category != null && dt != null)
                dt.Rows.Add(Add_Category_Text_Box.Text);
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
                if (Ensure_No_Duplicated_Categories(Add_Category_Text_Box.Text))
                    Fill_ComboBox(Add_Category_Text_Box.Text);
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
        private void Item_Name_Text_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ' ' || (Item_Name_Text_Box.Text.Length >= 50 && e.KeyChar != 8))
           || (Item_Name_Text_Box.Text.Length > 1 && Item_Name_Text_Box.Text[Item_Name_Text_Box.Text.Length - 1] == ' ' && e.KeyChar == ' ') || (e.KeyChar == ' ' && Item_Name_Text_Box.Text.Length == 0))

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

            string sql = "select Category from CR.Items GROUP BY Category";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }


    }
}
