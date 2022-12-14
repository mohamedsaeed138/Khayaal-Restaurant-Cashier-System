using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Khayaal_SAHM.Main_Form_and_Children_Forms.Best_Seller_Form
{
    public partial class Best_Seller_Form : Form
    {
        static SqlConnection conn = new SqlConnection(Connection_String.Value);
        public Best_Seller_Form()
        {
            InitializeComponent();
            Fill_Combo_Box();
            Fill_Table();
        }
        public void Fill_Combo_Box()
        {
            conn.Open();
            string sql = "select Category from CR.Items GROUP BY Category";
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
        void Fill_Table(string Name = null, string Category = null, string From = null, string To = null)
        {

            SqlCommand Command;
            string Query;
            if (Category == null & From == null && To == null)
                Query = "SELECT [Name] as [Item],COUNT(NAME) as Quntity, [Category] From CR.Bills_Details GROUP BY Name ,Category ORDER BY Quntity DESC;";

            else if (Name == string.Empty)
                Query = $"SELECT[Name] as [Item],COUNT(NAME) as Quntity, [Category] From CR.Bills_Details WHERE [Category] = N'{Category}' and  Date BETWEEN {From} and {To} GROUP BY Name ,Category ORDER BY Quntity DESC;";
            else
                Query = $"SELECT[Name] as [Item],COUNT(NAME) as Quntity, [Category] From CR.Bills_Details WHERE Category = N'{Category}' and Name like '{Name}%' and Date BETWEEN {From} and {To} GROUP BY Name ,Category ORDER BY Quntity DESC;";
            conn.Open();
            Command = new SqlCommand(Query, conn);
            SqlDataAdapter da = new SqlDataAdapter(Command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            Best_Seller_Table.DataSource = dt.DataSet;
        }

    }
}
