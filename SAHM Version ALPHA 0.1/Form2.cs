using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Microsoft.VisualBasic.ApplicationServices;

namespace SAHM_Version_ALPHA_0._1
{
    public partial class LoginS : Form
    {
        //Change it because it's different for evryone !!
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\User\Documents\GitHub\New folder\Solution3\SAHM Version ALPHA 0.1\DataBase\Restaurant_Cafe.mdf"";Integrated Security=True;Connect Timeout=30");
        public LoginS()
        {
            InitializeComponent();
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void login_B_Click(object sender, EventArgs e)
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
                    
                    //Put the new form here

                    /*Main_Form main_Form = new Main_Form();
                    main_Form.Show();*/

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
