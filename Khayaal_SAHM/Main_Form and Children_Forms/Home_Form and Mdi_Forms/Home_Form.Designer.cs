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
            this.Task_Bar = new Guna.UI2.WinForms.Guna2Panel();
            this.Date_Lbl = new System.Windows.Forms.Label();
            this.Name_Lbl = new System.Windows.Forms.Label();
            this.Search_Bar = new Guna.UI2.WinForms.Guna2TextBox();
            this.Oder_Lbl = new System.Windows.Forms.Label();
            this.Clear_Btn = new FontAwesome.Sharp.IconButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Btn_Add_Item = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Item_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restaurantCafeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tax_Lbl = new System.Windows.Forms.Label();
            this.Sub_Lbl = new System.Windows.Forms.Label();
            this.Btn_Print = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Task_Bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantCafeDataSetBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Task_Bar
            // 
            this.Task_Bar.Controls.Add(this.Date_Lbl);
            this.Task_Bar.Controls.Add(this.Name_Lbl);
            this.Task_Bar.Controls.Add(this.Search_Bar);
            this.Task_Bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Task_Bar.Location = new System.Drawing.Point(0, 0);
            this.Task_Bar.Name = "Task_Bar";
            this.Task_Bar.ShadowDecoration.Parent = this.Task_Bar;
            this.Task_Bar.Size = new System.Drawing.Size(974, 52);
            this.Task_Bar.TabIndex = 0;
            // 
            // Date_Lbl
            // 
            this.Date_Lbl.AutoSize = true;
            this.Date_Lbl.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_Lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(88)))), ((int)(((byte)(97)))));
            this.Date_Lbl.Location = new System.Drawing.Point(213, 10);
            this.Date_Lbl.Name = "Date_Lbl";
            this.Date_Lbl.Size = new System.Drawing.Size(274, 29);
            this.Date_Lbl.TabIndex = 3;
            this.Date_Lbl.Text = "12/18/2022 10:33:39 PM";
            // 
            // Name_Lbl
            // 
            this.Name_Lbl.AutoSize = true;
            this.Name_Lbl.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(86)))), ((int)(((byte)(104)))));
            this.Name_Lbl.Location = new System.Drawing.Point(12, 10);
            this.Name_Lbl.Name = "Name_Lbl";
            this.Name_Lbl.Size = new System.Drawing.Size(123, 25);
            this.Name_Lbl.TabIndex = 2;
            this.Name_Lbl.Text = "Khayaal Cafe";
            // 
            // Search_Bar
            // 
            this.Search_Bar.BorderRadius = 10;
            this.Search_Bar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Search_Bar.DefaultText = "";
            this.Search_Bar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Search_Bar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Search_Bar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Search_Bar.DisabledState.Parent = this.Search_Bar;
            this.Search_Bar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Search_Bar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.Search_Bar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Search_Bar.FocusedState.Parent = this.Search_Bar;
            this.Search_Bar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(88)))), ((int)(((byte)(95)))));
            this.Search_Bar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Search_Bar.HoverState.Parent = this.Search_Bar;
            this.Search_Bar.Location = new System.Drawing.Point(570, 12);
            this.Search_Bar.Name = "Search_Bar";
            this.Search_Bar.PasswordChar = '\0';
            this.Search_Bar.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(88)))), ((int)(((byte)(97)))));
            this.Search_Bar.PlaceholderText = "Search Menu Here";
            this.Search_Bar.SelectedText = "";
            this.Search_Bar.ShadowDecoration.Parent = this.Search_Bar;
            this.Search_Bar.Size = new System.Drawing.Size(156, 27);
            this.Search_Bar.TabIndex = 0;
            // 
            // Oder_Lbl
            // 
            this.Oder_Lbl.AutoSize = true;
            this.Oder_Lbl.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Oder_Lbl.ForeColor = System.Drawing.Color.White;
            this.Oder_Lbl.Location = new System.Drawing.Point(18, 11);
            this.Oder_Lbl.Name = "Oder_Lbl";
            this.Oder_Lbl.Size = new System.Drawing.Size(53, 23);
            this.Oder_Lbl.TabIndex = 3;
            this.Oder_Lbl.Text = "Order";
            // 
            // Clear_Btn
            // 
            this.Clear_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Clear_Btn.FlatAppearance.BorderSize = 0;
            this.Clear_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear_Btn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(110)))), ((int)(((byte)(123)))));
            this.Clear_Btn.IconChar = FontAwesome.Sharp.IconChar.X;
            this.Clear_Btn.IconColor = System.Drawing.Color.Red;
            this.Clear_Btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Clear_Btn.IconSize = 22;
            this.Clear_Btn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Clear_Btn.Location = new System.Drawing.Point(133, 4);
            this.Clear_Btn.Name = "Clear_Btn";
            this.Clear_Btn.Size = new System.Drawing.Size(73, 27);
            this.Clear_Btn.TabIndex = 1;
            this.Clear_Btn.Text = "Clear ";
            this.Clear_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Clear_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Clear_Btn.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 52);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(974, 529);
            this.splitContainer1.SplitterDistance = 752;
            this.splitContainer1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.Controls.Add(this.Btn_Add_Item);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(823, 529);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Btn_Add_Item
            // 
            this.Btn_Add_Item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(86)))), ((int)(((byte)(104)))));
            this.Btn_Add_Item.FlatAppearance.BorderSize = 0;
            this.Btn_Add_Item.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Add_Item.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Add_Item.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.Btn_Add_Item.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.Btn_Add_Item.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Add_Item.IconSize = 30;
            this.Btn_Add_Item.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Add_Item.Location = new System.Drawing.Point(3, 3);
            this.Btn_Add_Item.Name = "Btn_Add_Item";
            this.Btn_Add_Item.Size = new System.Drawing.Size(132, 48);
            this.Btn_Add_Item.TabIndex = 0;
            this.Btn_Add_Item.Text = "Add Item";
            this.Btn_Add_Item.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Btn_Print);
            this.panel1.Controls.Add(this.Clear_Btn);
            this.panel1.Controls.Add(this.Oder_Lbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 529);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item_Name,
            this.Qty,
            this.Price});
            this.dataGridView1.DataSource = this.restaurantCafeDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(235, 310);
            this.dataGridView1.TabIndex = 6;
            // 
            // Item_Name
            // 
            this.Item_Name.HeaderText = "Item Name";
            this.Item_Name.Name = "Item_Name";
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.guna2GradientPanel1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Tax_Lbl);
            this.panel2.Controls.Add(this.Sub_Lbl);
            this.panel2.Location = new System.Drawing.Point(22, 353);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 120);
            this.panel2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(152, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "37.5$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total";
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(88)))), ((int)(((byte)(95)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(86)))), ((int)(((byte)(104)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(1, 56);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(199, 10);
            this.guna2GradientPanel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(152, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "37.5$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(152, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "37.5$";
            // 
            // Tax_Lbl
            // 
            this.Tax_Lbl.AutoSize = true;
            this.Tax_Lbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.Tax_Lbl.ForeColor = System.Drawing.Color.White;
            this.Tax_Lbl.Location = new System.Drawing.Point(14, 33);
            this.Tax_Lbl.Name = "Tax_Lbl";
            this.Tax_Lbl.Size = new System.Drawing.Size(30, 20);
            this.Tax_Lbl.TabIndex = 1;
            this.Tax_Lbl.Text = "Tax";
            // 
            // Sub_Lbl
            // 
            this.Sub_Lbl.AutoSize = true;
            this.Sub_Lbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sub_Lbl.ForeColor = System.Drawing.Color.White;
            this.Sub_Lbl.Location = new System.Drawing.Point(14, 13);
            this.Sub_Lbl.Name = "Sub_Lbl";
            this.Sub_Lbl.Size = new System.Drawing.Size(69, 20);
            this.Sub_Lbl.TabIndex = 0;
            this.Sub_Lbl.Text = "Sub Total";
            // 
            // Btn_Print
            // 
            this.Btn_Print.BorderRadius = 10;
            this.Btn_Print.CheckedState.Parent = this.Btn_Print;
            this.Btn_Print.CustomImages.Parent = this.Btn_Print;
            this.Btn_Print.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(86)))), ((int)(((byte)(104)))));
            this.Btn_Print.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_Print.ForeColor = System.Drawing.Color.White;
            this.Btn_Print.HoverState.Parent = this.Btn_Print;
            this.Btn_Print.Location = new System.Drawing.Point(25, 479);
            this.Btn_Print.Name = "Btn_Print";
            this.Btn_Print.ShadowDecoration.Parent = this.Btn_Print;
            this.Btn_Print.Size = new System.Drawing.Size(204, 61);
            this.Btn_Print.TabIndex = 4;
            this.Btn_Print.Text = "Print Bill";
            // 
            // Home_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(974, 581);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.Task_Bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home_Form";
            this.Text = "Home_Form";
            this.Task_Bar.ResumeLayout(false);
            this.Task_Bar.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantCafeDataSetBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Task_Bar;
        private Guna.UI2.WinForms.Guna2TextBox Search_Bar;
        private System.Windows.Forms.Label Name_Lbl;
        private FontAwesome.Sharp.IconButton Clear_Btn;
        private System.Windows.Forms.Label Oder_Lbl;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton Btn_Add_Item;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Tax_Lbl;
        private System.Windows.Forms.Label Sub_Lbl;
        private Guna.UI2.WinForms.Guna2Button Btn_Print;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label Date_Lbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.BindingSource restaurantCafeDataSetBindingSource;
    }
}