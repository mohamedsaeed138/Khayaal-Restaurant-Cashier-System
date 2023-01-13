namespace Khayaal_SAHM.Main_Form_and_Children_Forms_AR.Raw_Materials_Form_and_Mdi_Forms_AR
{ 
    partial class Add_Edit_RMF_Mdi_Form_AR
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Edit_RMF_Mdi_Form_AR));
            this.Raw_Name_Lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Name_Text_Box = new Guna.UI2.WinForms.Guna2TextBox();
            this.Category_Combo_Box = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Category_Lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Add_a_New_Cat_Lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Add_Category_Text_Box = new Guna.UI2.WinForms.Guna2TextBox();
            this.Add_Raw_Button = new Guna.UI2.WinForms.Guna2Button();
            this.Add_Category_Button = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.New_Category_Label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SuspendLayout();
            // 
            // Raw_Name_Lbl
            // 
            this.Raw_Name_Lbl.BackColor = System.Drawing.Color.Transparent;
            this.Raw_Name_Lbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.Raw_Name_Lbl.ForeColor = System.Drawing.Color.White;
            this.Raw_Name_Lbl.Location = new System.Drawing.Point(405, 47);
            this.Raw_Name_Lbl.Name = "Raw_Name_Lbl";
            this.Raw_Name_Lbl.Size = new System.Drawing.Size(112, 34);
            this.Raw_Name_Lbl.TabIndex = 4;
            this.Raw_Name_Lbl.Text = ": الخام اسم";
            // 
            // Name_Text_Box
            // 
            this.Name_Text_Box.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.Name_Text_Box.BorderRadius = 10;
            this.Name_Text_Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name_Text_Box.DefaultText = "";
            this.Name_Text_Box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Name_Text_Box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Name_Text_Box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Name_Text_Box.DisabledState.Parent = this.Name_Text_Box;
            this.Name_Text_Box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Name_Text_Box.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(67)))));
            this.Name_Text_Box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Name_Text_Box.FocusedState.Parent = this.Name_Text_Box;
            this.Name_Text_Box.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Name_Text_Box.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Name_Text_Box.HoverState.Parent = this.Name_Text_Box;
            this.Name_Text_Box.Location = new System.Drawing.Point(31, 47);
            this.Name_Text_Box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name_Text_Box.Name = "Name_Text_Box";
            this.Name_Text_Box.PasswordChar = '\0';
            this.Name_Text_Box.PlaceholderText = "";
            this.Name_Text_Box.SelectedText = "";
            this.Name_Text_Box.ShadowDecoration.Parent = this.Name_Text_Box;
            this.Name_Text_Box.Size = new System.Drawing.Size(242, 43);
            this.Name_Text_Box.TabIndex = 0;
            this.Name_Text_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Name_Text_Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Name_Text_Box_KeyPress);
            // 
            // Category_Combo_Box
            // 
            this.Category_Combo_Box.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Category_Combo_Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.Category_Combo_Box.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.Category_Combo_Box.BorderRadius = 10;
            this.Category_Combo_Box.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Category_Combo_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Category_Combo_Box.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(67)))));
            this.Category_Combo_Box.FocusedColor = System.Drawing.Color.Empty;
            this.Category_Combo_Box.FocusedState.Parent = this.Category_Combo_Box;
            this.Category_Combo_Box.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.Category_Combo_Box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(158)))), ((int)(((byte)(163)))));
            this.Category_Combo_Box.FormattingEnabled = true;
            this.Category_Combo_Box.HoverState.Parent = this.Category_Combo_Box;
            this.Category_Combo_Box.ItemHeight = 30;
            this.Category_Combo_Box.ItemsAppearance.Parent = this.Category_Combo_Box;
            this.Category_Combo_Box.Location = new System.Drawing.Point(31, 119);
            this.Category_Combo_Box.Name = "Category_Combo_Box";
            this.Category_Combo_Box.ShadowDecoration.Parent = this.Category_Combo_Box;
            this.Category_Combo_Box.Size = new System.Drawing.Size(242, 36);
            this.Category_Combo_Box.TabIndex = 1;
            this.Category_Combo_Box.TabStop = false;
            this.Category_Combo_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Category_Lbl
            // 
            this.Category_Lbl.BackColor = System.Drawing.Color.Transparent;
            this.Category_Lbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.Category_Lbl.ForeColor = System.Drawing.Color.White;
            this.Category_Lbl.Location = new System.Drawing.Point(440, 119);
            this.Category_Lbl.Name = "Category_Lbl";
            this.Category_Lbl.Size = new System.Drawing.Size(77, 34);
            this.Category_Lbl.TabIndex = 11;
            this.Category_Lbl.Text = ": القسم ";
            // 
            // Add_a_New_Cat_Lbl
            // 
            this.Add_a_New_Cat_Lbl.BackColor = System.Drawing.Color.Transparent;
            this.Add_a_New_Cat_Lbl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.Add_a_New_Cat_Lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(158)))), ((int)(((byte)(163)))));
            this.Add_a_New_Cat_Lbl.Location = new System.Drawing.Point(191, 238);
            this.Add_a_New_Cat_Lbl.Name = "Add_a_New_Cat_Lbl";
            this.Add_a_New_Cat_Lbl.Size = new System.Drawing.Size(82, 15);
            this.Add_a_New_Cat_Lbl.TabIndex = 12;
            this.Add_a_New_Cat_Lbl.Text = "جديد قسم إضافة";
            // 
            // Add_Category_Text_Box
            // 
            this.Add_Category_Text_Box.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.Add_Category_Text_Box.BorderRadius = 10;
            this.Add_Category_Text_Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Add_Category_Text_Box.DefaultText = "";
            this.Add_Category_Text_Box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Add_Category_Text_Box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Add_Category_Text_Box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Add_Category_Text_Box.DisabledState.Parent = this.Add_Category_Text_Box;
            this.Add_Category_Text_Box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Add_Category_Text_Box.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(67)))));
            this.Add_Category_Text_Box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Add_Category_Text_Box.FocusedState.Parent = this.Add_Category_Text_Box;
            this.Add_Category_Text_Box.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Add_Category_Text_Box.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Add_Category_Text_Box.HoverState.Parent = this.Add_Category_Text_Box;
            this.Add_Category_Text_Box.Location = new System.Drawing.Point(94, 186);
            this.Add_Category_Text_Box.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Add_Category_Text_Box.Name = "Add_Category_Text_Box";
            this.Add_Category_Text_Box.PasswordChar = '\0';
            this.Add_Category_Text_Box.PlaceholderText = "";
            this.Add_Category_Text_Box.SelectedText = "";
            this.Add_Category_Text_Box.ShadowDecoration.Parent = this.Add_Category_Text_Box;
            this.Add_Category_Text_Box.Size = new System.Drawing.Size(179, 43);
            this.Add_Category_Text_Box.TabIndex = 2;
            this.Add_Category_Text_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Add_Category_Text_Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Add_Category_Text_Box_KeyPress);
            // 
            // Add_Raw_Button
            // 
            this.Add_Raw_Button.BorderRadius = 10;
            this.Add_Raw_Button.CheckedState.Parent = this.Add_Raw_Button;
            this.Add_Raw_Button.CustomImages.Parent = this.Add_Raw_Button;
            this.Add_Raw_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(86)))), ((int)(((byte)(104)))));
            this.Add_Raw_Button.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.Add_Raw_Button.ForeColor = System.Drawing.Color.White;
            this.Add_Raw_Button.HoverState.Parent = this.Add_Raw_Button;
            this.Add_Raw_Button.Location = new System.Drawing.Point(191, 279);
            this.Add_Raw_Button.Name = "Add_Raw_Button";
            this.Add_Raw_Button.ShadowDecoration.Parent = this.Add_Raw_Button;
            this.Add_Raw_Button.Size = new System.Drawing.Size(164, 49);
            this.Add_Raw_Button.TabIndex = 4;
            this.Add_Raw_Button.Text = "أضف";
            this.Add_Raw_Button.Click += new System.EventHandler(this.Add_Raw_Button_Click_1);
            // 
            // Add_Category_Button
            // 
            this.Add_Category_Button.BorderRadius = 10;
            this.Add_Category_Button.CheckedState.Parent = this.Add_Category_Button;
            this.Add_Category_Button.CustomImages.Parent = this.Add_Category_Button;
            this.Add_Category_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(67)))));
            this.Add_Category_Button.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.Add_Category_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(158)))), ((int)(((byte)(163)))));
            this.Add_Category_Button.HoverState.Parent = this.Add_Category_Button;
            this.Add_Category_Button.Location = new System.Drawing.Point(31, 186);
            this.Add_Category_Button.Name = "Add_Category_Button";
            this.Add_Category_Button.ShadowDecoration.Parent = this.Add_Category_Button;
            this.Add_Category_Button.Size = new System.Drawing.Size(55, 43);
            this.Add_Category_Button.TabIndex = 3;
            this.Add_Category_Button.Text = "أضف";
            this.Add_Category_Button.Click += new System.EventHandler(this.Add_Category_Button_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(86)))), ((int)(((byte)(104)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(518, -1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(32, 24);
            this.guna2ControlBox1.TabIndex = 17;
            // 
            // New_Category_Label
            // 
            this.New_Category_Label.BackColor = System.Drawing.Color.Transparent;
            this.New_Category_Label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.New_Category_Label.ForeColor = System.Drawing.Color.White;
            this.New_Category_Label.Location = new System.Drawing.Point(396, 186);
            this.New_Category_Label.Name = "New_Category_Label";
            this.New_Category_Label.Size = new System.Drawing.Size(121, 34);
            this.New_Category_Label.TabIndex = 18;
            this.New_Category_Label.Text = "؟ جديد قسم";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Add_Edit_RMF_Mdi_Form_AR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(550, 364);
            this.Controls.Add(this.New_Category_Label);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.Add_Category_Button);
            this.Controls.Add(this.Add_Raw_Button);
            this.Controls.Add(this.Add_Category_Text_Box);
            this.Controls.Add(this.Add_a_New_Cat_Lbl);
            this.Controls.Add(this.Category_Lbl);
            this.Controls.Add(this.Category_Combo_Box);
            this.Controls.Add(this.Name_Text_Box);
            this.Controls.Add(this.Raw_Name_Lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_Edit_RMF_Mdi_Form_AR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add_Mdi_Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Add_Edit_RMF_Mdi_Form_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel Raw_Name_Lbl;
        private Guna.UI2.WinForms.Guna2TextBox Name_Text_Box;
        private Guna.UI2.WinForms.Guna2ComboBox Category_Combo_Box;
        private Guna.UI2.WinForms.Guna2HtmlLabel Category_Lbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel Add_a_New_Cat_Lbl;
        private Guna.UI2.WinForms.Guna2TextBox Add_Category_Text_Box;
        private Guna.UI2.WinForms.Guna2Button Add_Raw_Button;
        private Guna.UI2.WinForms.Guna2Button Add_Category_Button;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel New_Category_Label;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}