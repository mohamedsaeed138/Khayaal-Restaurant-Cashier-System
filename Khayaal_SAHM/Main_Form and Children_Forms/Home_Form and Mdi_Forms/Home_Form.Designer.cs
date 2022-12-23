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
            this.Order_Flow_Layout_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.Items_Main_Panel = new System.Windows.Forms.Panel();
            this.Items_Nested_Flow_Layout_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.Order_Main_Panel = new System.Windows.Forms.Panel();
            this.Order_Label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Clear_All_Button = new Guna.UI2.WinForms.Guna2Button();
            this.Total_Nested_Panel = new System.Windows.Forms.Panel();
            this.Print_and_Save_Button = new Guna.UI2.WinForms.Guna2Button();
            this.Save_Button = new Guna.UI2.WinForms.Guna2Button();
            this.Total_Label_Value = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Dolaar_Sign_Label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Total_Label_Tmp = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Order_Nested_Flow_Layout_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.Home_Bar_Main_Panel = new System.Windows.Forms.Panel();
            this.Home_Nested_Panel_Labels = new System.Windows.Forms.Panel();
            this.Date_Label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Khayaal_Label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Home_Nested_Panel_Controlers = new System.Windows.Forms.Panel();
            this.Category_Label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Category_Combo_Box = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Search_Text_Box = new Guna.UI2.WinForms.Guna2TextBox();
            this.Add_Item_Button = new Guna.UI2.WinForms.Guna2Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.restaurantCafeDataSetBindingSource)).BeginInit();
            this.Items_Main_Panel.SuspendLayout();
            this.Order_Main_Panel.SuspendLayout();
            this.Total_Nested_Panel.SuspendLayout();
            this.Home_Bar_Main_Panel.SuspendLayout();
            this.Home_Nested_Panel_Labels.SuspendLayout();
            this.Home_Nested_Panel_Controlers.SuspendLayout();
            this.SuspendLayout();
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
            this.Items_Main_Panel.Controls.Add(this.Items_Nested_Flow_Layout_Panel);
            this.Items_Main_Panel.Location = new System.Drawing.Point(0, 110);
            this.Items_Main_Panel.Name = "Items_Main_Panel";
            this.Items_Main_Panel.Size = new System.Drawing.Size(658, 471);
            this.Items_Main_Panel.TabIndex = 11;
            // 
            // Items_Nested_Flow_Layout_Panel
            // 
            this.Items_Nested_Flow_Layout_Panel.AutoScroll = true;
            this.Items_Nested_Flow_Layout_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.Items_Nested_Flow_Layout_Panel.Location = new System.Drawing.Point(0, 8);
            this.Items_Nested_Flow_Layout_Panel.Name = "Items_Nested_Flow_Layout_Panel";
            this.Items_Nested_Flow_Layout_Panel.Size = new System.Drawing.Size(643, 463);
            this.Items_Nested_Flow_Layout_Panel.TabIndex = 0;
            // 
            // Order_Main_Panel
            // 
            this.Order_Main_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Order_Main_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.Order_Main_Panel.Controls.Add(this.Order_Label);
            this.Order_Main_Panel.Controls.Add(this.Clear_All_Button);
            this.Order_Main_Panel.Controls.Add(this.Total_Nested_Panel);
            this.Order_Main_Panel.Controls.Add(this.Order_Nested_Flow_Layout_Panel);
            this.Order_Main_Panel.Location = new System.Drawing.Point(658, 0);
            this.Order_Main_Panel.Name = "Order_Main_Panel";
            this.Order_Main_Panel.Size = new System.Drawing.Size(316, 581);
            this.Order_Main_Panel.TabIndex = 12;
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
            // Total_Nested_Panel
            // 
            this.Total_Nested_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Total_Nested_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.Total_Nested_Panel.Controls.Add(this.Print_and_Save_Button);
            this.Total_Nested_Panel.Controls.Add(this.Save_Button);
            this.Total_Nested_Panel.Controls.Add(this.Total_Label_Value);
            this.Total_Nested_Panel.Controls.Add(this.Dolaar_Sign_Label);
            this.Total_Nested_Panel.Controls.Add(this.Total_Label_Tmp);
            this.Total_Nested_Panel.Location = new System.Drawing.Point(11, 361);
            this.Total_Nested_Panel.Name = "Total_Nested_Panel";
            this.Total_Nested_Panel.Size = new System.Drawing.Size(295, 201);
            this.Total_Nested_Panel.TabIndex = 1;
            // 
            // Print_and_Save_Button
            // 
            this.Print_and_Save_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Print_and_Save_Button.BorderRadius = 10;
            this.Print_and_Save_Button.CheckedState.Parent = this.Print_and_Save_Button;
            this.Print_and_Save_Button.CustomImages.Parent = this.Print_and_Save_Button;
            this.Print_and_Save_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(86)))), ((int)(((byte)(104)))));
            this.Print_and_Save_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Print_and_Save_Button.ForeColor = System.Drawing.Color.White;
            this.Print_and_Save_Button.HoverState.Parent = this.Print_and_Save_Button;
            this.Print_and_Save_Button.Location = new System.Drawing.Point(28, 131);
            this.Print_and_Save_Button.Name = "Print_and_Save_Button";
            this.Print_and_Save_Button.ShadowDecoration.Parent = this.Print_and_Save_Button;
            this.Print_and_Save_Button.Size = new System.Drawing.Size(239, 36);
            this.Print_and_Save_Button.TabIndex = 32;
            this.Print_and_Save_Button.Text = "Print & Save";
            // 
            // Save_Button
            // 
            this.Save_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Save_Button.BorderRadius = 10;
            this.Save_Button.CheckedState.Parent = this.Save_Button;
            this.Save_Button.CustomImages.Parent = this.Save_Button;
            this.Save_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(86)))), ((int)(((byte)(104)))));
            this.Save_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_Button.ForeColor = System.Drawing.Color.White;
            this.Save_Button.HoverState.Parent = this.Save_Button;
            this.Save_Button.Location = new System.Drawing.Point(28, 82);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.ShadowDecoration.Parent = this.Save_Button;
            this.Save_Button.Size = new System.Drawing.Size(239, 36);
            this.Save_Button.TabIndex = 31;
            this.Save_Button.Text = "Save";
            // 
            // Total_Label_Value
            // 
            this.Total_Label_Value.BackColor = System.Drawing.Color.Transparent;
            this.Total_Label_Value.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Label_Value.ForeColor = System.Drawing.Color.White;
            this.Total_Label_Value.Location = new System.Drawing.Point(220, 38);
            this.Total_Label_Value.Name = "Total_Label_Value";
            this.Total_Label_Value.Size = new System.Drawing.Size(15, 32);
            this.Total_Label_Value.TabIndex = 30;
            this.Total_Label_Value.Text = "0";
            this.Total_Label_Value.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dolaar_Sign_Label
            // 
            this.Dolaar_Sign_Label.BackColor = System.Drawing.Color.Transparent;
            this.Dolaar_Sign_Label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dolaar_Sign_Label.ForeColor = System.Drawing.Color.White;
            this.Dolaar_Sign_Label.Location = new System.Drawing.Point(199, 38);
            this.Dolaar_Sign_Label.Name = "Dolaar_Sign_Label";
            this.Dolaar_Sign_Label.Size = new System.Drawing.Size(15, 32);
            this.Dolaar_Sign_Label.TabIndex = 29;
            this.Dolaar_Sign_Label.Text = "$";
            this.Dolaar_Sign_Label.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Total_Label_Tmp
            // 
            this.Total_Label_Tmp.BackColor = System.Drawing.Color.Transparent;
            this.Total_Label_Tmp.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Label_Tmp.ForeColor = System.Drawing.Color.White;
            this.Total_Label_Tmp.Location = new System.Drawing.Point(38, 38);
            this.Total_Label_Tmp.Name = "Total_Label_Tmp";
            this.Total_Label_Tmp.Size = new System.Drawing.Size(65, 32);
            this.Total_Label_Tmp.TabIndex = 28;
            this.Total_Label_Tmp.Text = "Total : ";
            this.Total_Label_Tmp.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Order_Nested_Flow_Layout_Panel
            // 
            this.Order_Nested_Flow_Layout_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Order_Nested_Flow_Layout_Panel.AutoScroll = true;
            this.Order_Nested_Flow_Layout_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.Order_Nested_Flow_Layout_Panel.Location = new System.Drawing.Point(11, 60);
            this.Order_Nested_Flow_Layout_Panel.Name = "Order_Nested_Flow_Layout_Panel";
            this.Order_Nested_Flow_Layout_Panel.Size = new System.Drawing.Size(295, 289);
            this.Order_Nested_Flow_Layout_Panel.TabIndex = 0;
            // 
            // Home_Bar_Main_Panel
            // 
            this.Home_Bar_Main_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Home_Bar_Main_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Home_Bar_Main_Panel.Controls.Add(this.Home_Nested_Panel_Labels);
            this.Home_Bar_Main_Panel.Controls.Add(this.Home_Nested_Panel_Controlers);
            this.Home_Bar_Main_Panel.Location = new System.Drawing.Point(0, 0);
            this.Home_Bar_Main_Panel.Name = "Home_Bar_Main_Panel";
            this.Home_Bar_Main_Panel.Size = new System.Drawing.Size(658, 110);
            this.Home_Bar_Main_Panel.TabIndex = 10;
            // 
            // Home_Nested_Panel_Labels
            // 
            this.Home_Nested_Panel_Labels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Home_Nested_Panel_Labels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.Home_Nested_Panel_Labels.Controls.Add(this.Date_Label);
            this.Home_Nested_Panel_Labels.Controls.Add(this.Khayaal_Label);
            this.Home_Nested_Panel_Labels.Location = new System.Drawing.Point(0, 0);
            this.Home_Nested_Panel_Labels.Name = "Home_Nested_Panel_Labels";
            this.Home_Nested_Panel_Labels.Size = new System.Drawing.Size(321, 110);
            this.Home_Nested_Panel_Labels.TabIndex = 1;
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
            // Home_Nested_Panel_Controlers
            // 
            this.Home_Nested_Panel_Controlers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Home_Nested_Panel_Controlers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.Home_Nested_Panel_Controlers.Controls.Add(this.Category_Label);
            this.Home_Nested_Panel_Controlers.Controls.Add(this.Category_Combo_Box);
            this.Home_Nested_Panel_Controlers.Controls.Add(this.Search_Text_Box);
            this.Home_Nested_Panel_Controlers.Controls.Add(this.Add_Item_Button);
            this.Home_Nested_Panel_Controlers.Location = new System.Drawing.Point(321, 0);
            this.Home_Nested_Panel_Controlers.Name = "Home_Nested_Panel_Controlers";
            this.Home_Nested_Panel_Controlers.Size = new System.Drawing.Size(337, 110);
            this.Home_Nested_Panel_Controlers.TabIndex = 0;
            // 
            // Category_Label
            // 
            this.Category_Label.BackColor = System.Drawing.Color.Transparent;
            this.Category_Label.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Category_Label.Location = new System.Drawing.Point(10, 95);
            this.Category_Label.Name = "Category_Label";
            this.Category_Label.Size = new System.Drawing.Size(55, 15);
            this.Category_Label.TabIndex = 28;
            this.Category_Label.Text = "*Category";
            this.Category_Label.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Category_Combo_Box.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
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
            this.Search_Text_Box.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
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
            this.Search_Text_Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Search_Text_Box_KeyPress);
            // 
            // Add_Item_Button
            // 
            this.Add_Item_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Add_Item_Button.BorderRadius = 10;
            this.Add_Item_Button.CheckedState.Parent = this.Add_Item_Button;
            this.Add_Item_Button.CustomImages.Parent = this.Add_Item_Button;
            this.Add_Item_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
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
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this.Order_Nested_Flow_Layout_Panel;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this.Total_Nested_Panel;
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
            this.Total_Nested_Panel.ResumeLayout(false);
            this.Total_Nested_Panel.PerformLayout();
            this.Home_Bar_Main_Panel.ResumeLayout(false);
            this.Home_Nested_Panel_Labels.ResumeLayout(false);
            this.Home_Nested_Panel_Labels.PerformLayout();
            this.Home_Nested_Panel_Controlers.ResumeLayout(false);
            this.Home_Nested_Panel_Controlers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource restaurantCafeDataSetBindingSource;
        private System.Windows.Forms.FlowLayoutPanel Order_Flow_Layout_Panel;
        private System.Windows.Forms.Panel Items_Main_Panel;
        public System.Windows.Forms.Panel Order_Main_Panel;
        private System.Windows.Forms.FlowLayoutPanel Items_Nested_Flow_Layout_Panel;
        private System.Windows.Forms.Panel Home_Bar_Main_Panel;
        private Guna.UI2.WinForms.Guna2Button Add_Item_Button;
        private Guna.UI2.WinForms.Guna2ComboBox Category_Combo_Box;
        private System.Windows.Forms.Panel Home_Nested_Panel_Labels;
        private System.Windows.Forms.Panel Home_Nested_Panel_Controlers;
        private Guna.UI2.WinForms.Guna2HtmlLabel Date_Label;
        private Guna.UI2.WinForms.Guna2HtmlLabel Khayaal_Label;
        private Guna.UI2.WinForms.Guna2TextBox Search_Text_Box;
        private Guna.UI2.WinForms.Guna2HtmlLabel Order_Label;
        private Guna.UI2.WinForms.Guna2Button Clear_All_Button;
        private System.Windows.Forms.Panel Total_Nested_Panel;
        private System.Windows.Forms.FlowLayoutPanel Order_Nested_Flow_Layout_Panel;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Guna.UI2.WinForms.Guna2HtmlLabel Total_Label_Value;
        private Guna.UI2.WinForms.Guna2HtmlLabel Dolaar_Sign_Label;
        private Guna.UI2.WinForms.Guna2HtmlLabel Total_Label_Tmp;
        private Guna.UI2.WinForms.Guna2Button Print_and_Save_Button;
        private Guna.UI2.WinForms.Guna2Button Save_Button;
        private Guna.UI2.WinForms.Guna2HtmlLabel Category_Label;
    }
}