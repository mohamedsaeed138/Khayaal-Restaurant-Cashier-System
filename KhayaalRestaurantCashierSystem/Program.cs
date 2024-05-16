using System;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace Khayaal
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

            Application.Run(new LoadingScreenForm());
            

        }

        private static bool IsRunning()
        {
            Process current = Process.GetCurrentProcess();
            Process[] proccesses = Process.GetProcessesByName(current.ProcessName);
            return proccesses.Any(process =>
                process.Id != current.Id && process.MainModule.FileName == current.MainModule.FileName);
        }
        private static string GetMacAddress() => NetworkInterface
        .GetAllNetworkInterfaces()
        .Where(nic => nic.OperationalStatus == OperationalStatus.Up &&
        nic.NetworkInterfaceType !=
        NetworkInterfaceType.Loopback)
        .Select(nic => nic.GetPhysicalAddress().ToString())
        .FirstOrDefault();
    }
}
