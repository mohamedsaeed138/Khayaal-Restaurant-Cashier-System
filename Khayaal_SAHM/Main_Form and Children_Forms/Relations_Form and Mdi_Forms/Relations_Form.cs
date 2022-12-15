using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Khayaal_SAHM.Main_Form_and_Children_Forms.Relations_Form_and_Mdi_Forms
{
    public partial class Relations_Form : Form
    {
        static SqlConnection conn = new SqlConnection(Connection_String.Value);




        public Relations_Form()
        {

            InitializeComponent();


            Fill_Item_Raw_Combo_Boxes();
            Fill_Table($"SELECT  CR.Get_Item_Name(Item_Id) AS [Item] ,CR.Get_Raw_Mat_Name(Raw_Id) AS [Raw_Material],[Qty_Needed]FROM CR.Items_Relations ORDER BY [Item] ASC;");


        }
        public void Fill_Item_Raw_Combo_Boxes()
        {






            SqlDataAdapter dai = new SqlDataAdapter("SELECT Name FROM CR.Items ORDER BY Name ASC;", conn);
            DataTable dti = new DataTable();
            conn.Open();
            dai.Fill(dti);
            conn.Close();
            DataRow row1 = dti.NewRow();
            dti.Rows.InsertAt(row1, 0);
            row1["Name"] = "All";
            Item_Combo_Box.DataSource = dti.DataSet;

            conn.Open();
            string sql_row = "SELECT Name FROM CR.Raw_Materials ORDER BY Name ASC;";
            SqlDataAdapter da2 = new SqlDataAdapter(sql_row, conn);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            conn.Close();
            DataRow row2 = dt2.NewRow();
            dt2.Rows.InsertAt(row2, 0);
            row2["Name"] = "All";
            Raw_Combo_Box.DataSource = dt2.DataSet;



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

                Relations_Table.Rows.Add((string)row[0], (string)row[1], (double)row[2]);
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

            if (Item_Combo_Box.Text == "All" && Raw_Combo_Box.Text == "All")
                Fill_Table($"SELECT  CR.Get_Item_Name(Item_Id) AS [Item] ,CR.Get_Raw_Mat_Name(Raw_Id) AS [Raw_Material],[Qty_Needed]FROM CR.Items_Relations ORDER BY [Item] ASC;");
            else if (Item_Combo_Box.Text != "All" && Raw_Combo_Box.Text != "All")
                Fill_Table($"SELECT  CR.Get_Item_Name(Item_Id) AS [Item] ,CR.Get_Raw_Mat_Name(Raw_Id) AS [Raw_Material],[Qty_Needed]FROM CR.Items_Relations WHERE [Raw_Material]=N'{Raw_Combo_Box.Text}' AND [Item]=N'{Item_Combo_Box.Text}' ORDER BY [Item] ASC;");
            else if (Item_Combo_Box.Text == "All" && Raw_Combo_Box.Text != "All")
                Fill_Table($"SELECT  CR.Get_Item_Name(Item_Id) AS [Item] ,CR.Get_Raw_Mat_Name(Raw_Id) AS [Raw_Material],[Qty_Needed]FROM CR.Items_Relations WHERE [Raw_Material]=N'{Raw_Combo_Box.Text}'  ORDER BY [Item] ASC;");
            else
                Fill_Table($"SELECT  CR.Get_Item_Name(Item_Id) AS [Item] ,CR.Get_Raw_Mat_Name(Raw_Id) AS [Raw_Material],[Qty_Needed]FROM CR.Items_Relations WHERE [Item]=N'{Item_Combo_Box.Text}' ORDER BY [Item] ASC;");


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
                    // Enter Query To Delete 
                }
                if (Relations_Table.Columns[e.ColumnIndex].Name == "Edite")
                {
                    //Enter Query To Edite
                }

            }
        }

        private void Item_Combo_Box_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Choose_Query();
        }

        private void Raw_Combo_Box_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Choose_Query();
        }
    }
}
