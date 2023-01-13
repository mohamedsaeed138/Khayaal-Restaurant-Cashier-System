using Khayaal_SAHM.Main_Form_and_Children_Forms;
using Khayaal_SAHM.Main_Form_and_Children_Forms_AR;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace Khayaal_SAHM
{

    public partial class Login_Form : Form
    {
        readonly SqlConnection LoginCon = new SqlConnection(Connection_String.Value);

        public Login_Form()
        {
            InitializeComponent();
            Language_Combo_Box.SelectedIndex = 0;
        }




        private void Close_B_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void Login_B_Click_1(object sender, EventArgs e)
        {
            Enter_a_Login();
        }

        private void Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                Enter_a_Login();
        }
        private void Enter_a_Login()
        {
            string txt_user, txt_pass;
            txt_user = Username_Text_Box.Text;
            txt_pass = Password_Text_Box.Text;
            try
            {
                SqlCommand Verify_Login_Command = new SqlCommand($"Select * From CR.Users WHERE Username =N'{txt_user}' COLLATE SQL_Latin1_General_CP1_CS_AS AND Password=N'{txt_pass}' COLLATE SQL_Latin1_General_CP1_CS_AS;", LoginCon);
                SqlDataAdapter loginQ_adapter = new SqlDataAdapter(Verify_Login_Command);
                DataTable loginQ_DT = new DataTable();
                LoginCon.Open();
                loginQ_adapter.Fill(loginQ_DT);
                LoginCon.Close();
                if (loginQ_DT.Rows.Count > 0)
                {
                    Thread Mainformthread;

                    SqlCommand loginCOM = new SqlCommand($"TRUNCATE TABLE CR.Users_Login_History;\nINSERT INTO CR.Users_Login_History(Name, Date)VALUES(N'{txt_user}', GETDATE());\nDELETE CR.Tables_Booking_Details WHERE [TO]<GETDATE();\r\n", LoginCon);
                    LoginCon.Open();
                    loginCOM.ExecuteNonQuery();
                    LoginCon.Close();
                    if (Language_Combo_Box.SelectedIndex == 0)
                        Mainformthread = new Thread(() => Application.Run(new Main_Form_AR()));
                    else
                        Mainformthread = new Thread(() => Application.Run(new Main_Form()));

                    this.Close();
                    Mainformthread.SetApartmentState(ApartmentState.STA);
                    Mainformthread.Start();


                }
                else
                {
                    MessageBox.Show("Wrong Username or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            finally
            {
                LoginCon.Close();
            }
        }


    }
}
