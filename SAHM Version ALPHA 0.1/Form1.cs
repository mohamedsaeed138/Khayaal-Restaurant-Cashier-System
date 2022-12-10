using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAHM_Version_ALPHA_0._1
{
    public partial class Loading_Screen : Form
    {
        

        public Loading_Screen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval= 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                timer1.Interval += 1000;

                if(timer1.Interval > 3000)
                {
                    timer1.Stop();
                    LoginS loginS = new LoginS();
                    loginS.Show();
                    this.Hide();
                }
            }catch(Exception)
            {
                return;
            }
        }
    }
}
