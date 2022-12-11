using System.Data.SqlClient;
using System.Windows.Forms;
namespace Khayaal_SAHM
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
