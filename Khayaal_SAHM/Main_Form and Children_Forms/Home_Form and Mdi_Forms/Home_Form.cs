using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
namespace Khayaal_SAHM.Main_Form_and_Children_Forms.Home_Form_and_Mdi_Forms
{
    public partial class Home_Form : Form
    {
        static System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(Connection_String.Value); public EventHandler On_Select = null;
        public Home_Form()
        {
            Reload();
        }
        void Reload()
        {
            this.Controls.Clear();
            InitializeComponent();

            Fill_Item_Panel();
            Fill_Combo_Box();

        }
        public void Fill_Items_Nested_Flow_Layout_Panel()
        {
            foreach (Control c in Items_Nested_Flow_Layout_Panel.Controls.OfType<Button>()) { }
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



        private void Search_Text_Box_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ' ' || (Search_Text_Box.Text.Length >= 50 && e.KeyChar != 8))
           || (Search_Text_Box.Text.Length > 1 && Search_Text_Box.Text[Search_Text_Box.Text.Length - 1] == ' ' && e.KeyChar == ' ') || (e.KeyChar == ' ' && Search_Text_Box.Text.Length == 0))

            {
                e.Handled = true;
            }
        }

        public void Fill_Item_Panel()
        {
            Formatter.Check_Connection(conn);

            SqlDataAdapter da = new SqlDataAdapter("SELECT Id,[Name],Category,Unit_Price,[Image],[Description],Available FROM CR.Items;", conn);
            DataTable dt = new DataTable();
            conn.Open();
            try
            {
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
            conn.Close();
            Items_Nested_Flow_Layout_Panel.Controls.Clear();
            foreach (DataRow row in dt.Rows)
            {
                Item_User_Control Item = new Item_User_Control();
                Item.Id = (int)row[0];
                Item.Name = (string)row[1];
                Item.Category = (string)row[2];
                Item.Price = (double)row[3];
                Item.Image = Image.FromStream(new MemoryStream((byte[])row[4]));
                Item.Description = (string)row[5];
                Item.Available = (bool)row[6];

                Items_Nested_Flow_Layout_Panel.Controls.Add(Item);
                Item.Remove_Event += (obj, e) =>
                {
                    if (Order_Nested_Flow_Layout_Panel.Controls.Count == 0)
                    {
                        Formatter.Check_Connection(conn);


                        SqlCommand Delete = new SqlCommand($"DELETE CR.Items_Relations WHERE Item_Id={((Item_User_Control)obj).Id};\nDELETE CR.Items Where Id ={((Item_User_Control)obj).Id};   ", conn);
                        conn.Open();
                        Delete.ExecuteNonQuery();
                        conn.Close();
                        ((Item_User_Control)obj).Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Finish Your Bill First!!");
                    }

                };
            }
        }




    }
}

