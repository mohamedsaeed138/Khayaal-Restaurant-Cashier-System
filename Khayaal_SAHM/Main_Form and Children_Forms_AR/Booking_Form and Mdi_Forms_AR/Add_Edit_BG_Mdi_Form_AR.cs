using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Khayaal_SAHM.Main_Form_and_Children_Forms_AR.Booking_Form_and_Mdi_Forms_AR
{
    public partial class Add_Edit_BG_Mdi_Form_AR : Form
    {
        int id;
        bool Add = true;
        public event EventHandler Referesh_Current_Form = null;


        static SqlConnection conn = new SqlConnection(Connection_String.Value);

        public Add_Edit_BG_Mdi_Form_AR()
        {
            Reload();
            To_Time_Picker.Text = DateTime.Now.AddHours(2).ToString();
            From_Time_Picker.Text = DateTime.Now.AddHours(1).ToString();
            From_Date_Picker.Text = DateTime.Now.ToString();
            To_Date_Picker.Text = DateTime.Now.ToString();
        }
        public Add_Edit_BG_Mdi_Form_AR(string name, string From, string To, int table, int id, string notes)
        {
            Add = false;
            Reload();
            this.id = id;
            Customer_Name_Text_Box.Text = name;
            Table_Combo_Box.Text = table.ToString();
            Notes_Text_Box.Text = notes;
            if (DateTime.Parse(To) > DateTime.Now)
            {
                To_Date_Picker.Text = DateTime.Parse(To).ToString("MM/dd/yyyy");
                To_Time_Picker.Text = DateTime.Parse(To).ToString("HH:mm:ss");
                From_Date_Picker.Text = DateTime.Parse(From).ToString("MM/dd/yyyy");
                From_Time_Picker.Text = DateTime.Parse(From).ToString("HH:mm:ss");


            }
            else
            {
                To_Time_Picker.Text = DateTime.Now.AddHours(2).ToString();
                From_Time_Picker.Text = DateTime.Now.AddHours(1).ToString();
                From_Date_Picker.Text = DateTime.Now.ToString();
                To_Date_Picker.Text = DateTime.Now.ToString();

            }
            Add_Booking_Button.Text = "تعديل";
        }

        void Reload()
        {
            InitializeComponent();
            Fill_Combo_Box();
        }

        private void Add_RMF_Mdi_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referesh_Current_Form?.Invoke(this, e);
        }
        private void Add_Edit_RMF_Mdi_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referesh_Current_Form?.Invoke(this, e);
        }

        public void Fill_Combo_Box()
        {

            Formatter.Check_Connection(conn);
            conn.Open();
            string sql = "SELECT [Number] FROM CR.Tables ORDER BY [Number]";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            Table_Combo_Box.DataSource = dt;
            Table_Combo_Box.DisplayMember = "Number";


        }
        private void Add_Booking_Button_Click(object sender, EventArgs e)
        {
            string From = Formatter.Date_Formating(From_Date_Picker.Value, "Normal", From_Time_Picker.Value);
            string To = Formatter.Date_Formating(To_Date_Picker.Value, "Normal", To_Time_Picker.Value);


            if (DateTime.Parse(From) < DateTime.Now)
            {
                MessageBox.Show("!أدخل تاريخ حديث", "!غير التاريخ");
                return;
            }
            int table = Int32.Parse(Table_Combo_Box.Text);
            if (Check_Intersections(DateTime.Parse(From), DateTime.Parse(To), table))
            {

                string Name = Formatter.String(Customer_Name_Text_Box.Text);
                string Notes = Formatter.String(Notes_Text_Box.Text);
                Formatter.Check_Connection(conn);
                if (Add)
                {





                    Formatter.Check_Connection(conn);
                    string Query = $"INSERT INTO CR.Tables_Booking_Details VALUES({table},N'{Name}','{From}','{To}',N'{Notes}');";
                    SqlCommand Insert_Query = new SqlCommand(Query, conn);
                    try
                    {

                        Formatter.Check_Connection(conn);
                        conn.Open();

                        Insert_Query.ExecuteNonQuery();

                        conn.Close();


                        MessageBox.Show("تمت العملية بنجاح");
                        Customer_Name_Text_Box.Text = "";

                    }

                    catch
                    {
                        MessageBox.Show("!!هناك تعارض في الحجوزات", "!غير التاريخ");

                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                else
                {

                    string Query = $"UPDATE CR.Tables_Booking_Details SET [Name]=N'{Name}',[From]='{From}',[To]='{To}' ,[Notes]=N'{Notes}'  WHERE Id={id};";
                    SqlCommand Update_Query = new SqlCommand(Query, conn);
                    try
                    {


                        Formatter.Check_Connection(conn);
                        conn.Open();

                        Update_Query.ExecuteNonQuery();

                        conn.Close();
                        this.Close();

                        MessageBox.Show("تمت العملية بنجاح");
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                    finally
                    {
                        conn.Close();
                    }


                }
            }



        }
        private bool Check_Intersections(DateTime From, DateTime To, int Table)
        {
            string Query = $"SELECT [Name],[From],[To] FROM CR.Tables_Booking_Details WHERE Table_No={Table} AND NOT(('{From}' <= [From] AND '{To}'<=[From]) OR( '{From}' >=[To] AND '{To}' >=[To] ));";
            string From_String = Formatter.Date_Formating(From);
            string To_String = Formatter.Date_Formating(To);
            Formatter.Check_Connection(conn);
            DataTable Bookings = new DataTable();
            if (!Add)
                Query = $"SELECT [Name],[From],[To] FROM CR.Tables_Booking_Details WHERE Id!={id} AND Table_No={Table} AND NOT(('{From}' <= [From] AND '{To}'<=[From]) OR( '{From}' >=[To] AND '{To}' >=[To] ));";

            SqlDataAdapter da = new SqlDataAdapter(Query, conn);
            conn.Open();
            da.Fill(Bookings);
            conn.Close();
            if (Bookings.Rows.Count > 0)
            {
                string message = "هناك تعارض في الحجوزات!!\n";
                foreach (DataRow row in Bookings.Rows)
                {
                    message += $"الاسم: {(string)row[0]}, من: {(DateTime)row[1]}, إلى:{(DateTime)row[2]}\n";
                }
                MessageBox.Show(message, "غير التاريخ!", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                return false;
            }

            return true;
        }


        private void Notes_Text_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '.' && e.KeyChar != ',' && e.KeyChar != '(' && e.KeyChar != ')' && e.KeyChar != ' ' || (Notes_Text_Box.Text.Length >= 100 && e.KeyChar != 8))
          || (e.KeyChar == ' ' && Notes_Text_Box.Text.Length == 0))

            {
                e.Handled = true;
            }

        }

        private void Customer_Name_Text_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '.' && e.KeyChar != ',' && e.KeyChar != '(' && e.KeyChar != ')' && e.KeyChar != ' ' || (Customer_Name_Text_Box.Text.Length >= 50 && e.KeyChar != 8))
           || (e.KeyChar == ' ' && Customer_Name_Text_Box.Text.Length == 0))

            {
                e.Handled = true;
            }
        }

        void Check_Date_Range()
        {
            string From = Formatter.Date_Formating(From_Date_Picker.Value, "Normal", From_Time_Picker.Value);
            string To = Formatter.Date_Formating(To_Date_Picker.Value, "Normal", To_Time_Picker.Value);

            if (DateTime.Parse(From) > DateTime.Parse(To))
            {
                From_Time_Picker.Value = To_Time_Picker.Value;
                From_Date_Picker.Value = To_Date_Picker.Value;

                MessageBox.Show("!! خطأ في المدي الزمني , قم بتغييره ", "!! خطأ");

            }
        }
        private void From_Date_Picker_ValueChanged(object sender, EventArgs e)
        {
            Check_Date_Range();
        }
        private void From_Time_Picker_ValueChanged(object sender, EventArgs e)
        {
            Check_Date_Range();
        }

        private void To_Date_Picker_ValueChanged(object sender, EventArgs e)
        {
            Check_Date_Range();
        }

        private void To_Time_Picker_ValueChanged(object sender, EventArgs e)
        {
            Check_Date_Range();
        }


    }
}
