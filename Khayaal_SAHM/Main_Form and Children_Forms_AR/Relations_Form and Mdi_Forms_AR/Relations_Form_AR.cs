using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Khayaal_SAHM.Main_Form_and_Children_Forms_AR.Relations_Form_and_Mdi_Forms_AR
{
    public partial class Relations_Form_AR : Form
    {
        static SqlConnection conn = new SqlConnection(Connection_String.Value);




        public Relations_Form_AR()
        {
            InitializeComponent();
            Reload();

        }
        void Reload()
        {

            Fill_Item_Combo_Boxe();
            Fill_Raw_Combo_Boxe();

            Fill_Table($"SELECT  CR.Get_Item_Name(Item_Id) AS [Item] ,CR.Get_Raw_Mat_Name(Raw_Id) AS [Raw_Material],[Qty_Needed] , [Id] FROM CR.Items_Relations ORDER BY [Item] ASC;");
        }
        public void Fill_Item_Combo_Boxe()
        {
            Item_Combo_Box.DataSource = null;
            Formatter.Check_Connection(conn);

            SqlDataAdapter dai = new SqlDataAdapter("SELECT [Name] FROM CR.Items ORDER BY [Name] ASC;", conn);
            DataTable dt1 = new DataTable();
            conn.Open();
            dai.Fill(dt1);
            conn.Close();
            DataRow row1 = dt1.NewRow();
            dt1.Rows.InsertAt(row1, 0);
            row1["Name"] = "All";
            Item_Combo_Box.DataSource = dt1;
            Item_Combo_Box.DisplayMember = "Name";


        }
        public void Fill_Raw_Combo_Boxe()
        {
            Raw_Combo_Box.DataSource = null;
            Formatter.Check_Connection(conn);
            SqlDataAdapter da2 = new SqlDataAdapter($"SELECT[Name] FROM CR.Raw_Materials ORDER BY[Name] ASC;", conn);
            DataTable dt2 = new DataTable();
            conn.Open();
            da2.Fill(dt2);
            conn.Close();
            if (dt2.Rows.Count == 0)
                Add_Button.Enabled = false;
            else
                Add_Button.Enabled = true;
            DataRow row2 = dt2.NewRow();
            dt2.Rows.InsertAt(row2, 0);
            row2["Name"] = "All";
            Raw_Combo_Box.DataSource = dt2;
            Raw_Combo_Box.DisplayMember = "Name";
        }

        void Fill_Table(string Query)//ok
        {
            Formatter.Check_Connection(conn);

            SqlDataAdapter da = new SqlDataAdapter(Query, conn);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                da.Fill(dt);
                conn.Close();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            Relations_Table.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {

                Relations_Table.Rows.Add((string)row[0], (string)row[1], (double)row[2], (int)row[3]);
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
                Fill_Table($"SELECT  CR.Get_Item_Name(Item_Id) AS [Item] , CR.Get_Raw_Mat_Name(Raw_Id) AS [Raw_Material] , [Qty_Needed] , [Id]  FROM CR.Items_Relations ORDER BY [Item] ASC;");
            else if (Item_Combo_Box.Text != "All" && Raw_Combo_Box.Text != "All")
                Fill_Table($"SELECT  CR.Get_Item_Name(Item_Id) AS [Item] , CR.Get_Raw_Mat_Name(Raw_Id) AS [Raw_Material] , [Qty_Needed] , [Id]  FROM CR.Items_Relations WHERE CR.Get_Raw_Mat_Name(Raw_Id)= N'{Raw_Combo_Box.Text}' and CR.Get_Item_Name(Item_Id)= N'{Item_Combo_Box.Text}' ORDER BY [Item] ASC;");
            else if (Item_Combo_Box.Text == "All" && Raw_Combo_Box.Text != "All")
                Fill_Table($"SELECT  CR.Get_Item_Name(Item_Id) AS [Item] , CR.Get_Raw_Mat_Name(Raw_Id) AS [Raw_Material] , [Qty_Needed] , [Id]  FROM CR.Items_Relations WHERE CR.Get_Raw_Mat_Name(Raw_Id)= N'{Raw_Combo_Box.Text}'  ORDER BY [Item] ASC;");
            else
                Fill_Table($"SELECT  CR.Get_Item_Name(Item_Id) AS [Item] , CR.Get_Raw_Mat_Name(Raw_Id) AS [Raw_Material] , [Qty_Needed] , [Id]  FROM CR.Items_Relations WHERE CR.Get_Item_Name(Item_Id)= N'{Item_Combo_Box.Text}' ORDER BY [Item] ASC;");


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
            try
            {
                DataGridViewRow row = Relations_Table.Rows[e.RowIndex];
                string item = (string)row.Cells[0].Value;
                string raw = (string)row.Cells[1].Value;
                string qty = Formatter.Float($"{(double)row.Cells[2].Value}");
                int id = (int)row.Cells[3].Value;
                if (Relations_Table.Columns[e.ColumnIndex].Name == "Edit")
                {
                    Add_Edit_RS_Mdi_Form_AR form = new Add_Edit_RS_Mdi_Form_AR(item, raw, qty, id);
                    form.MdiParent = this.Owner;
                    form.Referesh_Current_Form += (obj2, ef) =>
                    {
                        this.Reload();
                    };
                    form.ShowDialog();
                }
                else if (Relations_Table.Columns[e.ColumnIndex].Name == "Delete")
                {
                    try
                    {
                        string Query = $"DELETE CR.Items_Relations WHERE Id={id};\n";
                        Formatter.Check_Connection(conn);
                        SqlCommand Delete = new SqlCommand(Query, conn);
                        conn.Open();
                        Delete.ExecuteNonQuery();
                        conn.Close();
                        Choose_Query();
                        MessageBox.Show("Successfully Done!");
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
            }
            catch { }
        }

        private void Item_Combo_Box_TextChanged(object sender, EventArgs e)
        {
            Choose_Query();
        }

        private void Raw_Combo_Box_TextChanged(object sender, EventArgs e)
        {
            Choose_Query();
        }



        private void Add_Button_Click(object sender, EventArgs e)
        {
            Add_Edit_RS_Mdi_Form_AR form = new Add_Edit_RS_Mdi_Form_AR();
            form.MdiParent = this.Owner;
            form.Referesh_Current_Form += (obj, ef) =>
            {
                this.Reload();
            };
            form.ShowDialog();
        }
    }
}
