using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Khayaal_SAHM.Login_Form_and_Mdi_Forms
{
    public partial class Change_Password_Mdi_Form : Form
    {
        int Id;
        static SqlConnection conn = new SqlConnection(Connection_String.Value);



        public Change_Password_Mdi_Form(int Id)
        {
            InitializeComponent();
            this.Id = Id;
            Password_Text_Box.UseSystemPasswordChar = true;

        }












        private void Edit_Button_Click(object sender, EventArgs e)
        {

            if (Password_Text_Box.Text != "")
            {
                string Password = Password_Text_Box.Text;
                Formatter.Check_Connection(conn);

                SqlCommand Update_Query = new SqlCommand($"Update CR.Users SET [Password]=N'{Password}' WHERE Id={Id};", conn);


                Formatter.Check_Connection(conn);
                conn.Open();

                Update_Query.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Successfully Done   تمت بنجاح");

                this.Close();



            }
            else
            {
                MessageBox.Show("Enter The New Password !    ! ادخل الرقم السري الجديد ");
            }
        }

        private void Password_Text_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                Edit_Button_Click(sender, e);
            else if ((e.KeyChar == '"' || e.KeyChar == '=' || e.KeyChar == '\'' || e.KeyChar == ';') || (Password_Text_Box.Text.Length >= 50 && e.KeyChar != 8)
            || (e.KeyChar == ' ' && Password_Text_Box.Text.Length == 0))
                e.Handled = true;
        }

        private void Show_Password_Check_Box_CheckedChanged(object sender, EventArgs e)
        {
            Password_Text_Box.UseSystemPasswordChar = Password_Text_Box.UseSystemPasswordChar == false ? true : false;

        }
    }
}