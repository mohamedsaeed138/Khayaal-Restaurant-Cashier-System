using FontAwesome.Sharp;
using Microsoft.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace Khayaal_SAHM.Main_Form_and_Children_Forms.Bills_Form_and_Mdi_Forms.Print
{
    public partial class Print_Bill : Form
    {
        public Print_Bill()
        {
            InitializeComponent();
        }

        private void Print_Bill_Load(object sender, EventArgs e)
        {
            //Restaurant_CafeDataSet report_ds = new Restaurant_CafeDataSet();
            //string connection_string = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\SAHM\\Khayaal_SAHM\\DataBase\\Restaurant_Cafe.mdf;Integrated Security=True";
            //string query = "SELECT CR.Bills.Table_No, CR.Bills.Cashier_User_Name, CR.Bills.Date, CR.Bills.Total, CR.Bills_Details.Qty, CR.Bills_Details.Unit_Price, CR.Bills_Details.Sub_Total, CR.Bills_Details.Name, CR.Bills_Details.Category       CR.Bills INNER JOIN           CR.Bills_Details ON CR.Bills.Serial_Number = CR.Bills_Details.Serial_No";
            //SqlConnection conne = new SqlConnection(connection_string);
            //SqlDataAdapter adp = new SqlDataAdapter(query, conne);
            // adp.Fill(report_ds, report_ds.Tables[0].TableName)  ;
            //ReportDataSource das = new ReportDataSource("BillReport", report_ds.Tables[0]);
            //this.reportViewer1.LocalReport.DataSources.Clear();
            //this.reportViewer1.LocalReport.DataSources.Add(das);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.LocalReport.ReportPath = "D:\\SAHM\\Khayaal_SAHM\\Main_Form and Children_Forms\\Bills_Form and Mdi_Forms\\Print\\Report1.rdlc";

            this.reportViewer1.RefreshReport();
        }
      
    }
}
