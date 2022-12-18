using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace Khayaal_SAHM.Main_Form_and_Children_Forms.Bills_Form_and_Mdi_Forms.Print__Form
{
    public partial class Print_Form : Form
    {
        public Print_Form(int serialno)
        {
            this.serialno = serialno;
            InitializeComponent();
        }
        System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(Connection_String.Value);
        int serialno;
        private void Print_Form_Load(object sender, EventArgs e)
        {
            Formatter.Check_Connection(conn);
            System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter($"SELECT        CR.Bills.Serial_Number AS Expr1, CR.Bills.Date AS Expr2, CR.Bills.Cashier_User_Name AS Expr3, CR.Bills.*, CR.Bills.Total AS Expr4, CR.Bills_Details.Name, CR.Bills_Details.Qty, CR.Bills_Details.Unit_Price, \r\n                         CR.Bills_Details.Sub_Total\r\nFROM            CR.Bills INNER JOIN\r\n                         CR.Bills_Details ON CR.Bills.Serial_Number = CR.Bills_Details.Serial_No  WHERE CR.Bills.Serial_Number={serialno} ;", conn);
            DataSet ds = new DataSet();

            da.Fill(ds, "DataTable1");
            ReportDataSource DS = new ReportDataSource("DataSet", ds.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(DS);
            reportViewer1.LocalReport.ReportPath = @"E:\SAHM\Khayaal_SAHM\Main_Form and Children_Forms\Bills_Form and Mdi_Forms\Print _Form\Print_Report.rdlc";
            this.reportViewer1.RefreshReport();

        }
    }
}
