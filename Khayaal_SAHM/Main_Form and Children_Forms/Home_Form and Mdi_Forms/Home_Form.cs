using System;
using System.Windows.Forms;

namespace Khayaal_SAHM.Main_Form_and_Children_Forms.Home_Form_and_Mdi_Forms
{
    public partial class Home_Form : Form
    {
        public EventHandler On_Select = null;
        public Home_Form()
        {
            InitializeComponent();
        }



        private void Search_Text_Box_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ' ' || (Search_Text_Box.Text.Length >= 50 && e.KeyChar != 8))
           || (Search_Text_Box.Text.Length > 1 && Search_Text_Box.Text[Search_Text_Box.Text.Length - 1] == ' ' && e.KeyChar == ' ') || (e.KeyChar == ' ' && Search_Text_Box.Text.Length == 0))

            {
                e.Handled = true;
            }
        }

        private void Items_Flow_Layout_Panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
