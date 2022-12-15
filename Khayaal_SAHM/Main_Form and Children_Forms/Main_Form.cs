using Khayaal_SAHM.Main_Form_and_Children_Forms.Home_Form_and_Mdi_Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Khayaal_SAHM.Main_Form_and_Children_Forms
{
    public partial class Main_Form : Form
    {

        private Form Current_Form;
        private Form Current_Child_Form;
        public Main_Form()
        {

            InitializeComponent();

            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private void Open_Child_form(Form Child_Form)
        {
            Current_Child_Form?.Close();
            Current_Child_Form = Child_Form;
            Child_Form.TopLevel = false;
            Child_Form.FormBorderStyle = FormBorderStyle.None;
            Child_Form.Dock = DockStyle.Fill;
            Panel_Child.Controls.Add(Child_Form);
            Child_Form.BringToFront();
            Child_Form.Show();

        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(241, 102, 103);

        }




        private void Btn_Exit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }


        private void Btn_Maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }




        private void Btn_Minimize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }

        }

        private void Home_OFF_Click(object sender, EventArgs e)
        {
            if (Home_OFF.Visible == true)
            {
                Home_ON.Visible = true;
                Home_OFF.Visible = false;
            }
            Open_Child_form(new Home_Form());
            if (Current_Form != Current_Child_Form)
            {
                if (Home_OFF.Visible == true)
                {
                    Home_ON.Visible = true;
                    Home_OFF.Visible = false;
                    Open_Child_form(new Home_Form());

                }
                if (Current_Form == new Home_Form()) ;
                return;

            }
        }
    }
}
