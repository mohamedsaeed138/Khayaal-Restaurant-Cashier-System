using System;
using System.Linq;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace Khayaal_SAHM
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string Mac_Address = NetworkInterface
.GetAllNetworkInterfaces()
.Where(nic => nic.OperationalStatus == OperationalStatus.Up && nic.NetworkInterfaceType != NetworkInterfaceType.Loopback)
.Select(nic => nic.GetPhysicalAddress().ToString())
.FirstOrDefault();
            if (DateTime.Now < new DateTime(2023, 2, 23)/*&& Mac_Address== "" */ )
            {

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                Application.Run(new Login_Form_and_Mdi_Forms.Login_Form());
            }
            else
            {
                MessageBox.Show("For  Activation \nCall +201228552872 ");
            }



        }

    }
}
