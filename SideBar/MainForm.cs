using FontAwesome.Sharp;
namespace SideBar
{
    public partial class MainForm : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public MainForm()
        {
            InitializeComponent();
            leftBorderBtn=new Panel();
            leftBorderBtn.Size = new Size(7,50);
            panelMenu.Controls.Add(leftBorderBtn);
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            
        }
       



        //methods
        private void ActivateBtn(object SenderBtn,Color color)
        {
            if (SenderBtn != null)
            {
                DisableBtn();
                currentBtn = (IconButton)SenderBtn;
                currentBtn.BackColor = Color.FromArgb(37,36,81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign=ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation=TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location=new Point(0,currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }
        private void DisableBtn()
        {
            if (currentBtn != null)
            {
                
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.IndianRed;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Indigo;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            if (childForm == null)
            {
                currentChildForm.Close();   
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock= DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            Homelabel.Text=childForm.Text;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnOrder_Click_1(object sender, EventArgs e)
        {
            ActivateBtn(sender,Color.Khaki);
            OpenChildForm(new OrderForm());
        }

        private void BtnBooking_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, Color.Honeydew);
            OpenChildForm(new Booking());

        }

        private void BtnItems_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, Color.DarkRed);
            OpenChildForm(new Items());

        }

        private void BtnRaw_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, Color.Salmon);
            OpenChildForm(new Raw());

        }

        private void BtnPurchase_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, Color.Aqua);
            OpenChildForm(new Purchase());

        }

        private void BtnBills_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, Color.BurlyWood);
            OpenChildForm(new Bills());

        }

        private void Reset()
        {
            DisableBtn();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.IndianRed;
            Homelabel.Text = "Home";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }
    }
}