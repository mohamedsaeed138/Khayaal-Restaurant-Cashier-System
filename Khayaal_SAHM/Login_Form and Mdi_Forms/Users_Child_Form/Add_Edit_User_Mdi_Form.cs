using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Khayaal_SAHM.Login_Form_and_Mdi_Forms.Users_Child_Form
{
    public partial class Add_Edit_User_Mdi_Form : Form
    {
        string username;
        string jop;
        string name;
        string pass;
        static SqlConnection conn = new SqlConnection(Connection_String.Value);



        public Add_Edit_User_Mdi_Form()
        {
            InitializeComponent();
            Password_Text_Box.UseSystemPasswordChar = true;

        }



        private void Change_Password_Text_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == '\r')
            //Edit_Button_Click(sender, e);
            // else
            if ((!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8) || (Password_Text_Box.Text.Length >= 50 && e.KeyChar != 8))
                e.Handled = true;
        }

        private void Show_Password_Check_Box_CheckedChanged(object sender, EventArgs e)
        {
            Password_Text_Box.UseSystemPasswordChar = Password_Text_Box.UseSystemPasswordChar == false ? true : false;

        }

        private void Username_Text_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8) || (Username_Text_Box.Text.Length >= 50 && e.KeyChar != 8))
                e.Handled = true;
        }
    }
}