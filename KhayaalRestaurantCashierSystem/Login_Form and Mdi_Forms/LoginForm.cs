using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;
using Khayaal.Main_Form_and_Children_Forms;
using Khayaal.Main_Form_and_Children_Forms_AR;

enum Cases
{
    LogIn, ChangePassword, Users
}

namespace Khayaal.Login_Form_and_Mdi_Forms
{

    public partial class LoginForm : Form
    {
        readonly SqlConnection loginConnection = new SqlConnection(ConnectionString.Value);

        public LoginForm()
        {
            InitializeComponent();
            Language_Combo_Box.SelectedIndex = 0;
            Password_Text_Box.UseSystemPasswordChar = true;
        }
        private void Input_Process(Cases @case)
        {
            if (Id_Text_Box.Text != "" && Password_Text_Box.Text != "")
            {
                var id = Int32.Parse(Id_Text_Box.Text);
                var password = Password_Text_Box.Text;
                try
                {
                    SqlDataAdapter loginQ_adapter = new SqlDataAdapter($"Select * From CR.Users WHERE Id ={id} AND Password=N'{password}' COLLATE SQL_Latin1_General_CP1_CS_AS;", loginConnection);
                    DataTable loginQDt = new DataTable();
                    loginConnection.Open();
                    loginQ_adapter.Fill(loginQDt);
                    loginConnection.Close();
                    if (loginQDt.Rows.Count > 0)
                    {
                        string name = (string)loginQDt.Rows[0][3];
                        string type = (string)loginQDt.Rows[0][2];
                        bool normalUser = type == "Cashier كاشير" ? true : false;
                        bool Owner_or_Developer = type == "Owner مالك" || type == "Developer مطور" ? true : false;
                        if (@case == Cases.LogIn)
                        {
                            string Date = Formatter.DateFormating(new DateTime(DateTime.Now.Year - 2, 1, 1));

                            Thread Mainformthread;

                            SqlCommand loginCOM = new SqlCommand($"TRUNCATE TABLE CR.Users_Login_History;\nINSERT INTO CR.Users_Login_History VALUES({id},N'{name}', GETDATE());\nDELETE CR.Tables_Booking_Details WHERE [TO]<GETDATE();\r\nDELETE CR.Bills WHERE [Date]<'{Date}';\nDELETE CR.Bills_Details WHERE [Date]<'{Date}';\nDELETE CR.Purchases WHERE [Date]<'{Date}';\n\r", loginConnection);

                            loginConnection.Open();
                            loginCOM.ExecuteNonQuery();
                            loginConnection.Close();

                            if (Language_Combo_Box.SelectedIndex == 0)
                            {
                                if (normalUser)
                                    Mainformthread = new Thread(() => Application.Run(new Main_Form_AR(true)));

                                else
                                    Mainformthread = new Thread(() => Application.Run(new Main_Form_AR()));
                            }
                            else
                            {
                                if (normalUser)
                                    Mainformthread = new Thread(() => Application.Run(new Main_Form(true)));

                                else
                                    Mainformthread = new Thread(() => Application.Run(new Main_Form()));

                            }
                            this.Close();
                            Mainformthread.SetApartmentState(ApartmentState.STA);
                            Mainformthread.Start();
                        }
                        else if (@case == Cases.ChangePassword)
                        {
                            ChangePasswordMdiForm form = new ChangePasswordMdiForm(id);
                            form.MdiParent = this.Owner;

                            form.ShowDialog();
                        }
                        else
                        {
                            if (Owner_or_Developer)
                            {
                                Users_Child_Form.UsersChildForm form = new Users_Child_Form.UsersChildForm();
                                form.ShowDialog();

                            }
                            else
                                MessageBox.Show("You have no permission !! ليس لديك اذن");

                        }


                    }
                    else
                    {
                        MessageBox.Show("Wrong Username or Password! اسم المستخدم او الرقم السري خاطئ", "Error  خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message);
                }
                finally
                {
                    loginConnection.Close();
                }
            }
            else
            {
                MessageBox.Show("Fill The Fields !! قم بتعبئة الحقول");
            }
        }

        private void Username_Text_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && e.KeyChar != 8) || (Id_Text_Box.Text.Length >= 9 && e.KeyChar != 8))
                e.Handled = true;
        }
        private void Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                Input_Process(Cases.LogIn);
            else if ((e.KeyChar == '"' || e.KeyChar == '=' || e.KeyChar == '\'' || e.KeyChar == ';') || (Password_Text_Box.Text.Length >= 50 && e.KeyChar != 8)
            || (e.KeyChar == ' ' && Password_Text_Box.Text.Length == 0))
                e.Handled = true;
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            Input_Process(Cases.LogIn);
        }

        private void Change_Password_Label_Click(object sender, EventArgs e)
        {
            Input_Process(Cases.ChangePassword);
        }

        private void Show_Password_Check_Box_CheckedChanged(object sender, EventArgs e)
        {
            Password_Text_Box.UseSystemPasswordChar = Password_Text_Box.UseSystemPasswordChar == false ? true : false;
        }

        private void Users_Label_Click(object sender, EventArgs e)
        {
            Input_Process(Cases.Users);
        }


    }
}
