using Khayaal_SAHM.Main_Form_and_Children_Forms.Credit_Form;
using Khayaal_SAHM.Main_Form_and_Children_Forms_AR.Bills_Form_and_Mdi_Forms_AR;
using Khayaal_SAHM.Main_Form_and_Children_Forms_AR.Booking_Form_and_Mdi_Forms_AR;
using Khayaal_SAHM.Main_Form_and_Children_Forms_AR.Home_Form_and_Mdi_Forms_AR;
using Khayaal_SAHM.Main_Form_and_Children_Forms_AR.Purchases_Form_and_Mdi_Forms_AR;
using Khayaal_SAHM.Main_Form_and_Children_Forms_AR.Raw_Materials_Form_and_Mdi_Forms_AR;
using Khayaal_SAHM.Main_Form_and_Children_Forms_AR.Relations_Form_and_Mdi_Forms_AR;
using Khayaal_SAHM.Properties;
using System;
using System.Windows.Forms;

namespace Khayaal_SAHM.Main_Form_and_Children_Forms_AR
{
    public partial class Main_Form_AR : Form
    {
        bool Cashier = false;
        private Form Current_Child_Form;
        public Main_Form_AR(bool cashier = false)
        {

            InitializeComponent();
            Cashier = cashier;
            Current_Child_Form?.Close();
            Current_Child_Form = new Home_Form_AR(Cashier);
            Current_Child_Form.TopLevel = false;
            Current_Child_Form.FormBorderStyle = FormBorderStyle.None;
            Current_Child_Form.Dock = DockStyle.Fill;
            Panel_Child.Controls.Add(Current_Child_Form);

            Current_Child_Form.Show();
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            if (Cashier)
                Purchases_Picture_Box.Enabled = false;
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
            if (Current_Child_Form.GetType() == typeof(Home_Form_AR))
                return;
            Turn_OFF_Side_Bar();
            Home_Picture_Box.Image = Resources.Home_ON_AR;
            Open_Child_form(new Home_Form_AR(Cashier));
        }
        void Turn_OFF_Side_Bar()
        {
            Home_Picture_Box.Image = Resources.Home_OFF_AR;
            Booking_Picture_Box.Image = Resources.Booking_OFF_AR;
            Raw_Picture_Box.Image = Resources.Raw_OFF_AR;
            Relations_Picture_Box.Image = Resources.Relations_OFF_AR;
            Bills_Picture_Box.Image = Resources.Bills_OFF_AR;
            Purchases_Picture_Box.Image = Resources.Purchases_OFF_AR;
            Best_Sales_Picture_Box.Image = Resources.Best_Sales_OFF_AR;
            Credit_Picture_Box.Image = Resources.Credit_OFF_AR;
        }

        private void Booking_Picture_Box_Click(object sender, EventArgs e)
        {
            if (Current_Child_Form.GetType() == typeof(Booking_Form_AR))
                return;
            Turn_OFF_Side_Bar();
            Booking_Picture_Box.Image = Resources.Booking_ON_AR;
            Open_Child_form(new Booking_Form_AR());

        }

        private void Raw_Picture_Box_Click(object sender, EventArgs e)
        {
            if (Current_Child_Form.GetType() == typeof(Raw_Materials_Form_AR))
                return;
            Turn_OFF_Side_Bar();
            Raw_Picture_Box.Image = Resources.Raw_ON_AR;
            Open_Child_form(new Raw_Materials_Form_AR(Cashier));
        }

        private void Relations_Picture_Box_Click(object sender, EventArgs e)
        {
            if (Current_Child_Form.GetType() == typeof(Relations_Form_AR))
                return;
            Turn_OFF_Side_Bar();
            Relations_Picture_Box.Image = Resources.Relations_ON_AR;
            Open_Child_form(new Relations_Form_AR(Cashier));
        }

        private void Bills_Picture_Box_Click(object sender, EventArgs e)
        {

            if (Current_Child_Form.GetType() == typeof(Bills_Form_AR))
                return;
            Turn_OFF_Side_Bar();
            Bills_Picture_Box.Image = Resources.Bills_ON_AR;
            Open_Child_form(new Bills_Form_AR(Cashier));
        }



        private void Purchases_Picture_Box_Click(object sender, EventArgs e)
        {
            if (Current_Child_Form.GetType() == typeof(Purchases_Form_AR))
                return;
            Turn_OFF_Side_Bar();
            Purchases_Picture_Box.Image = Resources.Purchases_ON_AR;
            Open_Child_form(new Purchases_Form_AR());
        }

        private void Best_Sales_Picture_Box_Click(object sender, EventArgs e)
        {
            if (Current_Child_Form.GetType() == typeof(Best_Sales_Form_AR.Best_Sales_Form_AR))
                return;
            Turn_OFF_Side_Bar();
            Best_Sales_Picture_Box.Image = Resources.Best_Sales_ON_AR;
            Open_Child_form(new Best_Sales_Form_AR.Best_Sales_Form_AR());
        }

        private void Credit_Picture_Box_Click(object sender, EventArgs e)
        {
            if (Current_Child_Form.GetType() == typeof(Credit_Form))
                return;
            Turn_OFF_Side_Bar();
            Credit_Picture_Box.Image = Resources.Credit_ON_AR;
            Open_Child_form(new Credit_Form());
        }
    }
}
