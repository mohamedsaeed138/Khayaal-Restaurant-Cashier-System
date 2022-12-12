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
using System.Windows.Markup;

namespace Khayaal_SAHM.Main_Form_and_Children_Forms.Home_Form_and_Mdi_Forms
{
    public partial class Add_Mdi_Form : Form
    {
        public Add_Mdi_Form()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\SAHM\SAHM\Khayaal_SAHM\DataBase\Restaurant_Cafe.mdf; Integrated Security = True");
            //SqlCommand cmd = new SqlCommand("select category from category", conn);
            //SqlDataAdapter da = new SqlDataAdapter();
            //da.SelectCommand = cmd;
            //DataTable table1 = new DataTable();
            //da.Fill(table1);
            //guna2ComboBox1.DataSource = table1;
            //guna2ComboBox1.DisplayMember = "category";
        }

        private void TB_Item_Name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
