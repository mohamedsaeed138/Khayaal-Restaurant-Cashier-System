using Khayaal_SAHM.Main_Form_and_Children_Forms;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Khayaal_SAHM
{
    public partial class Loading_Screen_Form : Form
    {


        public Loading_Screen_Form()
        {
            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                timer1.Interval += 1000;

                if (timer1.Interval > 3000)
                {
                    timer1.Stop();

                    Thread Login_Start_Thread = new Thread(Start_A_Login_Form);
                    Login_Start_Thread.SetApartmentState(ApartmentState.STA);
                    Login_Start_Thread.Start();
                    Thread.Sleep(100);
                    this.Close();
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        static void Start_A_Login_Form()
        {
            Application.Run(new Main_Form());
        }

    }
}
