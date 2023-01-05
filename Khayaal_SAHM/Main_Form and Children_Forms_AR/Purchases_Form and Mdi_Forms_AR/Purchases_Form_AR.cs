using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Khayaal_SAHM.Main_Form_and_Children_Forms_AR.Purchases_Form_and_Mdi_Forms_AR
{
    public partial class Purchases_Form_AR : Form
    {
        static SqlConnection conn = new SqlConnection(Connection_String.Value);


        private void Search_Text_Box_TextChanged(object sender, EventArgs e)
        {
            Choose_Query();
        }

        public Purchases_Form_AR()
        {
            Formatter.Check_Connection(conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Name From CR.Raw_Materials;", conn);
            conn.Open();
            da.Fill(dt);
            conn.Close();
            InitializeComponent();
            Reload();
            if (dt.Rows.Count == 0)
                Add_Purchase_Button.Enabled = false;
            else
                Add_Purchase_Button.Enabled = true;
        }
        void Reload()
        {

            Fill_Combo_Box();
            Fill_Table($"select Id,Name,Qty,Unit_Price,Sub_Total,[Date],Notes FROM CR.Purchases ORDER BY [Date];");
            if (Purchases_Table.Rows.Count == 0)
                From_Date_Picker.Value = To_Date_Picker.Value = DateTime.Now;
            else
            {
                From_Date_Picker.Value = Convert.ToDateTime(Purchases_Table.Rows[0].Cells[5].Value);
                To_Date_Picker.Value = Convert.ToDateTime(Purchases_Table.Rows[Purchases_Table.Rows.Count - 1].Cells[5].Value);
            }


        }
        public void Fill_Combo_Box()
        {
            Name_Combo_Box.DataSource = null;
            Formatter.Check_Connection(conn);

            conn.Open();
            string sql = "SELECT [Name] FROM CR.Purchases ORDER BY [Name];";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            DataRow row = dt.NewRow();
            dt.Rows.InsertAt(row, 0);
            row["Name"] = "All";
            Name_Combo_Box.DataSource = dt;
            Name_Combo_Box.DisplayMember = "Name";

        }

        void Fill_Table(string Query)
        {
            Formatter.Check_Connection(conn);

            SqlCommand Command = new SqlCommand(Query, conn);
            SqlDataAdapter da = new SqlDataAdapter(Command);
            DataTable dt = new DataTable();
            conn.Open();
            da.Fill(dt);


            conn.Close();
            Purchases_Table.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {

                Purchases_Table.Rows.Add((int)row[0], (string)row[1], (double)row[2], (double)row[3], (double)row[4], (DateTime)row[5], (string)row[6]);
            }
            try
            {
                Table_Croll_Bar.Maximum = Purchases_Table.Rows.Count - 1;
            }
            catch { }
            Count_Value_Label.Text = $"{Purchases_Table.Rows.Count}";
            string Sum_Qty = Formatter.Float($"{Purchases_Table.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[2].Value))}");
            string Sum_Total = Formatter.Float($"{Purchases_Table.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDouble(t.Cells[4].Value))}") + " $";

            Sum_Qty_Value_Label.Text = Sum_Qty;

            Sum_Sub_Total_Value_Label.Text = Sum_Total;
        }
        void Choose_Query()
        {
            if (!(Khayaal_SAHM.Formatter.Check_Payment_Date_Range(From_Date_Picker.Value, To_Date_Picker.Value)))
            {
                MessageBox.Show("Data Range Error Change The Date Range!!", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                From_Date_Picker.Value = To_Date_Picker.Value;


            }
            else
            {
                string Name = Formatter.String(Name_Combo_Box.Text);
                string From = Khayaal_SAHM.Formatter.Date_Formating(From_Date_Picker.Value, "From_Payment"), To = Khayaal_SAHM.Formatter.Date_Formating(To_Date_Picker.Value, "To_Payment");
                if (Name == "All")
                    Fill_Table($"SELECT Id,Name,Qty,Unit_Price,Sub_Total,[Date],Notes FROM CR.Purchases WHERE [Date] BETWEEN '{From}' AND '{To}' ORDER BY [Date];");
                else
                    Fill_Table($"SELECT Id,Name,Qty,Unit_Price,Sub_Total,[Date],Notes FROM CR.Purchases [Name]=N'{Name}' AND [Date] BETWEEN '{From}' AND '{To}' ORDER BY [Date];");
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



        private void Table_Croll_Bar_Scroll(object sender, ScrollEventArgs e)
        {
            try
            {
                Table_Croll_Bar.Maximum = Purchases_Table.Rows.Count - 1;

                Purchases_Table.FirstDisplayedScrollingRowIndex = Purchases_Table.Rows[e.NewValue].Index;
            }
            catch { }

        }

        private void Best_Seller_Table_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                Table_Croll_Bar.Maximum = Purchases_Table.Rows.Count - 1;
            }
            catch { }
        }

        private void Best_Seller_Table_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            try
            {
                Table_Croll_Bar.Maximum = Purchases_Table.Rows.Count - 1;
            }
            catch { }
        }

        private void Sort_By_Combo_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            Choose_Query();
        }

        private void Add_Purchase_Button_Click(object sender, EventArgs e)
        {
            Add_BG_Mdi_Form_AR form = new Add_BG_Mdi_Form_AR();
            form.MdiParent = this.Owner;
            form.Referesh_Current_Form += (obj, ef) =>
            {
                this.Reload();
            };
            form.ShowDialog();
        }

        private void Purchases_Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = Purchases_Table.Rows[e.RowIndex];



                if (Purchases_Table.Columns[e.ColumnIndex].Name == "Delete")
                {
                    int id = (int)row.Cells[0].Value;
                    try
                    {
                        string Query = $"DELETE CR.Purchases WHERE Id={id};";
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
    }
}