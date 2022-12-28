using Khayaal_SAHM.Main_Form_and_Children_Forms.Bills_Form_and_Mdi_Forms;
using Khayaal_SAHM.Main_Form_and_Children_Forms.Booking_Form_and_Mdi_Forms;
using Khayaal_SAHM.Main_Form_and_Children_Forms.Home_Form_and_Mdi_Forms;
using Khayaal_SAHM.Main_Form_and_Children_Forms.Purchases_Form_and_Mdi_Forms;
using Khayaal_SAHM.Main_Form_and_Children_Forms.Raw_Materials_Form_and_Mdi_Forms;
using Khayaal_SAHM.Main_Form_and_Children_Forms.Relations_Form_and_Mdi_Forms;
using Khayaal_SAHM.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Khayaal_SAHM.Main_Form_and_Children_Forms
{
    public partial class Main_Form : Form
    {
        private Form Current_Child_Form;
        public Main_Form()
        {

            InitializeComponent();

            Current_Child_Form?.Close();
            Current_Child_Form = new Home_Form();
            Current_Child_Form.TopLevel = false;
            Current_Child_Form.FormBorderStyle = FormBorderStyle.None;
            Current_Child_Form.Dock = DockStyle.Fill;
            Panel_Child.Controls.Add(Current_Child_Form);
            Current_Child_Form.BringToFront();
            Current_Child_Form.Show();
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
            WindowState = FormWindowState.Minimized;
        }

        private void Home_Picture_Box_Click(object sender, EventArgs e)
        {
            if (Current_Child_Form.GetType() == typeof(Home_Form))
                return;
            Turn_OFF_Side_Bar();
            Home_Picture_Box.Image = Resources.Home_ON;
            Open_Child_form(new Home_Form());
        }
        void Turn_OFF_Side_Bar()
        {
            Home_Picture_Box.Image = Resources.Home_OFF;
            Booking_Picture_Box.Image = Resources.Booking_OFF;
            Raw_Picture_Box.Image = Resources.Raw_OFF;
            Relations_Picture_Box.Image = Resources.Relations_OFF;
            Bills_Picture_Box.Image = Resources.Bills_OFF;
            Purchases_Picture_Box.Image = Resources.Purchases_OFF;
            Best_Sales_Picture_Box.Image = Resources.Best_Sales_OFF;
            Credit_Picture_Box.Image = Resources.Credit_OFF;
        }

        private void Booking_Picture_Box_Click(object sender, EventArgs e)
        {
            if (Current_Child_Form.GetType() == typeof(Booking_Form))
                return;
            Turn_OFF_Side_Bar();
            Booking_Picture_Box.Image = Resources.Booking_ON;
            Open_Child_form(new Booking_Form());

        }

        private void Raw_Picture_Box_Click(object sender, EventArgs e)
        {
            if (Current_Child_Form.GetType() == typeof(Raw_Materials_Form))
                return;
            Turn_OFF_Side_Bar();
            Raw_Picture_Box.Image = Resources.Raw_ON;
            Open_Child_form(new Raw_Materials_Form());
        }

        private void Relations_Picture_Box_Click(object sender, EventArgs e)
        {
            if (Current_Child_Form.GetType() == typeof(Relations_Form))
                return;
            Turn_OFF_Side_Bar();
            Relations_Picture_Box.Image = Resources.Relations_ON;
            Open_Child_form(new Relations_Form());
        }

        private void Bills_Picture_Box_Click(object sender, EventArgs e)
        {

            if (Current_Child_Form.GetType() == typeof(Bills_Form))
                return;
            Turn_OFF_Side_Bar();
            Bills_Picture_Box.Image = Resources.Bills_ON;
            Open_Child_form(new Bills_Form());
        }



        private void Purchases_Picture_Box_Click_1(object sender, EventArgs e)
        {
            if (Current_Child_Form.GetType() == typeof(Purchases_Form))
                return;
            Turn_OFF_Side_Bar();
            Purchases_Picture_Box.Image = Resources.Purchases_ON;
            Open_Child_form(new Purchases_Form());
        }

        private void Best_Sales_Picture_Box_Click(object sender, EventArgs e)
        {
            if (Current_Child_Form.GetType() == typeof(Best_Sales_Form.Best_Sales_Form))
                return;
            Turn_OFF_Side_Bar();
            Best_Sales_Picture_Box.Image = Resources.Best_Sales_ON;
            Open_Child_form(new Best_Sales_Form.Best_Sales_Form());
        }

        private void Credit_Picture_Box_Click(object sender, EventArgs e)
        {
            if (Current_Child_Form.GetType() == typeof(Credit_Form.Credit_Form))
                return;
            Turn_OFF_Side_Bar();
            Credit_Picture_Box.Image = Resources.Credit_ON;
            Open_Child_form(new Credit_Form.Credit_Form());
        }
    }
}
