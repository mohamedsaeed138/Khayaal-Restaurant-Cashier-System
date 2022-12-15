using Khayaal_SAHM.Main_Form_and_Children_Forms.Best_Seller_Form;
using Khayaal_SAHM.Main_Form_and_Children_Forms.Bills_Form_and_Mdi_Forms;
using Khayaal_SAHM.Main_Form_and_Children_Forms.Booking_Form_and_Mdi_Forms;
using Khayaal_SAHM.Main_Form_and_Children_Forms.Home_Form_and_Mdi_Forms;
using Khayaal_SAHM.Main_Form_and_Children_Forms.Purchases_Form_and_Mdi_Forms;
using Khayaal_SAHM.Main_Form_and_Children_Forms.Raw_Materials_Form_and_Mdi_Forms;
using Khayaal_SAHM.Main_Form_and_Children_Forms.Relations_Form_and_Mdi_Forms;
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
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }

        }

    

      

       

      

       

       

      

       

        private void Home_OFF_Click(object sender, EventArgs e)
        {
            Open_Child_form(new Home_Form());
            Booking_OFF.Visible = true;
            Booking_OFF.BringToFront();
            Raw_OFF.Visible = true;
            Raw_OFF.BringToFront();
            Relations_OFF.Visible = true;
            Relations_OFF.BringToFront();
            Bills_OFF.Visible = true;
            Bills_OFF.BringToFront();
            Purchase_OFF.Visible = true;
            Purchase_OFF.BringToFront();
            Best_Sales_OFF.Visible = true;
            Best_Sales_OFF.BringToFront();
            Credit_OFF.Visible = true;
            Credit_OFF.BringToFront();
            if (Current_Form != Current_Child_Form)
            {
                if (Home_OFF.Visible == true)
                {
                    Home_ON.Visible = true;
                    Home_OFF.Visible = false;

                }
                if (Current_Form == new Home_Form()) ;
                return;

            }
        }

        private void Booking_OFF_Click_1(object sender, EventArgs e)
        {
            Open_Child_form(new Booking_Form());
            Home_OFF.Visible = true;
            Home_OFF.BringToFront();
            Raw_OFF.Visible = true;
            Raw_OFF.BringToFront();
            Relations_OFF.Visible = true;
            Relations_OFF.BringToFront();
            Bills_OFF.Visible = true;
            Bills_OFF.BringToFront();
            Purchase_OFF.Visible = true;
            Purchase_OFF.BringToFront();
            Best_Sales_OFF.Visible = true;
            Best_Sales_OFF.BringToFront();
            Credit_OFF.Visible = true;
            Credit_OFF.BringToFront();
            if (Current_Form != Current_Child_Form)
            {
                if (Booking_OFF.Visible == true)
                {
                    Booking_ON.Visible = true;
                    Booking_OFF.Visible = false;

                }
                if (Current_Form == new Booking_Form()) ;
                return;

            }
        }

        private void Raw_OFF_Click_1(object sender, EventArgs e)
        {
            if (Raw_OFF.Visible == true)
            {
                Raw_ON.Visible = true;
                Raw_OFF.Visible = false;
            }
            Open_Child_form(new Raw_Materials_Form());
            Booking_OFF.Visible = true;
            Booking_OFF.BringToFront();
            Home_OFF.Visible = true;
            Home_OFF.BringToFront();
            Relations_OFF.Visible = true;
            Relations_OFF.BringToFront();
            Bills_OFF.Visible = true;
            Bills_OFF.BringToFront();
            Purchase_OFF.Visible = true;
            Purchase_OFF.BringToFront();
            Best_Sales_OFF.Visible = true;
            Best_Sales_OFF.BringToFront();
            Credit_OFF.Visible = true;
            Credit_OFF.BringToFront();
            if (Current_Form != Current_Child_Form)
            {
                if (Raw_OFF.Visible == true)
                {
                    Raw_ON.Visible = true;
                    Raw_OFF.Visible = false;

                }
                if (Current_Form == new Raw_Materials_Form()) ;
                return;

            }
        }

        private void Relations_OFF_Click_1(object sender, EventArgs e)
        {
            if (Relations_OFF.Visible == true)
            {
                Relations_ON.Visible = true;
                Relations_OFF.Visible = false;
            }
            Open_Child_form(new Relations_Form());
            Booking_OFF.Visible = true;
            Booking_OFF.BringToFront();
            Raw_OFF.Visible = true;
            Raw_OFF.BringToFront();
            Home_OFF.Visible = true;
            Home_OFF.BringToFront();
            Bills_OFF.Visible = true;
            Bills_OFF.BringToFront();
            Purchase_OFF.Visible = true;
            Purchase_OFF.BringToFront();
            Best_Sales_OFF.Visible = true;
            Best_Sales_OFF.BringToFront();
            Credit_OFF.Visible = true;
            Credit_OFF.BringToFront();
            if (Current_Form != Current_Child_Form)
            {
                if (Relations_OFF.Visible == true)
                {
                    Relations_ON.Visible = true;
                    Relations_OFF.Visible = false;

                }
                if (Current_Form == new Relations_Form()) ;
                return;

            }
        }

        private void Bills_OFF_Click_1(object sender, EventArgs e)
        {
            if (Bills_OFF.Visible == true)
            {
                Bills_ON.Visible = true;
                Bills_OFF.Visible = false;
            }
            Open_Child_form(new Bills_Form());
            Booking_OFF.Visible = true;
            Booking_OFF.BringToFront();
            Raw_OFF.Visible = true;
            Raw_OFF.BringToFront();
            Relations_OFF.Visible = true;
            Relations_OFF.BringToFront();
            Home_OFF.Visible = true;
            Home_OFF.BringToFront();
            Purchase_OFF.Visible = true;
            Purchase_OFF.BringToFront();
            Best_Sales_OFF.Visible = true;
            Best_Sales_OFF.BringToFront();
            Credit_OFF.Visible = true;
            Credit_OFF.BringToFront();
            if (Current_Form != Current_Child_Form)
            {
                if (Bills_OFF.Visible == true)
                {
                    Bills_ON.Visible = true;
                    Bills_OFF.Visible = false;

                }
                if (Current_Form == new Bills_Form()) ;
                return;

            }
        }

        private void Purchase_OFF_Click_1(object sender, EventArgs e)
        {
            if (Bills_OFF.Visible == true)
            {
                Bills_ON.Visible = true;
                Bills_OFF.Visible = false;
            }
            Open_Child_form(new Purchases_Form());
            Booking_OFF.Visible = true;
            Booking_OFF.BringToFront();
            Raw_OFF.Visible = true;
            Raw_OFF.BringToFront();
            Relations_OFF.Visible = true;
            Relations_OFF.BringToFront();
            Bills_OFF.Visible = true;
            Bills_OFF.BringToFront();
            Home_OFF.Visible = true;
            Home_OFF.BringToFront();
            Best_Sales_OFF.Visible = true;
            Best_Sales_OFF.BringToFront();
            Credit_OFF.Visible = true;
            Credit_OFF.BringToFront();
            if (Current_Form != Current_Child_Form)
            {
                if (Purchase_OFF.Visible == true)
                {
                    Purchase_ON.Visible = true;
                    Purchase_OFF.Visible = false;

                }
                if (Current_Form == new Purchases_Form()) ;
                return;

            }
        }

        private void Best_Sales_OFF_Click_1(object sender, EventArgs e)
        {
            if (Best_Sales_OFF.Visible == true)
            {
                Best_Sales_ON.Visible = true;
                Best_Sales_OFF.Visible = false;
            }
            Open_Child_form(new Best_Sales_Form());
            Booking_OFF.Visible = true;
            Booking_OFF.BringToFront();
            Raw_OFF.Visible = true;
            Raw_OFF.BringToFront();
            Relations_OFF.Visible = true;
            Relations_OFF.BringToFront();
            Bills_OFF.Visible = true;
            Bills_OFF.BringToFront();
            Purchase_OFF.Visible = true;
            Purchase_OFF.BringToFront();
            Home_OFF.Visible = true;
            Home_OFF.BringToFront();
            Credit_OFF.Visible = true;
            Credit_OFF.BringToFront();
            if (Current_Form != Current_Child_Form)
            {
                if (Best_Sales_OFF.Visible == true)
                {
                    Best_Sales_ON.Visible = true;
                    Best_Sales_OFF.Visible = false;

                }
                if (Current_Form == new Best_Sales_Form()) ;
                return;

            }
        }

        private void Credit_OFF_Click_1(object sender, EventArgs e)
        {
            if (Credit_OFF.Visible == true)
            {
                Credit_ON.Visible = true;
                Credit_OFF.Visible = false;
            }
            Open_Child_form(new Credit_Form.Credit_Form());
            Booking_OFF.Visible = true;
            Booking_OFF.BringToFront();
            Raw_OFF.Visible = true;
            Raw_OFF.BringToFront();
            Relations_OFF.Visible = true;
            Relations_OFF.BringToFront();
            Bills_OFF.Visible = true;
            Bills_OFF.BringToFront();
            Purchase_OFF.Visible = true;
            Purchase_OFF.BringToFront();
            Best_Sales_OFF.Visible = true;
            Best_Sales_OFF.BringToFront();
            Home_OFF.Visible = true;
            Home_OFF.BringToFront();
            if (Current_Form != Current_Child_Form)
            {
                if (Credit_OFF.Visible == true)
                {
                    Credit_ON.Visible = true;
                    Credit_OFF.Visible = false;

                }
                if (Current_Form == new Credit_Form.Credit_Form()) ;
                return;

            }
        }

        private void Main_Form_Shown(object sender, EventArgs e)
        {
            
        }
    }
}
