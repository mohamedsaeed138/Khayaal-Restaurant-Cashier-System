using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Khayaal_SAHM.Main_Form_and_Children_Forms.Relations_Form_and_Mdi_Forms
{
    public partial class Add_Edit_RS_Mdi_Form : Form
    {
        int id;
        bool Add = true;
        public event EventHandler Referesh_Current_Form = null;




        static SqlConnection conn = new SqlConnection(Connection_String.Value);

        public Add_Edit_RS_Mdi_Form()
        {
            Reload();
        }
        public Add_Edit_RS_Mdi_Form(string item, string raw, string qty, int id)
        {
            Add = false;
            Reload();
            this.id = id;
            Item_Combo_Box.Text = item;
            Raw_Combo_Box.Text = raw;
            Qty_Text_Box.Text = qty;
            Add_Relation_Button.Text = "Edit";
        }

        void Reload()
        {


            this.Controls.Clear();
            InitializeComponent();
            Fill_Item_Combo_Box();
            Fill_Raw_Combo_Box();
        }

        private void Fill_Raw_Combo_Box()
        {
            Formatter.Check_Connection(conn);
            conn.Open();
            string sql = "SELECT [Name] FROM CR.Raw_Materials ORDER BY [Name]";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            Raw_Combo_Box.DataSource = dt;
            Raw_Combo_Box.DisplayMember = "Name";

        }
        private void Fill_Item_Combo_Box()
        {
            Formatter.Check_Connection(conn);
            conn.Open();
            string sql = "SELECT [Name] FROM CR.Items ORDER BY [Name]";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            Item_Combo_Box.DataSource = dt;
            Item_Combo_Box.DisplayMember = "Name";

        }











        private void Add_PS_Mdi_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referesh_Current_Form?.Invoke(this, e);
        }





        private void Qty_Text_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != 8) || (e.KeyChar == '.' && Qty_Text_Box.Text.Contains(".")) || (Qty_Text_Box.Text.Length >= 9 && e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void Add_Relation_Button_Click(object sender, EventArgs e)
        {
            if (Qty_Text_Box.Text != "")
            {
                string item = Formatter.Special_Formatting(Item_Combo_Box.Text);
                string raw = Formatter.Special_Formatting(Raw_Combo_Box.Text);
                string qty = Formatter.Float(Qty_Text_Box.Text);
                Formatter.Check_Connection(conn);
                if (Add)
                {




                    string Query = $"INSERT INTO CR.Items_Relations VALUES(CR.Get_Item_Id(N'{item}'),CR.Get_Raw_Mat_Id(N'{raw}'),{qty});";
                    SqlCommand Insert_Query = new SqlCommand(Query, conn);
                    try
                    {

                        Formatter.Check_Connection(conn);
                        conn.Open();

                        Insert_Query.ExecuteNonQuery();

                        conn.Close();
                        Qty_Text_Box.Text = "";
                        MessageBox.Show("Successfully Done");
                    }

                    catch
                    {
                        MessageBox.Show("There Relation is Already Existed");

                    }
                    finally
                    {
                        conn.Close();
                    }

                }
                else
                {

                    string Query = $"UPDATE CR.Items_Relations SET Item_Id = CR.Get_Item_Id(N'{item}') ,Raw_Id= CR.Get_Raw_Mat_Id(N'{raw}'),Qty_Needed={qty}  WHERE Id ={id};";
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
                        MessageBox.Show("There Relation is Already Existed");

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
    }
}