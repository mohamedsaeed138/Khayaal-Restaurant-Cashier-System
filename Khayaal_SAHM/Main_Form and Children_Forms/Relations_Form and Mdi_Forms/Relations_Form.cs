using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Khayaal_SAHM.Main_Form_and_Children_Forms.Relations_Form_and_Mdi_Forms
{
    public partial class Relations_Form : Form
    {
        static SqlConnection conn = new SqlConnection(Connection_String.Value);


        private void Search_Text_Box_TextChanged(object sender, EventArgs e)
        {
            Choose_Query();
        }

        public Relations_Form()
        {

            InitializeComponent();

            Fill_Item_Raw_Combo_Boxes();
            Fill_Table($"SELECT  CR.Get_Item_Name(Item_Id) AS [Item] ,CR.Get_Raw_Mat_Name(Raw_Id) AS [Raw_Material],[Qty_Needed],[Available]FROM CR.Items_Relations ORDER BY [Item] ASC;");


        }
        public void Fill_Item_Raw_Combo_Boxes()
        {
            conn.Open();
            string sql_item = "SELECT Name FROM CR.Items ORDER BY Name ASC;";
            string sql_raw = "SELECT Name FROM CR.Raw_Materials ORDER BY Name ASC;";
            SqlDataAdapter da = new SqlDataAdapter(sql_item, conn);
            DataTable dt_item = new DataTable();
            DataTable dt_raw = new DataTable();
            da.Fill(dt_item);
            da = new SqlDataAdapter(sql_raw, conn);
            da.Fill(dt_raw);
            conn.Close();

            DataRow row = dt_item.NewRow();
            dt_item.Rows.InsertAt(row, 0);
            row["Name"] = "All";
            Item_Combo_Box.DataSource = dt_item.DataSet;
            Item_Combo_Box.DisplayMember = "Name";

            DataRow row2 = dt_item.NewRow();
            dt_item.Rows.InsertAt(row2, 0);
            row["Name"] = "All";
            Item_Combo_Box.DataSource = dt_raw.DataSet;
            Item_Combo_Box.DisplayMember = "Name";

        }

        void Fill_Table(string Query)//ok
        {

            SqlCommand Command = new SqlCommand(Query, conn);
            SqlDataAdapter da = new SqlDataAdapter(Command);
            DataTable dt = new DataTable();
            conn.Open();
            da.Fill(dt);


            conn.Close();
            Relations_Table.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {

                Relations_Table.Rows.Add((string)row[0], (string)row[1], (double)row[2], Convert.ToBoolean(row[3]));
            }
            try
            {
                Table_Croll_Bar.Maximum = Relations_Table.Rows.Count - 1;
            }
            catch { }
            Count_Value_Label.Text = $"{Relations_Table.Rows.Count}";
        }
        void Choose_Query()
        {
            if (Search_Text_Box.Text != string.Empty && Item_Combo_Box.Text != "All" && Raw_Combo_Box.Text != "All")
                Fill_Table($"");
            else if (Search_Text_Box.Text != string.Empty && Item_Combo_Box.Text != "All" && Raw_Combo_Box.Text == "All")
                Fill_Table($"");
            else if (Search_Text_Box.Text != string.Empty && Item_Combo_Box.Text == "All" && Raw_Combo_Box.Text != "All")
                Fill_Table($"");
            else if (Search_Text_Box.Text != string.Empty && Item_Combo_Box.Text == "All" && Raw_Combo_Box.Text == "All")
                Fill_Table($"");
            else if (Search_Text_Box.Text == string.Empty && Item_Combo_Box.Text != "All" && Raw_Combo_Box.Text != "All")
                Fill_Table($"");
            else if (Search_Text_Box.Text == string.Empty && Item_Combo_Box.Text != "All" && Raw_Combo_Box.Text == "All")
                Fill_Table($"");
            else if (Search_Text_Box.Text == string.Empty && Item_Combo_Box.Text == "All" && Raw_Combo_Box.Text != "All")
                Fill_Table($"");
            else if (Search_Text_Box.Text == string.Empty && Item_Combo_Box.Text == "All" && Raw_Combo_Box.Text == "All")
                Fill_Table($"");




        }








        private void Category_Combo_Box_SelectedIndexChanged(object sender, EventArgs e)
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
                Table_Croll_Bar.Maximum = Relations_Table.Rows.Count - 1;

                Relations_Table.FirstDisplayedScrollingRowIndex = Relations_Table.Rows[e.NewValue].Index;
            }
            catch { }

        }

        private void Best_Seller_Table_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                Table_Croll_Bar.Maximum = Relations_Table.Rows.Count - 1;
            }
            catch { }
        }

        private void Best_Seller_Table_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            try
            {
                Table_Croll_Bar.Maximum = Relations_Table.Rows.Count - 1;
            }
            catch { }
        }
        
        DataGridViewButtonColumn btn = new DataGridViewButtonColumn();

        private void Relations_Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (Relations_Table.Columns[e.ColumnIndex].Name == "Delete")
                {

                }

            }
        }
    }
}
