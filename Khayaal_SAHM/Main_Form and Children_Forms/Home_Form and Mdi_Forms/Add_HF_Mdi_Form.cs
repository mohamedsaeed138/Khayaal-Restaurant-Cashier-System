using Khayaal_SAHM.Properties;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Khayaal_SAHM.Main_Form_and_Children_Forms.Home_Form_and_Mdi_Forms
{
    public partial class Add_HF_Mdi_Form : Form
    {
        public event EventHandler Referesh_Current_Form = null;
        private DataTable dt = Select_Category_AS_Data_Table();
        private int Receivede_Item_Id;
        static SqlConnection conn = new SqlConnection(Connection_String.Value);
        public Add_HF_Mdi_Form(int id, string category, string name, string description, float unite_price)
        {
            InitializeComponent();
            Receivede_Item_Id = id;
            Name_Text_Box.Text = name;
            Unit_Price_Text_Box.Text = $"{unite_price}";
            Fill_ComboBox(category);
            Description_Text_Box.Text = description;
        }
        public Add_HF_Mdi_Form()
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
            || (e.KeyChar == '.' && Unit_Price_Text_Box.Text.Contains(".")))
            {
                e.Handled = true;
            }
        }





        private void Item_Description_Text_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ' ' || (Description_Text_Box.Text.Length >= 200 && e.KeyChar != 8))
            || (Description_Text_Box.Text.Length > 1 && Description_Text_Box.Text[Description_Text_Box.Text.Length - 1] == ' ' && e.KeyChar == ' ') || (e.KeyChar == ' ' && Description_Text_Box.Text.Length == 0))

            {
                e.Handled = true;
            }
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
        private void Item_Name_Text_Box_KeyPress(object sender, KeyPressEventArgs e)
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
            string sql = "select Category from CR.Items GROUP BY Category";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;

        }



        private void Image_Picture_Image_Click(object sender, EventArgs e)
        {
            OpenFileDialog File_Dialog = new OpenFileDialog();
            PictureBox p = sender as PictureBox;
            File_Dialog.Title = "Choose Image.";
            File_Dialog.InitialDirectory = Environment.CurrentDirectory;

            if (p != null)
            {
                File_Dialog.Filter = "(*.jpg;*.jpeg;*.png;*.bmp;*.jfif;)| *.jpg;*.jpeg;*.png;*.bmp;*.jfif";
                if (File_Dialog.ShowDialog() == DialogResult.OK)
                {
                    p.Image = Image.FromFile(File_Dialog.FileName);
                }
            }
        }
        public byte[] ImageToByteArray(System.Drawing.Image image)
        {
            MemoryStream ms = new MemoryStream();
            image.Save(ms, image.RawFormat);
            return ms.ToArray();
        }
        private void Add_Item_Button_Click(object sender, EventArgs e)
        {
            //command.CommandText = "INSERT INTO table VALUES (@VALUE)";
            //command.Parameters.Add(new VerticaParameter("VALUE", VerticaType.Binary));
            //command.Parameters["VALUE"].Value = bytes;
            if (Name_Text_Box.Text != "" && Unit_Price_Text_Box.Text != "" && Description_Text_Box.Text != "")
            {
                string Name = Formatter.String(Name_Text_Box.Text);
                string Category = Formatter.String(Category_Combo_Box.Text);
                string Price = Formatter.Float(Unit_Price_Text_Box.Text);
                string Description = Formatter.String(Description_Text_Box.Text);
                Image Image = Image_Picture_Box.Image;

                Formatter.Check_Connection(conn);
                if (Image_Picture_Box.Image == null)
                    Image = Resources.Food_Drink_Template;
                string Query = $"INSERT INTO CR.Items([Name],Category,Unit_Price,[Description])\r\nVALUES(N'{Name}',N'{Category}',{Price},N'{Description}') ;";
                SqlCommand Insert_Query = new SqlCommand(Query, conn);
                try
                {
                    SqlCommand Insert_Image = new SqlCommand($"Update CR.Items SET Image = @Image WHERE Name =N'{Name}';", conn);
                    Insert_Image.CommandType = CommandType.Text;
                    Insert_Image.Parameters.AddWithValue("@Image", ImageToByteArray(Image));


                    Formatter.Check_Connection(conn);
                    conn.Open();

                    Insert_Query.ExecuteNonQuery();
                    Insert_Image.ExecuteNonQuery();
                    conn.Close();
                    this.Close();

                    MessageBox.Show("Successfully Done");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                finally
                {
                    conn.Close();
                }

            }
            else
            {
                MessageBox.Show("Fill Empty Fields");
            }
        }

        private void Add_HF_Mdi_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referesh_Current_Form?.Invoke(this, e);
        }
    }
}