using System;
using System.Drawing;
using System.Windows.Forms;

namespace Khayaal_SAHM.Main_Form_and_Children_Forms.Home_Form_and_Mdi_Forms
{
    public partial class Item_User_Control : UserControl
    {
        private int id;
        private string name;
        private string category;
        private string description;
        private double price;
        private Image image;
        private bool available;
        public int Id { get { return id; } set { id = value; } }
        public new string Name { get { return name; } set { name = value; Name_Label.Text = value; } }
        public string Category { get { return category; } set { category = value; } }
        public string Description { get { return description; } set { description = value; } }
        public double Price { get { return price; } set { price = value; Price_Label.Text = $"{value}"; } }
        public Image Image { get { return image; } set { image = value; Image_Picture_Box.Image = value; } }
        public bool Available { get { return available; } set { available = value; } }
        public event EventHandler Add_Event = null;
        public event EventHandler Edit_Event = null;
        public event EventHandler Remove_Event = null;
        public Item_User_Control()
        {
            InitializeComponent();
        }

        public override string ToString()
        {
            return $"Name : {Name}";
        }

        private void Add_To_Order_Buttton_Click(object sender, System.EventArgs e)
        {
            Add_Event?.Invoke(this, e);
        }

        private void Edit_Buttton_Click(object sender, System.EventArgs e)
        {
            Edit_Event?.Invoke(this, e);
        }

        private void Remove_Buttton_Click(object sender, System.EventArgs e)
        {
            Add_Event?.Invoke(this, e);
        }
    }
}
