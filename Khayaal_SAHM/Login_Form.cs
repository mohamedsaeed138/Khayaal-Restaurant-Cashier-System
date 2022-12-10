using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;
namespace SAHM_Version_ALPHA_0._1
{
    public partial class Login_Form : Form
    {
        //Change it because it's different for evryone !!
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=E:\SAHM\Khayaal_SAHM\DataBase\Restaurant_Cafe.mdf;Integrated Security = True; Connect Timeout = 30");
        public Login_Form()
        {
            InitializeComponent();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        static void Mainformstart()
        {
            Application.Run(new Main_Form());
        }

        private void login_B_Click_1(object sender, EventArgs e)
        {
            String txt_user, txt_pass;
            txt_user = Username.Text;
            txt_pass = Password.Text;
            try
            {
                con.Open();
                String loginQ = "SELECT * FROM CR.Users WHERE User_Name='" + txt_user + "' AND Password='" + txt_pass + "'";
                SqlDataAdapter loginQ_adapter = new SqlDataAdapter(loginQ, con);
                DataTable loginQ_DT = new DataTable();
                loginQ_adapter.Fill(loginQ_DT);
                if (loginQ_DT.Rows.Count > 0)
                {
                    txt_user = Username.Text;
                    txt_pass = Password.Text;

                    SqlCommand loginCOM = new SqlCommand($"INSERT INTO CR.Users_Login_History(User_Name, Date)VALUES('{txt_user}', GETDATE())", con);
                    loginCOM.ExecuteNonQuery();

                    Thread Mainformthread = new Thread(Mainformstart);
                    Mainformthread.SetApartmentState(ApartmentState.STA);
                    Mainformthread.Start();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Wrong Data!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                con.Close();
            }
        }
    }
}
