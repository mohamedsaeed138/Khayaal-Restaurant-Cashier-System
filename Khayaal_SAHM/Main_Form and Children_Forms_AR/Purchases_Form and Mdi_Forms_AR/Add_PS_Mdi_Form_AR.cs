using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Khayaal_SAHM.Main_Form_and_Children_Forms_AR.Purchases_Form_and_Mdi_Forms_AR
{
    public partial class Add_BG_Mdi_Form_AR : Form
    {


        public event EventHandler Referesh_Current_Form = null;


        static SqlConnection conn = new SqlConnection(Connection_String.Value);

        public Add_BG_Mdi_Form_AR()
        {
            Reload();
        }


        void Reload()
        {


            this.Controls.Clear();
            InitializeComponent();

            Fill_ComboBox();
        }

        private void Fill_ComboBox()
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

        private void Unite_Price_Text_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != 8)
            || (e.KeyChar == '.' && Unit_Price_Text_Box.Text.Contains(".")) || (Unit_Price_Text_Box.Text.Length >= 9 && e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }








        private void Add_PS_Mdi_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referesh_Current_Form?.Invoke(this, e);
        }



        private void Notes_Text_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '"' || e.KeyChar == '=' || e.KeyChar == '\'' || e.KeyChar == ';') || (Notes_Text_Box.Text.Length >= 100 && e.KeyChar != 8)
          || (e.KeyChar == ' ' && Notes_Text_Box.Text.Length == 0))

            {
                e.Handled = true;
            }
        }

        private void Add_Purchase_Button_Click(object sender, EventArgs e)
        {

            if (Qty_Text_Box.Text != "" && Unit_Price_Text_Box.Text != "")
            {
                string Name = Formatter.String(Raw_Combo_Box.Text);
                string Qty = Formatter.Float(Qty_Text_Box.Text);
                string Price = Formatter.Float(Unit_Price_Text_Box.Text);
                string Notes = Formatter.String(Notes_Text_Box.Text);


                Formatter.Check_Connection(conn);




                string Query = $"INSERT INTO CR.Purchases VALUES(CR.Get_Raw_Mat_Id(N'{Name}') ,{Qty},{Price},N'{Notes}',GetDate(),N'{Name}',CR.Get_Last_User_Name_Logged(),CR.Get_Last_User_Id_Logged(),CR.Get_Raw_Category(N'{Name}'));\nUPDATE CR.Raw_Materials SET Qty+= {Qty} WHERE [Name]=\tN'{Name}';\r\n";
                SqlCommand Insert_Query = new SqlCommand(Query, conn);
                try
                {
                    Formatter.Check_Connection(conn);
                    conn.Open();

                    Insert_Query.ExecuteNonQuery();

                    conn.Close();
                    Qty_Text_Box.Text = "";
                    Unit_Price_Text_Box.Text = "";
                    Notes_Text_Box.Text = "";

                    MessageBox.Show("!! تمت بنجاح");
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
                MessageBox.Show("!! تأكد من تعبئة الكمية والسعر");
            }
        }

        private void Qty_Text_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != 8)
           || (e.KeyChar == '.' && Qty_Text_Box.Text.Contains(".")) || (Qty_Text_Box.Text.Length >= 9 && e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
    }
}