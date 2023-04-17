using System;
using System.Diagnostics;
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
            // string Mac_Address =Get_Mac_Address();

            if (IsRunning())
            {
                MessageBox.Show("Application is already running !");
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Loading_Screen_Form());


            //else
            //{
            //    MessageBox.Show("For  Activation Call OR Message us on WhatsApp +20 122 855 2872 للتفعيل اتصل او راسلنا ع واتس اب ");
            //}



        }

        private static bool IsRunning()
        {
            Process curr = Process.GetCurrentProcess();
            Process[] procs = Process.GetProcessesByName(curr.ProcessName);
            foreach (var p in procs)
            {
                if (p.Id != curr.Id && p.MainModule.FileName == curr.MainModule.FileName)
                    return true;
            }

            return false;
        }
        private static string Get_Mac_Address() => NetworkInterface
        .GetAllNetworkInterfaces()
        .Where(nic => nic.OperationalStatus == OperationalStatus.Up &&
        nic.NetworkInterfaceType !=
        NetworkInterfaceType.Loopback)
        .Select(nic => nic.GetPhysicalAddress().ToString())
        .FirstOrDefault();
    }
}
