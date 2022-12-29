namespace Khayaal_SAHM.Main_Form_and_Children_Forms.Home_Form_and_Mdi_Forms
{
    partial class Order_User_Control
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Image_Picture_Box = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Name_Label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Price_Label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Qty_Label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Sub_Total_Label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Remove_Button = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Decrease_Button = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Increase_Button = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.Image_Picture_Box)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Image_Picture_Box
            // 
            this.Image_Picture_Box.BorderRadius = 10;
            this.Image_Picture_Box.Location = new System.Drawing.Point(4, 9);
            this.Image_Picture_Box.Name = "Image_Picture_Box";
            this.Image_Picture_Box.ShadowDecoration.Parent = this.Image_Picture_Box;
            this.Image_Picture_Box.Size = new System.Drawing.Size(38, 37);
            this.Image_Picture_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Image_Picture_Box.TabIndex = 0;
            this.Image_Picture_Box.TabStop = false;
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = false;
            this.Name_Label.BackColor = System.Drawing.Color.Transparent;
            this.Name_Label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Label.ForeColor = System.Drawing.Color.White;
            this.Name_Label.Location = new System.Drawing.Point(47, 2);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(216, 19);
            this.Name_Label.TabIndex = 1;
            this.Name_Label.Text = "Item";
            // 
            // Price_Label
            // 
            this.Price_Label.AutoSize = false;
            this.Price_Label.BackColor = System.Drawing.Color.Transparent;
            this.Price_Label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_Label.ForeColor = System.Drawing.Color.White;
            this.Price_Label.Location = new System.Drawing.Point(48, 21);
            this.Price_Label.Name = "Price_Label";
            this.Price_Label.Size = new System.Drawing.Size(46, 19);
            this.Price_Label.TabIndex = 2;
            this.Price_Label.Text = "100000";
            this.Price_Label.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Qty_Label
            // 
            this.Qty_Label.AutoSize = false;
            this.Qty_Label.BackColor = System.Drawing.Color.Transparent;
            this.Qty_Label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qty_Label.ForeColor = System.Drawing.Color.White;
            this.Qty_Label.Location = new System.Drawing.Point(149, 21);
            this.Qty_Label.Name = "Qty_Label";
            this.Qty_Label.Size = new System.Drawing.Size(46, 19);
            this.Qty_Label.TabIndex = 3;
            this.Qty_Label.Text = "100000";
            this.Qty_Label.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Sub_Total_Label
            // 
            this.Sub_Total_Label.AutoSize = false;
            this.Sub_Total_Label.BackColor = System.Drawing.Color.Transparent;
            this.Sub_Total_Label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sub_Total_Label.ForeColor = System.Drawing.Color.White;
            this.Sub_Total_Label.Location = new System.Drawing.Point(215, 21);
            this.Sub_Total_Label.Name = "Sub_Total_Label";
            this.Sub_Total_Label.Size = new System.Drawing.Size(46, 19);
            this.Sub_Total_Label.TabIndex = 4;
            this.Sub_Total_Label.Text = "100000";
            this.Sub_Total_Label.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Remove_Button
            // 
            this.Remove_Button.CheckedState.Parent = this.Remove_Button;
            this.Remove_Button.CustomImages.Parent = this.Remove_Button;
            this.Remove_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Remove_Button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove_Button.ForeColor = System.Drawing.Color.White;
            this.Remove_Button.HoverState.Parent = this.Remove_Button;
            this.Remove_Button.Location = new System.Drawing.Point(259, 16);
            this.Remove_Button.Name = "Remove_Button";
            this.Remove_Button.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Remove_Button.ShadowDecoration.Parent = this.Remove_Button;
            this.Remove_Button.Size = new System.Drawing.Size(24, 24);
            this.Remove_Button.TabIndex = 5;
            this.Remove_Button.Text = "x";
            this.Remove_Button.Click += new System.EventHandler(this.Remove_Button_Click);
            // 
            // Decrease_Button
            // 
            this.Decrease_Button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(203)))), ((int)(((byte)(103)))));
            this.Decrease_Button.BorderThickness = 2;
            this.Decrease_Button.CheckedState.Parent = this.Decrease_Button;
            this.Decrease_Button.CustomImages.Parent = this.Decrease_Button;
            this.Decrease_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.Decrease_Button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Decrease_Button.ForeColor = System.Drawing.Color.White;
            this.Decrease_Button.HoverState.Parent = this.Decrease_Button;
            this.Decrease_Button.Location = new System.Drawing.Point(195, 16);
            this.Decrease_Button.Name = "Decrease_Button";
            this.Decrease_Button.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Decrease_Button.ShadowDecoration.Parent = this.Decrease_Button;
            this.Decrease_Button.Size = new System.Drawing.Size(24, 24);
            this.Decrease_Button.TabIndex = 7;
            this.Decrease_Button.Text = "-";
            this.Decrease_Button.Click += new System.EventHandler(this.Decrease_Button_Click);
            // 
            // Increase_Button
            // 
            this.Increase_Button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(203)))), ((int)(((byte)(103)))));
            this.Increase_Button.BorderThickness = 2;
            this.Increase_Button.CheckedState.Parent = this.Increase_Button;
            this.Increase_Button.CustomImages.Parent = this.Increase_Button;
            this.Increase_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.Increase_Button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Increase_Button.ForeColor = System.Drawing.Color.White;
            this.Increase_Button.HoverState.Parent = this.Increase_Button;
            this.Increase_Button.Location = new System.Drawing.Point(129, 16);
            this.Increase_Button.Name = "Increase_Button";
            this.Increase_Button.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Increase_Button.ShadowDecoration.Parent = this.Increase_Button;
            this.Increase_Button.Size = new System.Drawing.Size(24, 24);
            this.Increase_Button.TabIndex = 8;
            this.Increase_Button.Text = "+";
            this.Increase_Button.Click += new System.EventHandler(this.Increase_Button_Click);
            // 
            // Order_User_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.Increase_Button);
            this.Controls.Add(this.Decrease_Button);
            this.Controls.Add(this.Remove_Button);
            this.Controls.Add(this.Sub_Total_Label);
            this.Controls.Add(this.Qty_Label);
            this.Controls.Add(this.Price_Label);
            this.Controls.Add(this.Name_Label);
            this.Controls.Add(this.Image_Picture_Box);
            this.Name = "Order_User_Control";
            this.Size = new System.Drawing.Size(288, 57);
            ((System.ComponentModel.ISupportInitialize)(this.Image_Picture_Box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Guna.UI2.WinForms.Guna2CircleButton Decrease_Button;
        private Guna.UI2.WinForms.Guna2CircleButton Remove_Button;
        private Guna.UI2.WinForms.Guna2HtmlLabel Sub_Total_Label;
        private Guna.UI2.WinForms.Guna2HtmlLabel Qty_Label;
        private Guna.UI2.WinForms.Guna2HtmlLabel Price_Label;
        private Guna.UI2.WinForms.Guna2HtmlLabel Name_Label;
        private Guna.UI2.WinForms.Guna2PictureBox Image_Picture_Box;
        private Guna.UI2.WinForms.Guna2CircleButton Increase_Button;
    }
}
