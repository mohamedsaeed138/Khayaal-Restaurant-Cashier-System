using Microsoft.Reporting.WinForms;
using System.Windows.Forms;
using Khayaal.Main_Form_and_Children_Forms.Bills_Form_and_Mdi_Forms.Print__Form;

namespace Khayaal.Main_Form_and_Children_Forms.Bills_Form_and_Mdi_Forms.Print_Form
{
    public partial class Print_Form : Form
    {
        System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(ConnectionString.Value);
        int serialno;
        public Print_Form(int serialno = -1)
        {
            this.serialno = serialno;
            string Query;
            if (this.serialno != -1)
                Query = $"SELECT        CR.Bills_Details.Name, CR.Bills_Details.Sub_Total, CR.Bills_Details.Unit_Price, CR.Bills_Details.Qty, CR.Bills.Serial_Number, CR.Bills.Date, CR.Bills.Cashier_User_Name, CR.Bills.Total\r\nFROM            CR.Bills INNER JOIN\r\n                         CR.Bills_Details ON CR.Bills.Serial_Number = CR.Bills_Details.Serial_No   WHERE CR.Bills.Serial_Number={serialno} ;";
            else
                Query = $"SELECT        CR.Bills_Details.Name, CR.Bills_Details.Sub_Total, CR.Bills_Details.Unit_Price, CR.Bills_Details.Qty, CR.Bills.Serial_Number, CR.Bills.Date, CR.Bills.Cashier_User_Name, CR.Bills.Total\r\nFROM         CR.Bills INNER JOIN\r\n                         CR.Bills_Details ON CR.Bills.Serial_Number = CR.Bills_Details.Serial_No         WHERE CR.Bills.Serial_Number= CR.Get_Last_Bill_Serial() ;";



            InitializeComponent();

            Formatter.CheckConnection(conn);
            System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter(Query, conn);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds, "DataTable1");
            }
            catch { }

            ReportDataSource DS = new ReportDataSource("DataSet1", ds.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(DS);
            reportViewer1.LocalReport.ReportPath = ReportPath.Value;
            this.reportViewer1.RefreshReport();
        }






    }
}
