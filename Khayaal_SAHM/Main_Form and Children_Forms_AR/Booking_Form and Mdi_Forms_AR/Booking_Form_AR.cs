using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Khayaal_SAHM.Main_Form_and_Children_Forms_AR.Booking_Form_and_Mdi_Forms_AR
{
    public partial class Booking_Form_AR : Form
    {
        static SqlConnection conn = new SqlConnection(Connection_String.Value);


        private void Search_Text_Box_TextChanged(object sender, EventArgs e)
        {
            Choose_Query();
        }

        public Booking_Form_AR()
        {
            InitializeComponent();
            Reload();

        }
        void Reload()
        {
            Fill_Combo_Box();
            Fill_Table($"SELECT * FROM CR.Tables_Booking_Details ORDER BY [From]");
            if (Booking_Table.Rows.Count == 0)
                From_Date_Picker.Value = To_Date_Picker.Value = DateTime.Now;
            else
            {

                From_Date_Picker.Value = Convert.ToDateTime(Booking_Table.Rows.Cast<DataGridViewRow>().Min(t => Convert.ToDouble(t.Cells[2].Value)));
                To_Date_Picker.Value = Convert.ToDateTime(Booking_Table.Rows.Cast<DataGridViewRow>().Max(t => Convert.ToDouble(t.Cells[3].Value)));
            }

        }
        public void Fill_Combo_Box()
        {
            Table_Combo_Box.DataSource = null;
            Formatter.Check_Connection(conn);
            conn.Open();
            string sql = "SELECT [Number] FROM CR.Tables ORDER BY [Number]";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            dt2.Columns.Add("Number");
            DataRow row = dt2.NewRow();
            dt2.Rows.InsertAt(row, 0);
            row["Number"] = "All";
            da.Fill(dt);
            conn.Close();
            foreach (DataRow row2 in dt.Rows)
            {
                dt2.Rows.Add((int)row2[0]);
            }


            Table_Combo_Box.DataSource = dt2;
            Table_Combo_Box.DisplayMember = "Number";


        }



        void Fill_Table(string Query)
        {
            Formatter.Check_Connection(conn);
            SqlCommand Command = new SqlCommand(Query, conn);
            SqlDataAdapter da = new SqlDataAdapter(Command);
            DataTable dt = new DataTable();
            conn.Open();
            try
            {
                da.Fill(dt);
            }
            catch (Exception)
            {


            }




            conn.Close();
            Booking_Table.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                Booking_Table.Rows.Add((int)row[0], (string)row[1], (DateTime)row[2], (DateTime)row[3], (int)row[4], (string)row[5]);
            }
            try
            {
                Table_Croll_Bar.Maximum = Booking_Table.Rows.Count - 1;
            }
            catch { }
            Count_Value_Label.Text = $"{Booking_Table.Rows.Count}";
        }
        void Choose_Query()
        {
            if (!(Khayaal_SAHM.Formatter.Check_Payment_Date_Range(From_Date_Picker.Value, To_Date_Picker.Value)))
            {
                From_Date_Picker.Value = To_Date_Picker.Value;
                MessageBox.Show("Data Range Error Change The Date Range!!", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                string Table_No = Table_Combo_Box.Text;
                string Name = Formatter.String(Search_Text_Box.Text);

                string From = Khayaal_SAHM.Formatter.Date_Formating(From_Date_Picker.Value, "From_Payment"), To = Khayaal_SAHM.Formatter.Date_Formating(To_Date_Picker.Value, "To_Payment");
                if (Table_Combo_Box.Text == "All" && Search_Text_Box.Text == "")
                    Fill_Table($"SELECT * FROM CR.Tables_Booking_Details  WHERE[From] BETWEEN '{From}' AND '{To}' ORDER BY [From] ");
                else if (Table_Combo_Box.Text == "All" && Search_Text_Box.Text != "")
                    Fill_Table($"SELECT * FROM CR.Tables_Booking_Details  WHERE[From] BETWEEN '{From}' AND '{To}' AND [Name] LIKE '{Name}%' ORDER BY [From] ");
                else if (Table_Combo_Box.Text != "All" && Search_Text_Box.Text == "")
                    Fill_Table($"SELECT * FROM CR.Tables_Booking_Details  WHERE[From] BETWEEN '{From}' AND '{To}' AND [Table_No]={Table_No}  ORDER BY [From] ");
                else
                    Fill_Table($"SELECT * FROM CR.Tables_Booking_Details  WHERE[From] BETWEEN '{From}' AND '{To}' AND [Table_No]={Table_No}  AND [Name] LIKE '{Name}%'  ORDER BY [From] ");
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
                Table_Croll_Bar.Maximum = Booking_Table.Rows.Count - 1;

                Booking_Table.FirstDisplayedScrollingRowIndex = Booking_Table.Rows[e.NewValue].Index;
            }
            catch { }

        }

        private void Best_Seller_Table_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                Table_Croll_Bar.Maximum = Booking_Table.Rows.Count - 1;
            }
            catch { }
        }

        private void Best_Seller_Table_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            try
            {
                Table_Croll_Bar.Maximum = Booking_Table.Rows.Count - 1;
            }
            catch { }
        }

        private void Delete_Table_Combo_Box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Delete_Table_Text_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '\r'))

            {
                e.Handled = true;
            }

        }

        private void Delete_Table_Text_Box_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == '\r')
            {
                if (Delete_Table_Text_Box.Text != string.Empty)
                {
                    DialogResult r = System.Windows.Forms.MessageBox.Show("Are You Sure?", "Warning", MessageBoxButtons.YesNo);
                    if (DialogResult.Yes == r)
                    {
                        Formatter.Check_Connection(conn);
                        string Table = Delete_Table_Text_Box.Text;
                        string Query = $"DELETE FROM CR.Tables_Booking_Details WHERE [Table_No]= {Table} ;";
                        SqlCommand sqlCommand = new SqlCommand(Query, conn);
                        conn.Open();
                        try { sqlCommand.ExecuteNonQuery(); }
                        catch { MessageBox.Show(Table); }
                        sqlCommand = new SqlCommand($"DELETE FROM CR.Tables WHERE [Number]= {Table};", conn);
                        sqlCommand.ExecuteNonQuery();
                        conn.Close();
                        Delete_Table_Text_Box.Text = "";

                        Reload();
                        MessageBox.Show("Successfully Done!");
                    }

                }
            }
        }

        private void Add_Table_Button_Click(object sender, EventArgs e)
        {
            bool Inserted = true;
            DataTable Tables = new DataTable();
            if (ConnectionState.Open == conn.State)
            { conn.Close(); }
            SqlDataAdapter Get_Tables = new SqlDataAdapter("SELECT [Number] FROM CR.Tables ORDER BY [Number]", conn);
            conn.Open();
            Get_Tables.Fill(Tables);
            conn.Close();
            int TableNo = 1;
            foreach (DataRow row in Tables.Rows)
            {
                if ((int)row[0] != TableNo)
                {
                    if (ConnectionState.Open == conn.State)
                        conn.Close();
                    SqlCommand newtable = new SqlCommand($"INSERT INTO CR.Tables VALUES({TableNo});", conn);
                    conn.Open();
                    newtable.ExecuteNonQuery();
                    conn.Close();
                    this.Reload();
                    Inserted = false;
                    break;
                }
                else
                    TableNo++;
            }
            if (Inserted)
            {
                if (ConnectionState.Open == conn.State)
                    conn.Close();
                SqlCommand newtable = new SqlCommand($"INSERT INTO CR.Tables VALUES({TableNo});", conn);
                conn.Open();
                newtable.ExecuteNonQuery();
                conn.Close();
                this.Reload();
            }

        }

        private void Booking_Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = Booking_Table.Rows[e.RowIndex];
                int table = (int)row.Cells[0].Value;
                string name = (string)row.Cells[1].Value;
                string notes = (string)row.Cells[5].Value;
                string from = Formatter.Date_Formating((DateTime)row.Cells[2].Value);
                string to = Formatter.Date_Formating((DateTime)row.Cells[3].Value);
                int id = (int)row.Cells[4].Value;
                if (Booking_Table.Columns[e.ColumnIndex].Name == "Edit")
                {
                    Add_Edit_BG_Mdi_Form_AR form = new Add_Edit_BG_Mdi_Form_AR(name, from, to, table, id, notes);
                    form.MdiParent = this.Owner;
                    form.Referesh_Current_Form += (obj2, ef) =>
                    {
                        this.Reload();
                    };
                    form.ShowDialog();
                }
                else if (Booking_Table.Columns[e.ColumnIndex].Name == "Delete")
                {
                    try
                    {
                        string Query = $"DELETE CR.Tables_Booking_Details WHERE Id={id};\n";
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
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Add_Booking_Button_Click(object sender, EventArgs e)
        {
            Add_Edit_BG_Mdi_Form_AR form = new Add_Edit_BG_Mdi_Form_AR();
            form.MdiParent = this.Owner;
            form.Referesh_Current_Form += (obj, ef) =>
            {
                this.Reload();
            };
            form.ShowDialog();
        }
    }
}
