using System;

namespace Khayaal_SAHM.Main_Form_and_Children_Forms.Home_Form_and_Mdi_Forms
{
    partial class Home_Form
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
            this.restaurantCafeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Order_Flow_Layout_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.Items_Main_Panel = new System.Windows.Forms.Panel();
            this.Items_Flow_Layout_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.Order_Main_Panel = new System.Windows.Forms.Panel();
            this.Home_Bar_Main_Panel = new System.Windows.Forms.Panel();
            this.Home_Child_Labels = new System.Windows.Forms.Panel();
            this.Date_Label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Khayaal_Label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Home_Child_Contorlers = new System.Windows.Forms.Panel();
            this.Category_Combo_Box = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Search_Text_Box = new Guna.UI2.WinForms.Guna2TextBox();
            this.Add_Item_Button = new Guna.UI2.WinForms.Guna2Button();
            this.Order_Nested_Flow_Layout_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.Total_Nested_Panel = new System.Windows.Forms.Panel();
            this.Clear_All_Button = new Guna.UI2.WinForms.Guna2Button();
            this.Order_Label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.restaurantCafeDataSetBindingSource)).BeginInit();
            this.Items_Main_Panel.SuspendLayout();
            this.Order_Main_Panel.SuspendLayout();
            this.Home_Bar_Main_Panel.SuspendLayout();
            this.Home_Child_Labels.SuspendLayout();
            this.Home_Child_Contorlers.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this.Order_Nested_Flow_Layout_Panel;
            // 
            // Order_Flow_Layout_Panel
            // 
            this.Order_Flow_Layout_Panel.AutoSize = true;
            this.Order_Flow_Layout_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.Order_Flow_Layout_Panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.Order_Flow_Layout_Panel.Location = new System.Drawing.Point(974, 0);
            this.Order_Flow_Layout_Panel.Name = "Order_Flow_Layout_Panel";
            this.Order_Flow_Layout_Panel.Size = new System.Drawing.Size(0, 581);
            this.Order_Flow_Layout_Panel.TabIndex = 8;
            // 
            // Items_Main_Panel
            // 
            this.Items_Main_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Items_Main_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.Items_Main_Panel.Controls.Add(this.Items_Flow_Layout_Panel);
            this.Items_Main_Panel.Location = new System.Drawing.Point(0, 110);
            this.Items_Main_Panel.Name = "Items_Main_Panel";
            this.Items_Main_Panel.Size = new System.Drawing.Size(658, 471);
            this.Items_Main_Panel.TabIndex = 11;
            this.Items_Main_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Items_Main_Panel_Paint);
            // 
            // Items_Flow_Layout_Panel
            // 
            this.Items_Flow_Layout_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Items_Flow_Layout_Panel.AutoScroll = true;
            this.Items_Flow_Layout_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.Items_Flow_Layout_Panel.Location = new System.Drawing.Point(0, 8);
            this.Items_Flow_Layout_Panel.Name = "Items_Flow_Layout_Panel";
            this.Items_Flow_Layout_Panel.Size = new System.Drawing.Size(631, 463);
            this.Items_Flow_Layout_Panel.TabIndex = 0;
            this.Items_Flow_Layout_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Items_Flow_Layout_Panel_Paint);
            // 
            // Order_Main_Panel
            // 
            this.Order_Main_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Order_Main_Panel.BackColor = System.Drawing.Color.Cyan;
            this.Order_Main_Panel.Controls.Add(this.Order_Label);
            this.Order_Main_Panel.Controls.Add(this.Clear_All_Button);
            this.Order_Main_Panel.Controls.Add(this.Total_Nested_Panel);
            this.Order_Main_Panel.Controls.Add(this.Order_Nested_Flow_Layout_Panel);
            this.Order_Main_Panel.Location = new System.Drawing.Point(658, 0);
            this.Order_Main_Panel.Name = "Order_Main_Panel";
            this.Order_Main_Panel.Size = new System.Drawing.Size(316, 581);
            this.Order_Main_Panel.TabIndex = 12;
            this.Order_Main_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Order_Main_Panel_Paint);
            // 
            // Home_Bar_Main_Panel
            // 
            this.Home_Bar_Main_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Home_Bar_Main_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Home_Bar_Main_Panel.Controls.Add(this.Home_Child_Labels);
            this.Home_Bar_Main_Panel.Controls.Add(this.Home_Child_Contorlers);
            this.Home_Bar_Main_Panel.Location = new System.Drawing.Point(0, 0);
            this.Home_Bar_Main_Panel.Name = "Home_Bar_Main_Panel";
            this.Home_Bar_Main_Panel.Size = new System.Drawing.Size(658, 110);
            this.Home_Bar_Main_Panel.TabIndex = 10;
            this.Home_Bar_Main_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Home_Bar_Main_Panel_Paint);
            // 
            // Home_Child_Labels
            // 
            this.Home_Child_Labels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Home_Child_Labels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.Home_Child_Labels.Controls.Add(this.Date_Label);
            this.Home_Child_Labels.Controls.Add(this.Khayaal_Label);
            this.Home_Child_Labels.Location = new System.Drawing.Point(0, 0);
            this.Home_Child_Labels.Name = "Home_Child_Labels";
            this.Home_Child_Labels.Size = new System.Drawing.Size(321, 110);
            this.Home_Child_Labels.TabIndex = 1;
            // 
            // Date_Label
            // 
            this.Date_Label.BackColor = System.Drawing.Color.Transparent;
            this.Date_Label.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_Label.ForeColor = System.Drawing.Color.White;
            this.Date_Label.Location = new System.Drawing.Point(12, 68);
            this.Date_Label.Name = "Date_Label";
            this.Date_Label.Size = new System.Drawing.Size(258, 39);
            this.Date_Label.TabIndex = 27;
            this.Date_Label.Text = "December 20 , 2022";
            this.Date_Label.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Khayaal_Label
            // 
            this.Khayaal_Label.BackColor = System.Drawing.Color.Transparent;
            this.Khayaal_Label.Font = new System.Drawing.Font("Segoe UI", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Khayaal_Label.ForeColor = System.Drawing.Color.White;
            this.Khayaal_Label.Location = new System.Drawing.Point(10, -3);
            this.Khayaal_Label.Name = "Khayaal_Label";
            this.Khayaal_Label.Size = new System.Drawing.Size(200, 73);
            this.Khayaal_Label.TabIndex = 26;
            this.Khayaal_Label.Text = "Khayaal";
            this.Khayaal_Label.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Home_Child_Contorlers
            // 
            this.Home_Child_Contorlers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Home_Child_Contorlers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.Home_Child_Contorlers.Controls.Add(this.Category_Combo_Box);
            this.Home_Child_Contorlers.Controls.Add(this.Search_Text_Box);
            this.Home_Child_Contorlers.Controls.Add(this.Add_Item_Button);
            this.Home_Child_Contorlers.Location = new System.Drawing.Point(321, 0);
            this.Home_Child_Contorlers.Name = "Home_Child_Contorlers";
            this.Home_Child_Contorlers.Size = new System.Drawing.Size(337, 110);
            this.Home_Child_Contorlers.TabIndex = 0;
            // 
            // Category_Combo_Box
            // 
            this.Category_Combo_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Category_Combo_Box.BackColor = System.Drawing.Color.Transparent;
            this.Category_Combo_Box.BorderRadius = 10;
            this.Category_Combo_Box.BorderThickness = 0;
            this.Category_Combo_Box.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Category_Combo_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Category_Combo_Box.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.Category_Combo_Box.FocusedColor = System.Drawing.Color.Empty;
            this.Category_Combo_Box.FocusedState.Parent = this.Category_Combo_Box;
            this.Category_Combo_Box.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Category_Combo_Box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Category_Combo_Box.FormattingEnabled = true;
            this.Category_Combo_Box.HoverState.Parent = this.Category_Combo_Box;
            this.Category_Combo_Box.ItemHeight = 30;
            this.Category_Combo_Box.ItemsAppearance.Parent = this.Category_Combo_Box;
            this.Category_Combo_Box.Location = new System.Drawing.Point(10, 60);
            this.Category_Combo_Box.Margin = new System.Windows.Forms.Padding(2);
            this.Category_Combo_Box.Name = "Category_Combo_Box";
            this.Category_Combo_Box.ShadowDecoration.Parent = this.Category_Combo_Box;
            this.Category_Combo_Box.Size = new System.Drawing.Size(161, 36);
            this.Category_Combo_Box.TabIndex = 23;
            // 
            // Search_Text_Box
            // 
            this.Search_Text_Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Search_Text_Box.BorderRadius = 10;
            this.Search_Text_Box.BorderThickness = 0;
            this.Search_Text_Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Search_Text_Box.DefaultText = "";
            this.Search_Text_Box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Search_Text_Box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Search_Text_Box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Search_Text_Box.DisabledState.Parent = this.Search_Text_Box;
            this.Search_Text_Box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Search_Text_Box.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.Search_Text_Box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Search_Text_Box.FocusedState.Parent = this.Search_Text_Box;
            this.Search_Text_Box.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Search_Text_Box.HoverState.Parent = this.Search_Text_Box;
            this.Search_Text_Box.Location = new System.Drawing.Point(10, 13);
            this.Search_Text_Box.Margin = new System.Windows.Forms.Padding(4);
            this.Search_Text_Box.Name = "Search_Text_Box";
            this.Search_Text_Box.PasswordChar = '\0';
            this.Search_Text_Box.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Search_Text_Box.PlaceholderText = "Search";
            this.Search_Text_Box.SelectedText = "";
            this.Search_Text_Box.ShadowDecoration.Parent = this.Search_Text_Box;
            this.Search_Text_Box.Size = new System.Drawing.Size(312, 36);
            this.Search_Text_Box.TabIndex = 27;
            // 
            // Add_Item_Button
            // 
            this.Add_Item_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Add_Item_Button.BorderRadius = 10;
            this.Add_Item_Button.CheckedState.Parent = this.Add_Item_Button;
            this.Add_Item_Button.CustomImages.Parent = this.Add_Item_Button;
            this.Add_Item_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.Add_Item_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Item_Button.ForeColor = System.Drawing.Color.White;
            this.Add_Item_Button.HoverState.Parent = this.Add_Item_Button;
            this.Add_Item_Button.Location = new System.Drawing.Point(187, 60);
            this.Add_Item_Button.Name = "Add_Item_Button";
            this.Add_Item_Button.ShadowDecoration.Parent = this.Add_Item_Button;
            this.Add_Item_Button.Size = new System.Drawing.Size(135, 36);
            this.Add_Item_Button.TabIndex = 25;
            this.Add_Item_Button.Text = "Add Item";
            // 
            // Order_Nested_Flow_Layout_Panel
            // 
            this.Order_Nested_Flow_Layout_Panel.BackColor = System.Drawing.Color.Aquamarine;
            this.Order_Nested_Flow_Layout_Panel.Location = new System.Drawing.Point(11, 60);
            this.Order_Nested_Flow_Layout_Panel.Name = "Order_Nested_Flow_Layout_Panel";
            this.Order_Nested_Flow_Layout_Panel.Size = new System.Drawing.Size(295, 289);
            this.Order_Nested_Flow_Layout_Panel.TabIndex = 0;
            // 
            // Total_Nested_Panel
            // 
            this.Total_Nested_Panel.BackColor = System.Drawing.Color.MintCream;
            this.Total_Nested_Panel.Location = new System.Drawing.Point(11, 361);
            this.Total_Nested_Panel.Name = "Total_Nested_Panel";
            this.Total_Nested_Panel.Size = new System.Drawing.Size(295, 201);
            this.Total_Nested_Panel.TabIndex = 1;
            // 
            // Clear_All_Button
            // 
            this.Clear_All_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Clear_All_Button.BorderRadius = 10;
            this.Clear_All_Button.CheckedState.Parent = this.Clear_All_Button;
            this.Clear_All_Button.CustomImages.Parent = this.Clear_All_Button;
            this.Clear_All_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Clear_All_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_All_Button.ForeColor = System.Drawing.Color.White;
            this.Clear_All_Button.HoverState.Parent = this.Clear_All_Button;
            this.Clear_All_Button.Location = new System.Drawing.Point(188, 10);
            this.Clear_All_Button.Name = "Clear_All_Button";
            this.Clear_All_Button.ShadowDecoration.Parent = this.Clear_All_Button;
            this.Clear_All_Button.Size = new System.Drawing.Size(118, 36);
            this.Clear_All_Button.TabIndex = 26;
            this.Clear_All_Button.Text = "Clear All";
            // 
            // Order_Label
            // 
            this.Order_Label.BackColor = System.Drawing.Color.Transparent;
            this.Order_Label.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order_Label.ForeColor = System.Drawing.Color.White;
            this.Order_Label.Location = new System.Drawing.Point(11, 3);
            this.Order_Label.Name = "Order_Label";
            this.Order_Label.Size = new System.Drawing.Size(90, 47);
            this.Order_Label.TabIndex = 28;
            this.Order_Label.Tag = "";
            this.Order_Label.Text = "Order";
            this.Order_Label.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Order_Label.Click += new System.EventHandler(this.Order_Label_Click);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 10;
            this.guna2Elipse2.TargetControl = this.Total_Nested_Panel;
            // 
            // Home_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(974, 581);
            this.Controls.Add(this.Order_Main_Panel);
            this.Controls.Add(this.Items_Main_Panel);
            this.Controls.Add(this.Home_Bar_Main_Panel);
            this.Controls.Add(this.Order_Flow_Layout_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home_Form";
            this.Text = "Home_Form";
            ((System.ComponentModel.ISupportInitialize)(this.restaurantCafeDataSetBindingSource)).EndInit();
            this.Items_Main_Panel.ResumeLayout(false);
            this.Order_Main_Panel.ResumeLayout(false);
            this.Order_Main_Panel.PerformLayout();
            this.Home_Bar_Main_Panel.ResumeLayout(false);
            this.Home_Child_Labels.ResumeLayout(false);
            this.Home_Child_Labels.PerformLayout();
            this.Home_Child_Contorlers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.BindingSource restaurantCafeDataSetBindingSource;
        private System.Windows.Forms.FlowLayoutPanel Order_Flow_Layout_Panel;
        private System.Windows.Forms.Panel Items_Main_Panel;
        public System.Windows.Forms.Panel Order_Main_Panel;
        private System.Windows.Forms.FlowLayoutPanel Items_Flow_Layout_Panel;
        private System.Windows.Forms.Panel Home_Bar_Main_Panel;
        private Guna.UI2.WinForms.Guna2Button Add_Item_Button;
        private Guna.UI2.WinForms.Guna2ComboBox Category_Combo_Box;
        private System.Windows.Forms.Panel Home_Child_Labels;
        private System.Windows.Forms.Panel Home_Child_Contorlers;
        private Guna.UI2.WinForms.Guna2HtmlLabel Date_Label;
        private Guna.UI2.WinForms.Guna2HtmlLabel Khayaal_Label;
        private Guna.UI2.WinForms.Guna2TextBox Search_Text_Box;
        private Guna.UI2.WinForms.Guna2HtmlLabel Order_Label;
        private Guna.UI2.WinForms.Guna2Button Clear_All_Button;
        private System.Windows.Forms.Panel Total_Nested_Panel;
        private System.Windows.Forms.FlowLayoutPanel Order_Nested_Flow_Layout_Panel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
    }
}