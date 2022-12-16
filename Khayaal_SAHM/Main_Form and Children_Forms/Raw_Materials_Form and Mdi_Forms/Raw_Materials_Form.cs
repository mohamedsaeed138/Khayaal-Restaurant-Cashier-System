using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Khayaal_SAHM.Main_Form_and_Children_Forms.Raw_Materials_Form_and_Mdi_Forms
{
    public partial class Raw_Materials_Form : Form
    {
        static SqlConnection conn = new SqlConnection(Connection_String.Value);


        private void Search_Text_Box_TextChanged(object sender, EventArgs e)
        {
            
            Choose_Query();
        }

        public Raw_Materials_Form()
        {

            InitializeComponent();

            Fill_Combo_Box();
            Fill_Table($"select [Name] as Name,[Category] as Category,[Qty] as Quntity,[Id] from CR.Raw_Materials");

        }
        public void Fill_Category_Combo_Boxe()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            SqlDataAdapter da2 = new SqlDataAdapter($"SELECT[Category] FROM CR.Raw_Materials Group BY[Category] ASC;", conn);
            DataTable dt2 = new DataTable();
            conn.Open();
            da2.Fill(dt2);
            conn.Close();
            DataRow row2 = dt2.NewRow();
            dt2.Rows.InsertAt(row2, 0);
            row2["Category"] = "All";
            Category_Combo_Box.DataSource = dt2;
            Category_Combo_Box.DisplayMember = "Category";
        }
        public void Fill_Combo_Box()
        {
            conn.Open();
            string sql = "SELECT Category FROM CR.Items GROUP BY Category";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            DataRow row = dt.NewRow();
            dt.Rows.InsertAt(row, 0);
            row["Category"] = "All";
            Category_Combo_Box.DataSource = dt;
            Category_Combo_Box.DisplayMember = "Category";

        }

        void Fill_Table(string Query)
        {

            SqlCommand Command = new SqlCommand(Query, conn);
            SqlDataAdapter da = new SqlDataAdapter(Command);
            DataTable dt = new DataTable();
            conn.Open();
            da.Fill(dt);


            conn.Close();
            Raw_Material_Table.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {

                Raw_Material_Table.Rows.Add((string)row[0], (string)row[1], (double)row[2], (int)row[3]);
            }
            try
            {
                Table_Croll_Bar.Maximum = Raw_Material_Table.Rows.Count - 1;
            }
            catch { }
            Count_Value_Label.Text = $"{Raw_Material_Table.Rows.Count}";
        }
        void Choose_Query()
        {
            if (Search_Text_Box.Text == string.Empty && Category_Combo_Box.Text == "All" && Sorting_Combo_Box.Text == "Name"&&Qty_Combo_Combo_Box.Text=="All")
            {
                Fill_Table("select * from CR.Raw_Material ");
            }
        }








        private void Category_Combo_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            Choose_Query();
        }

        private void From_Date_Picker_ValueChanged(object sender, EventArgs e)
        {
            Choose_Query();
        }

        private void To_Date_Picker_ValueChanged(object sender, EventArgs e)
        {
            Choose_Query();
        }

        private void Search_Text_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ' ' || (Search_Text_Box.Text.Length >= 50 && e.KeyChar != 8))
           || (Search_Text_Box.Text.Length > 1 && Search_Text_Box.Text[Search_Text_Box.Text.Length - 1] == ' ' && e.KeyChar == ' ') || (e.KeyChar == ' ' && Search_Text_Box.Text.Length == 0))

            {
                e.Handled = true;
            }
        }

        private void Table_Croll_Bar_Scroll(object sender, ScrollEventArgs e)
        {
            try
            {
                Table_Croll_Bar.Maximum = Raw_Material_Table.Rows.Count - 1;

                Raw_Material_Table.FirstDisplayedScrollingRowIndex = Raw_Material_Table.Rows[e.NewValue].Index;
            }
            catch { }

        }

        private void Best_Seller_Table_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                Table_Croll_Bar.Maximum = Raw_Material_Table.Rows.Count - 1;
            }
            catch { }
        }

        private void Best_Seller_Table_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            try
            {
                Table_Croll_Bar.Maximum = Raw_Material_Table.Rows.Count - 1;
            }
            catch { }
        }


    }
}
