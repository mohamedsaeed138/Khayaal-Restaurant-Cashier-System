using Khayaal_SAHM.Properties;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Khayaal_SAHM.Main_Form_and_Children_Forms_AR.Home_Form_and_Mdi_Forms_AR
{
    public partial class Add_Edit_HF_Mdi_Form_AR : Form
    {
        int id;
        bool Add = true;
        public event EventHandler Referesh_Current_Form = null;
        private DataTable dt = Select_Category_AS_Data_Table();

        static SqlConnection conn = new SqlConnection(Connection_String.Value);

        public Add_Edit_HF_Mdi_Form_AR()
        {
            Reload();
        }
        public Add_Edit_HF_Mdi_Form_AR(string name, string price, string description, string category, Image image, int id)
        {
            Add = false;
            Reload();
            this.id = id;
            Name_Text_Box.Text = name;
            Unit_Price_Text_Box.Text = $"{price}";
            Description_Text_Box.Text = description;
            Category_Combo_Box.Text = category;
            Image_Picture_Box.Image = image;
            Add_Item_Button.Text = "تعديل";
        }

        void Reload()
        {
            this.Controls.Clear();
            InitializeComponent();
            Fill_ComboBox();
        }



        private void Unite_Price_Text_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != 8)
            || (e.KeyChar == '.' && Unit_Price_Text_Box.Text.Contains(".")) || (Unit_Price_Text_Box.Text.Length >= 9 && e.KeyChar != 8))
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

                    MessageBox.Show("!! هذا القسم موجود بالفعل", "معلومة", MessageBoxButtons.OK);
                    Add_Category_Text_Box.Text = string.Empty;
                }
            }
            else
                MessageBox.Show("!! أضف قسم جديد أولا", "خطأ", MessageBoxButtons.OK);
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
        private void Item_Description_Text_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '"' || e.KeyChar == '=' || e.KeyChar == '\'' || e.KeyChar == ';') || (Description_Text_Box.Text.Length >= 200 && e.KeyChar != 8)
         || (e.KeyChar == ' ' && Description_Text_Box.Text.Length == 0))

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
            File_Dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);

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

            if (Name_Text_Box.Text != "" && Unit_Price_Text_Box.Text != "")
            {
                string Name = Formatter.String(Name_Text_Box.Text);
                string Category = Formatter.String(Category_Combo_Box.Text);
                string Price = Formatter.Float(Unit_Price_Text_Box.Text);
                string Description = Formatter.String(Description_Text_Box.Text);
                Image Image = Image_Picture_Box.Image;
                if (Image_Picture_Box.Image == null)
                    Image = Resources.Food_Drink_Template;
                Formatter.Check_Connection(conn);
                if (Add)
                {




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
                        Name_Text_Box.Text = "";
                        Unit_Price_Text_Box.Text = "";
                        Description_Text_Box.Text = "";

                        Image_Picture_Box.Image = null;

                        MessageBox.Show("!! تمت بنجاح");
                    }

                    catch
                    {
                        MessageBox.Show("!! يوجد عنصر بنفس الاسم بالفعل");

                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                else
                {

                    string Query = $"Update CR.Items SET Category = N'{Category}',Name=N'{Name}',Unit_Price={Price},Description=N'{Description}' WHERE Id ={id};\nUpdate CR.Bills_Details SET Name=N'{Name}' ,Category=N'{Category}' Where Item_Id={id};";
                    SqlCommand Update_Query = new SqlCommand(Query, conn);
                    try
                    {
                        SqlCommand Update_Image = new SqlCommand($"Update CR.Items SET Image = @Image WHERE Id ={id};", conn);
                        Update_Image.CommandType = CommandType.Text;
                        Update_Image.Parameters.AddWithValue("@Image", ImageToByteArray(Image));


                        Formatter.Check_Connection(conn);
                        conn.Open();

                        Update_Query.ExecuteNonQuery();
                        Update_Image.ExecuteNonQuery();
                        conn.Close();
                        this.Close();

                        MessageBox.Show("!! تمت بنجاح");
                    }

                    catch
                    {
                        MessageBox.Show("!! يوجد عنصر بنفس الاسم بالفعل");

                    }
                    finally
                    {
                        conn.Close();
                    }
                }

            }
            else
            {
                MessageBox.Show("!! تأكد من تعبئة الاسم والسعر");
            }
        }

        private void Add_HF_Mdi_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referesh_Current_Form?.Invoke(this, e);
        }


    }
}