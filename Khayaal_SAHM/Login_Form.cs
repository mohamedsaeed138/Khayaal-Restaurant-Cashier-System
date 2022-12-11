using System.Data.SqlClient;
using System.Windows.Forms;
namespace SAHM_Version_ALPHA_0._1
{

    public partial class Login_Form : Form
    {
        SqlConnection LoginCon = new SqlConnection(Connection_String.Value);
        public Login_Form()
        {
            InitializeComponent();
        }
    }
}
