﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Khayaal_SAHM.Login_Form_and_Mdi_Forms.Users_Child_Form
{
    public partial class Add_Edit_User_Mdi_Form : Form
    {
        public event EventHandler Referesh_Current_Form = null;
        bool Add = true;
        static SqlConnection conn = new SqlConnection(Connection_String.Value);



        public Add_Edit_User_Mdi_Form()
        {
            InitializeComponent();
            Password_Text_Box.UseSystemPasswordChar = true;
            Jop_Combo_Box.SelectedIndex = 0;
        }

        public Add_Edit_User_Mdi_Form(string username, string jop, string name, string pass)
        {
            InitializeComponent();

            Add = false;
            Add_Edit_Button.Text = "Edit تعديل";
            Password_Text_Box.UseSystemPasswordChar = true;
            Username_Text_Box.Text = username;
            Username_Text_Box.ReadOnly = true;
            Jop_Combo_Box.Text = jop;
            Name_Text_Box.Text = name;
            Password_Text_Box.Text = pass;
        }

        private void Change_Password_Text_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                Add_Edit_Button_Click(sender, e);
            else if ((!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8) || (Password_Text_Box.Text.Length >= 50 && e.KeyChar != 8))
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

        private void Name_Text_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ' ' || (Name_Text_Box.Text.Length >= 50 && e.KeyChar != 8))
          || (Name_Text_Box.Text.Length > 1 && Name_Text_Box.Text[Name_Text_Box.Text.Length - 1] == ' ' && e.KeyChar == ' ') || (e.KeyChar == ' ' && Name_Text_Box.Text.Length == 0))

            {
                e.Handled = true;
            }
        }

        private void Add_Edit_Button_Click(object sender, EventArgs e)
        {
            if (Name_Text_Box.Text != "" && Username_Text_Box.Text != "" && Password_Text_Box.Text != "")
            {
                string Username = Username_Text_Box.Text;
                string Name = Formatter.String(Name_Text_Box.Text);
                string Jop = Jop_Combo_Box.Text;
                string Password = Password_Text_Box.Text;

                Formatter.Check_Connection(conn);
                if (Add)
                {




                    string Query = $"INSERT INTO CR.Users VALUES(N'{Username}',N'{Password}',N'{Jop}',N'{Name}') ;";
                    SqlCommand Insert_Query = new SqlCommand(Query, conn);
                    try
                    {
                        Formatter.Check_Connection(conn);
                        conn.Open();

                        Insert_Query.ExecuteNonQuery();

                        conn.Close();

                        Name_Text_Box.Text = "";
                        Username_Text_Box.Text = "";
                        Password_Text_Box.Text = "";



                        MessageBox.Show("Successfully Done تمت بنجاح");
                    }

                    catch
                    {
                        MessageBox.Show("There is a User With Same Name or Username or Both!! !!يوجد مستخدم بنفس الاسم او اسم المستخدم او كلاهما ");

                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                else
                {

                    string Query = $"Update CR.Users SET Password = N'{Password}',Name=N'{Name}',Type=N'{Jop}' WHERE Username =N'{Username}';";
                    SqlCommand Update_Query = new SqlCommand(Query, conn);
                    try
                    {
                        Formatter.Check_Connection(conn);
                        conn.Open();

                        Update_Query.ExecuteNonQuery();
                        conn.Close();
                        this.Close();

                        MessageBox.Show("Successfully Done تمت بنجاح");
                    }

                    catch
                    {
                        MessageBox.Show("There is a User With Same Name or Username or Both!! !!يوجد مستخدم بنفس الاسم او اسم المستخدم او كلاهما ");

                    }
                    finally
                    {
                        conn.Close();
                    }
                }

            }
            else
            {
                MessageBox.Show("Ensure Filling All Fields !!  !!تأكد من تعبئة جميع الحقول ");
            }
        }


        private void Add_Edit_User_Mdi_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referesh_Current_Form?.Invoke(this, e);

        }
    }
}