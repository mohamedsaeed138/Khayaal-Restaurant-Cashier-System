namespace SideBar
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.BtnBills = new FontAwesome.Sharp.IconButton();
            this.BtnPurchase = new FontAwesome.Sharp.IconButton();
            this.BtnRaw = new FontAwesome.Sharp.IconButton();
            this.BtnItems = new FontAwesome.Sharp.IconButton();
            this.BtnBooking = new FontAwesome.Sharp.IconButton();
            this.BtnOrder = new FontAwesome.Sharp.IconButton();
            this.HomePanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.Homelabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelMenu.SuspendLayout();
            this.HomePanel.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.panelMenu.Controls.Add(this.BtnBills);
            this.panelMenu.Controls.Add(this.BtnPurchase);
            this.panelMenu.Controls.Add(this.BtnRaw);
            this.panelMenu.Controls.Add(this.BtnItems);
            this.panelMenu.Controls.Add(this.BtnBooking);
            this.panelMenu.Controls.Add(this.BtnOrder);
            this.panelMenu.Controls.Add(this.HomePanel);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(209, 450);
            this.panelMenu.TabIndex = 0;
            // 
            // BtnBills
            // 
            this.BtnBills.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnBills.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnBills.FlatAppearance.BorderSize = 0;
            this.BtnBills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBills.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.BtnBills.ForeColor = System.Drawing.Color.IndianRed;
            this.BtnBills.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.BtnBills.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(86)))), ((int)(((byte)(104)))));
            this.BtnBills.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBills.IconSize = 32;
            this.BtnBills.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBills.Location = new System.Drawing.Point(0, 301);
            this.BtnBills.Name = "BtnBills";
            this.BtnBills.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnBills.Size = new System.Drawing.Size(209, 50);
            this.BtnBills.TabIndex = 7;
            this.BtnBills.Text = "Bill";
            this.BtnBills.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBills.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBills.UseVisualStyleBackColor = true;
            this.BtnBills.Click += new System.EventHandler(this.BtnBills_Click);
            // 
            // BtnPurchase
            // 
            this.BtnPurchase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnPurchase.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPurchase.FlatAppearance.BorderSize = 0;
            this.BtnPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPurchase.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.BtnPurchase.ForeColor = System.Drawing.Color.IndianRed;
            this.BtnPurchase.IconChar = FontAwesome.Sharp.IconChar.SquarePlus;
            this.BtnPurchase.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(86)))), ((int)(((byte)(104)))));
            this.BtnPurchase.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPurchase.IconSize = 32;
            this.BtnPurchase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPurchase.Location = new System.Drawing.Point(0, 251);
            this.BtnPurchase.Name = "BtnPurchase";
            this.BtnPurchase.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnPurchase.Size = new System.Drawing.Size(209, 50);
            this.BtnPurchase.TabIndex = 6;
            this.BtnPurchase.Text = "Purchases";
            this.BtnPurchase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPurchase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPurchase.UseVisualStyleBackColor = true;
            this.BtnPurchase.Click += new System.EventHandler(this.BtnPurchase_Click);
            // 
            // BtnRaw
            // 
            this.BtnRaw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnRaw.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRaw.FlatAppearance.BorderSize = 0;
            this.BtnRaw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRaw.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.BtnRaw.ForeColor = System.Drawing.Color.IndianRed;
            this.BtnRaw.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            this.BtnRaw.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(86)))), ((int)(((byte)(104)))));
            this.BtnRaw.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnRaw.IconSize = 32;
            this.BtnRaw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRaw.Location = new System.Drawing.Point(0, 201);
            this.BtnRaw.Name = "BtnRaw";
            this.BtnRaw.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnRaw.Size = new System.Drawing.Size(209, 50);
            this.BtnRaw.TabIndex = 5;
            this.BtnRaw.Text = "Raw";
            this.BtnRaw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRaw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRaw.UseVisualStyleBackColor = true;
            this.BtnRaw.Click += new System.EventHandler(this.BtnRaw_Click);
            // 
            // BtnItems
            // 
            this.BtnItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnItems.FlatAppearance.BorderSize = 0;
            this.BtnItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnItems.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.BtnItems.ForeColor = System.Drawing.Color.IndianRed;
            this.BtnItems.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.BtnItems.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(86)))), ((int)(((byte)(104)))));
            this.BtnItems.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnItems.IconSize = 32;
            this.BtnItems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnItems.Location = new System.Drawing.Point(0, 151);
            this.BtnItems.Name = "BtnItems";
            this.BtnItems.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnItems.Size = new System.Drawing.Size(209, 50);
            this.BtnItems.TabIndex = 4;
            this.BtnItems.Text = "Items";
            this.BtnItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnItems.UseVisualStyleBackColor = true;
            this.BtnItems.Click += new System.EventHandler(this.BtnItems_Click);
            // 
            // BtnBooking
            // 
            this.BtnBooking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnBooking.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnBooking.FlatAppearance.BorderSize = 0;
            this.BtnBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBooking.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.BtnBooking.ForeColor = System.Drawing.Color.IndianRed;
            this.BtnBooking.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.BtnBooking.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(86)))), ((int)(((byte)(104)))));
            this.BtnBooking.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBooking.IconSize = 32;
            this.BtnBooking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBooking.Location = new System.Drawing.Point(0, 101);
            this.BtnBooking.Name = "BtnBooking";
            this.BtnBooking.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnBooking.Size = new System.Drawing.Size(209, 50);
            this.BtnBooking.TabIndex = 3;
            this.BtnBooking.Text = "Booking";
            this.BtnBooking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBooking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBooking.UseVisualStyleBackColor = true;
            this.BtnBooking.Click += new System.EventHandler(this.BtnBooking_Click);
            // 
            // BtnOrder
            // 
            this.BtnOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnOrder.FlatAppearance.BorderSize = 0;
            this.BtnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOrder.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.BtnOrder.ForeColor = System.Drawing.Color.IndianRed;
            this.BtnOrder.IconChar = FontAwesome.Sharp.IconChar.Cutlery;
            this.BtnOrder.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(86)))), ((int)(((byte)(104)))));
            this.BtnOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnOrder.IconSize = 32;
            this.BtnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOrder.Location = new System.Drawing.Point(0, 51);
            this.BtnOrder.Name = "BtnOrder";
            this.BtnOrder.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnOrder.Size = new System.Drawing.Size(209, 50);
            this.BtnOrder.TabIndex = 2;
            this.BtnOrder.Text = "Order";
            this.BtnOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnOrder.UseVisualStyleBackColor = true;
            this.BtnOrder.Click += new System.EventHandler(this.BtnOrder_Click_1);
            // 
            // HomePanel
            // 
            this.HomePanel.BorderRadius = 20;
            this.HomePanel.Controls.Add(this.button1);
            this.HomePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HomePanel.FillColor = System.Drawing.SystemColors.MenuHighlight;
            this.HomePanel.FillColor2 = System.Drawing.Color.IndianRed;
            this.HomePanel.FillColor3 = System.Drawing.Color.RosyBrown;
            this.HomePanel.FillColor4 = System.Drawing.Color.Tomato;
            this.HomePanel.Location = new System.Drawing.Point(0, 0);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(209, 51);
            this.HomePanel.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.guna2GradientPanel1.Controls.Add(this.Homelabel);
            this.guna2GradientPanel1.Controls.Add(this.iconCurrentChildForm);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(209, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(591, 51);
            this.guna2GradientPanel1.TabIndex = 1;
            // 
            // Homelabel
            // 
            this.Homelabel.BackColor = System.Drawing.Color.Transparent;
            this.Homelabel.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Homelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(86)))), ((int)(((byte)(104)))));
            this.Homelabel.Location = new System.Drawing.Point(57, 12);
            this.Homelabel.Name = "Homelabel";
            this.Homelabel.Size = new System.Drawing.Size(61, 32);
            this.Homelabel.TabIndex = 1;
            this.Homelabel.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(86)))), ((int)(((byte)(104)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(86)))), ((int)(((byte)(104)))));
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(19, 12);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(209, 51);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(591, 399);
            this.panelDesktop.TabIndex = 2;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 1D;
            this.guna2DragControl1.TargetControl = this.panelMenu;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.panelMenu;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.HomePanel.ResumeLayout(false);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton BtnBills;
        private FontAwesome.Sharp.IconButton BtnPurchase;
        private FontAwesome.Sharp.IconButton BtnRaw;
        private FontAwesome.Sharp.IconButton BtnItems;
        private FontAwesome.Sharp.IconButton BtnBooking;
        private FontAwesome.Sharp.IconButton BtnOrder;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel HomePanel;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private Guna.UI2.WinForms.Guna2HtmlLabel Homelabel;
        private Button button1;
        private Panel panelDesktop;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}