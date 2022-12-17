using System;
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Loading_Screen_Form());
            Application.Run(new Loading_Screen_Form());
        }

    }
}
