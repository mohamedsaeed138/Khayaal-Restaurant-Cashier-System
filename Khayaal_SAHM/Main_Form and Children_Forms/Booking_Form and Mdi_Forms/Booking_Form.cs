using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Khayaal_SAHM.Main_Form_and_Children_Forms.Booking_Form_and_Mdi_Forms
{
    public partial class Booking_Form : Form
    {
        static SqlConnection conn = new SqlConnection(Connection_String.Value);


        private void Search_Text_Box_TextChanged(object sender, EventArgs e)
        {
            Choose_Query();
        }

        public Booking_Form()
        {
            Reload();

        }
        void Reload()
        {
            this.Controls.Clear();
            InitializeComponent();

            Fill_Combo_Boxes();
            Fill_Table($"SELECT * FROM CR.Tables_Booking_Details ORDER BY [From]");
            From_Date_Picker.Value = new DateTime(2022, 1, 1);
        }
        public void Fill_Combo_Boxes()
        {
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

                Booking_Table.Rows.Add((int)row[0], (string)row[1], (DateTime)row[2], (DateTime)row[3], (int)row[4]);
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
                MessageBox.Show("Data Range Error Change The Date Range!!", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                From_Date_Picker.Value = To_Date_Picker.Value;


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
                    if (ConnectionState.Open == conn.State)
                        conn.Close();
                    string Table = Delete_Table_Text_Box.Text;
                    string Query = $"DELETE FROM CR.Tables_Booking_Details WHERE [Table_No]= {Table} ;";
                    SqlCommand sqlCommand = new SqlCommand(Query, conn);
                    conn.Open();
                    try { sqlCommand.ExecuteNonQuery(); }
                    catch { MessageBox.Show(Table); }
                    sqlCommand = new SqlCommand($"DELETE FROM CR.Tables WHERE [Number]= {Table};", conn);
                    sqlCommand.ExecuteNonQuery();
                    conn.Close();

                    Reload();
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
    }
}
