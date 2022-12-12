using Khayaal_SAHM.Main_Form_and_Children_Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace Khayaal_SAHM
{

    public partial class Login_Form : Form
    {
        SqlConnection LoginCon = new SqlConnection(Connection_String.Value);

        public Login_Form()
        {
            InitializeComponent();

        }



        static void Mainformstart()
        {
            Application.Run(new Main_Form());
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
            String txt_user, txt_pass;
            txt_user = Username.Text;
            txt_pass = Password.Text;
            try
            {
                LoginCon.Open();
                SqlCommand Verify_Login_Command = new SqlCommand($"Select * From CR.Users WHERE User_Name =N'{txt_user}' AND Password=N'{txt_pass}';", LoginCon);
                SqlDataAdapter loginQ_adapter = new SqlDataAdapter(Verify_Login_Command);
                DataTable loginQ_DT = new DataTable();
                loginQ_adapter.Fill(loginQ_DT);
                if (loginQ_DT.Rows.Count > 0)
                {
                    txt_user = Username.Text;
                    txt_pass = Password.Text;

                    SqlCommand loginCOM = new SqlCommand($"INSERT INTO CR.Users_Login_History(User_Name, Date)VALUES(N'{txt_user}', GETDATE());", LoginCon);
                    loginCOM.ExecuteNonQuery();

                    Thread Mainformthread = new Thread(Mainformstart);
                    Mainformthread.SetApartmentState(ApartmentState.STA);
                    Mainformthread.Start();

                    this.Close();
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

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
