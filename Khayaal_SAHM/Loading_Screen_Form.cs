using System;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace Khayaal_SAHM
{
    public partial class Loading_Screen_Form : Form
    {
        private double count = 0;
        SoundPlayer Intro = new SoundPlayer(@"C:\Intro_Music.wav");

        public Loading_Screen_Form()
        {
            InitializeComponent();

            Intro.Play();
        }




        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if (count == 5)
            {
                pictureBox1.Dispose();
            }
            else if (count == 7)
            {
                Thread Login_Start_Thread = new Thread(Start_A_Login_Form);
                Login_Start_Thread.SetApartmentState(ApartmentState.STA);
                Login_Start_Thread.Start();
                Thread.Sleep(100);
                timer1.Enabled = false;
                Intro.Stop();
                this.Close();
            }
        }

        static void Start_A_Login_Form()
        {
            Application.Run(new Login_Form());

        }

    }
}
