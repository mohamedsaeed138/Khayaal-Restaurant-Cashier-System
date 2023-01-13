using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Khayaal_SAHM.Login_Form_and_Mdi_Forms.Users_Child_Form
{
    public partial class Add_Edit_User_Mdi_Form : Form
    {
        string Username;
        static SqlConnection conn = new SqlConnection(Connection_String.Value);



        public Add_Edit_User_Mdi_Form(string Username)
        {
            InitializeComponent();
            this.Username = Username;
            Change_Password_Text_Box.UseSystemPasswordChar = true;

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







        private void Edit_Button_Click(object sender, EventArgs e)
        {

            if (Change_Password_Text_Box.Text != "")
            {
                string Password = Change_Password_Text_Box.Text;
                Formatter.Check_Connection(conn);

                SqlCommand Update_Query = new SqlCommand($"Update CR.Users SET [Password]=N'{Password}' WHERE Username=N'{Username}';", conn);


                Formatter.Check_Connection(conn);
                conn.Open();

                Update_Query.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Successfully Done   تمت بنجاح");

                this.Close();



            }
            else
            {
                MessageBox.Show("Enter The New Password    ادخل الرقم السري الجديد ");
            }
        }

        private void Change_Password_Text_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                Edit_Button_Click(sender, e);
            else if ((!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8) || (Change_Password_Text_Box.Text.Length >= 50 && e.KeyChar != 8))
                e.Handled = true;
        }

        private void Show_Password_Check_Box_CheckedChanged(object sender, EventArgs e)
        {
            Change_Password_Text_Box.UseSystemPasswordChar = Change_Password_Text_Box.UseSystemPasswordChar == false ? true : false;

        }
    }
}