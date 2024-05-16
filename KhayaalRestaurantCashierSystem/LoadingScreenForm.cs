using System;
using System.Threading;
using System.Windows.Forms;

namespace Khayaal
{
    public partial class LoadingScreenForm : Form
    {
        private double count = 0;
        public LoadingScreenForm()
        {
            InitializeComponent();
            var filename = $"{Environment.CurrentDirectory}\\Intro Video\\Last Intro.mp4";
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.URL = filename;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;

            if (count == 7)
            {
                axWindowsMediaPlayer1.Dispose();
                Thread Login_Start_Thread = new Thread(StartLoginForm);
                Login_Start_Thread.SetApartmentState(ApartmentState.STA);
                Login_Start_Thread.Start();
                Thread.Sleep(100);
                timer1.Enabled = false;

                this.Close();
            }
        }
        private static void StartLoginForm()
        {
            Application.Run(new Login_Form_and_Mdi_Forms.LoginForm());
        }
    }
}
