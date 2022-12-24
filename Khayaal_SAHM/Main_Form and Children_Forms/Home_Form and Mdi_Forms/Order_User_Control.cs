using System;
using System.Drawing;
using System.Windows.Forms;

namespace Khayaal_SAHM.Main_Form_and_Children_Forms.Home_Form_and_Mdi_Forms
{
    public partial class Order_User_Control : UserControl
    {
        private int id;
        private string name;
        private double price;
        private int qty;
        private Image image;
        private double sub_total;
        public int Id { get { return id; } set { id = value; } }
        public new string Name { get { return name; } set { name = value; Name_Label.Text = value; } }
        public double Price { get { return price; } set { price = value; Price_Label.Text = $"{value}"; } }
        public int Qty { get { return qty; } set { qty = value; Qty_Label.Text = $"{value}"; } }
        public double Sub_Total { get { return sub_total; } set { sub_total = value; Sub_Total_Label.Text = $"{value}"; } }

        public Image Image { get { return image; } set { image = value; Image_Picture_Box.Image = value; } }

        public event EventHandler Increase_Event = null;
        public event EventHandler Decrease_Event = null;
        public event EventHandler Remove_Event = null;
        public Order_User_Control()
        {
            InitializeComponent();
        }

        private void Increase_Button_Click(object sender, EventArgs e)
        {
            Increase_Event?.Invoke(this, e);
        }

        private void Decrease_Button_Click(object sender, EventArgs e)
        {
            Decrease_Event?.Invoke(this, e);
        }

        private void Remove_Button_Click(object sender, EventArgs e)
        {
            Remove_Event?.Invoke(this, e);
        }
    }
}
