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
        SqlConnection conn = new SqlConnection(Connection_String.Value);
        public Add_Mdi_Form()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            
        }

        private void TB_Item_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Mdi_Form_load(object sender, EventArgs e)
        {
            string sql = "select Category from CR.Items";
            SqlDataAdapter da = new SqlDataAdapter(sql,conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmb_category.DataSource = dt;
            cmb_category.DisplayMember = "Category";

        }

    }
}
