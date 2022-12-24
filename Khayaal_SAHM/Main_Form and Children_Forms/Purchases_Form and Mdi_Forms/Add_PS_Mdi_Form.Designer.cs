namespace Khayaal_SAHM.Main_Form_and_Children_Forms.Purchases_Form_and_Mdi_Forms
{
    partial class Add_PS_Mdi_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_PS_Mdi_Form));
            this.Unit_Price_Text_Box = new Guna.UI2.WinForms.Guna2TextBox();
            this.Item_Name_Lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Unit_Price_Lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Raw_Combo_Box = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Add_Purchase_Button = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Qty_Text_Box = new Guna.UI2.WinForms.Guna2TextBox();
            this.Qty_Label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Notes_Text_Box = new Guna.UI2.WinForms.Guna2TextBox();
            this.Notes_Label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // Unit_Price_Text_Box
            // 
            this.Unit_Price_Text_Box.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.Unit_Price_Text_Box.BorderRadius = 10;
            this.Unit_Price_Text_Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Unit_Price_Text_Box.DefaultText = "";
            this.Unit_Price_Text_Box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Unit_Price_Text_Box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Unit_Price_Text_Box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Unit_Price_Text_Box.DisabledState.Parent = this.Unit_Price_Text_Box;
            this.Unit_Price_Text_Box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Unit_Price_Text_Box.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(67)))));
            this.Unit_Price_Text_Box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Unit_Price_Text_Box.FocusedState.Parent = this.Unit_Price_Text_Box;
            this.Unit_Price_Text_Box.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Unit_Price_Text_Box.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Unit_Price_Text_Box.HoverState.Parent = this.Unit_Price_Text_Box;
            this.Unit_Price_Text_Box.Location = new System.Drawing.Point(276, 210);
            this.Unit_Price_Text_Box.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Unit_Price_Text_Box.Name = "Unit_Price_Text_Box";
            this.Unit_Price_Text_Box.PasswordChar = '\0';
            this.Unit_Price_Text_Box.PlaceholderText = "";
            this.Unit_Price_Text_Box.SelectedText = "";
            this.Unit_Price_Text_Box.ShadowDecoration.Parent = this.Unit_Price_Text_Box;
            this.Unit_Price_Text_Box.Size = new System.Drawing.Size(242, 43);
            this.Unit_Price_Text_Box.TabIndex = 4;
            this.Unit_Price_Text_Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Unite_Price_Text_Box_KeyPress);
            // 
            // Item_Name_Lbl
            // 
            this.Item_Name_Lbl.BackColor = System.Drawing.Color.Transparent;
            this.Item_Name_Lbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.Item_Name_Lbl.ForeColor = System.Drawing.Color.White;
            this.Item_Name_Lbl.Location = new System.Drawing.Point(3, 61);
            this.Item_Name_Lbl.Name = "Item_Name_Lbl";
            this.Item_Name_Lbl.Size = new System.Drawing.Size(143, 34);
            this.Item_Name_Lbl.TabIndex = 4;
            this.Item_Name_Lbl.Text = "Item Name : ";
            // 
            // Unit_Price_Lbl
            // 
            this.Unit_Price_Lbl.BackColor = System.Drawing.Color.Transparent;
            this.Unit_Price_Lbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.Unit_Price_Lbl.ForeColor = System.Drawing.Color.White;
            this.Unit_Price_Lbl.Location = new System.Drawing.Point(3, 210);
            this.Unit_Price_Lbl.Name = "Unit_Price_Lbl";
            this.Unit_Price_Lbl.Size = new System.Drawing.Size(129, 34);
            this.Unit_Price_Lbl.TabIndex = 7;
            this.Unit_Price_Lbl.Text = "Unit Price : ";
            // 
            // Raw_Combo_Box
            // 
            this.Raw_Combo_Box.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Raw_Combo_Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.Raw_Combo_Box.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.Raw_Combo_Box.BorderRadius = 10;
            this.Raw_Combo_Box.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Raw_Combo_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Raw_Combo_Box.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(67)))));
            this.Raw_Combo_Box.FocusedColor = System.Drawing.Color.Empty;
            this.Raw_Combo_Box.FocusedState.Parent = this.Raw_Combo_Box;
            this.Raw_Combo_Box.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.Raw_Combo_Box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(158)))), ((int)(((byte)(163)))));
            this.Raw_Combo_Box.FormattingEnabled = true;
            this.Raw_Combo_Box.HoverState.Parent = this.Raw_Combo_Box;
            this.Raw_Combo_Box.ItemHeight = 30;
            this.Raw_Combo_Box.ItemsAppearance.Parent = this.Raw_Combo_Box;
            this.Raw_Combo_Box.Location = new System.Drawing.Point(276, 61);
            this.Raw_Combo_Box.Name = "Raw_Combo_Box";
            this.Raw_Combo_Box.ShadowDecoration.Parent = this.Raw_Combo_Box;
            this.Raw_Combo_Box.Size = new System.Drawing.Size(242, 36);
            this.Raw_Combo_Box.TabIndex = 2;
            this.Raw_Combo_Box.TabStop = false;
            // 
            // Add_Purchase_Button
            // 
            this.Add_Purchase_Button.BorderRadius = 10;
            this.Add_Purchase_Button.CheckedState.Parent = this.Add_Purchase_Button;
            this.Add_Purchase_Button.CustomImages.Parent = this.Add_Purchase_Button;
            this.Add_Purchase_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(86)))), ((int)(((byte)(104)))));
            this.Add_Purchase_Button.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.Add_Purchase_Button.ForeColor = System.Drawing.Color.White;
            this.Add_Purchase_Button.HoverState.Parent = this.Add_Purchase_Button;
            this.Add_Purchase_Button.Location = new System.Drawing.Point(191, 379);
            this.Add_Purchase_Button.Name = "Add_Purchase_Button";
            this.Add_Purchase_Button.ShadowDecoration.Parent = this.Add_Purchase_Button;
            this.Add_Purchase_Button.Size = new System.Drawing.Size(164, 49);
            this.Add_Purchase_Button.TabIndex = 6;
            this.Add_Purchase_Button.Text = "Add";
            this.Add_Purchase_Button.Click += new System.EventHandler(this.Add_Purchase_Button_Click);
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
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Qty_Text_Box
            // 
            this.Qty_Text_Box.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.Qty_Text_Box.BorderRadius = 10;
            this.Qty_Text_Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Qty_Text_Box.DefaultText = "";
            this.Qty_Text_Box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Qty_Text_Box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Qty_Text_Box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Qty_Text_Box.DisabledState.Parent = this.Qty_Text_Box;
            this.Qty_Text_Box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Qty_Text_Box.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(67)))));
            this.Qty_Text_Box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Qty_Text_Box.FocusedState.Parent = this.Qty_Text_Box;
            this.Qty_Text_Box.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Qty_Text_Box.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Qty_Text_Box.HoverState.Parent = this.Qty_Text_Box;
            this.Qty_Text_Box.Location = new System.Drawing.Point(276, 131);
            this.Qty_Text_Box.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Qty_Text_Box.Name = "Qty_Text_Box";
            this.Qty_Text_Box.PasswordChar = '\0';
            this.Qty_Text_Box.PlaceholderText = "";
            this.Qty_Text_Box.SelectedText = "";
            this.Qty_Text_Box.ShadowDecoration.Parent = this.Qty_Text_Box;
            this.Qty_Text_Box.Size = new System.Drawing.Size(242, 43);
            this.Qty_Text_Box.TabIndex = 22;
            // 
            // Qty_Label
            // 
            this.Qty_Label.BackColor = System.Drawing.Color.Transparent;
            this.Qty_Label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.Qty_Label.ForeColor = System.Drawing.Color.White;
            this.Qty_Label.Location = new System.Drawing.Point(3, 131);
            this.Qty_Label.Name = "Qty_Label";
            this.Qty_Label.Size = new System.Drawing.Size(50, 34);
            this.Qty_Label.TabIndex = 23;
            this.Qty_Label.Text = "Qty: ";
            // 
            // Notes_Text_Box
            // 
            this.Notes_Text_Box.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.Notes_Text_Box.BorderRadius = 10;
            this.Notes_Text_Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Notes_Text_Box.DefaultText = "";
            this.Notes_Text_Box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Notes_Text_Box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Notes_Text_Box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Notes_Text_Box.DisabledState.Parent = this.Notes_Text_Box;
            this.Notes_Text_Box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Notes_Text_Box.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(67)))));
            this.Notes_Text_Box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Notes_Text_Box.FocusedState.Parent = this.Notes_Text_Box;
            this.Notes_Text_Box.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Notes_Text_Box.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Notes_Text_Box.HoverState.Parent = this.Notes_Text_Box;
            this.Notes_Text_Box.Location = new System.Drawing.Point(276, 287);
            this.Notes_Text_Box.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Notes_Text_Box.Name = "Notes_Text_Box";
            this.Notes_Text_Box.PasswordChar = '\0';
            this.Notes_Text_Box.PlaceholderText = "";
            this.Notes_Text_Box.SelectedText = "";
            this.Notes_Text_Box.ShadowDecoration.Parent = this.Notes_Text_Box;
            this.Notes_Text_Box.Size = new System.Drawing.Size(242, 43);
            this.Notes_Text_Box.TabIndex = 24;
            this.Notes_Text_Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Notes_Text_Box_KeyPress);
            // 
            // Notes_Label
            // 
            this.Notes_Label.BackColor = System.Drawing.Color.Transparent;
            this.Notes_Label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.Notes_Label.ForeColor = System.Drawing.Color.White;
            this.Notes_Label.Location = new System.Drawing.Point(3, 287);
            this.Notes_Label.Name = "Notes_Label";
            this.Notes_Label.Size = new System.Drawing.Size(84, 34);
            this.Notes_Label.TabIndex = 25;
            this.Notes_Label.Text = "Notes : ";
            // 
            // Add_PS_Mdi_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(550, 490);
            this.Controls.Add(this.Notes_Label);
            this.Controls.Add(this.Notes_Text_Box);
            this.Controls.Add(this.Qty_Label);
            this.Controls.Add(this.Qty_Text_Box);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.Add_Purchase_Button);
            this.Controls.Add(this.Raw_Combo_Box);
            this.Controls.Add(this.Unit_Price_Lbl);
            this.Controls.Add(this.Item_Name_Lbl);
            this.Controls.Add(this.Unit_Price_Text_Box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_PS_Mdi_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add_Mdi_Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Add_PS_Mdi_Form_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox Unit_Price_Text_Box;
        private Guna.UI2.WinForms.Guna2HtmlLabel Item_Name_Lbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel Unit_Price_Lbl;
        private Guna.UI2.WinForms.Guna2ComboBox Raw_Combo_Box;
        private Guna.UI2.WinForms.Guna2Button Add_Purchase_Button;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Guna.UI2.WinForms.Guna2HtmlLabel Qty_Label;
        private Guna.UI2.WinForms.Guna2TextBox Qty_Text_Box;
        private Guna.UI2.WinForms.Guna2HtmlLabel Notes_Label;
        private Guna.UI2.WinForms.Guna2TextBox Notes_Text_Box;
    }
}