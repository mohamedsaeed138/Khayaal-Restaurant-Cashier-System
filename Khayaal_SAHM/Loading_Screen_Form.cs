using System;
using System.Threading;
using System.Windows.Forms;

namespace Khayaal_SAHM
{
    public partial class Loading_Screen_Form : Form
    {
        private double count = 0;


        public Loading_Screen_Form()
        {
            InitializeComponent();
            string filename = $"{Environment.CurrentDirectory}\\Intro Video\\Last Intro.mp4";
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.URL = filename;

        }




        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;

            if (count == 7)
            {
                axWindowsMediaPlayer1.Dispose();
                Thread Login_Start_Thread = new Thread(Start_A_Login_Form);
                Login_Start_Thread.SetApartmentState(ApartmentState.STA);
                Login_Start_Thread.Start();
                Thread.Sleep(100);
                timer1.Enabled = false;

                this.Close();
            }
        }

        static void Start_A_Login_Form()
        {
            Application.Run(new Login_Form_and_Mdi_Forms.Login_Form());

        }

    }
}
