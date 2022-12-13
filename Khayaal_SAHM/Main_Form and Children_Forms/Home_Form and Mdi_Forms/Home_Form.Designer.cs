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
            this.Task_Bar = new Guna.UI2.WinForms.Guna2Panel();
            this.Name_Lbl = new System.Windows.Forms.Label();
            this.Clear_Btn = new FontAwesome.Sharp.IconButton();
            this.Search_Bar = new Guna.UI2.WinForms.Guna2TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Task_Bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Task_Bar
            // 
            this.Task_Bar.Controls.Add(this.Name_Lbl);
            this.Task_Bar.Controls.Add(this.Search_Bar);
            this.Task_Bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Task_Bar.Location = new System.Drawing.Point(0, 0);
            this.Task_Bar.Name = "Task_Bar";
            this.Task_Bar.ShadowDecoration.Parent = this.Task_Bar;
            this.Task_Bar.Size = new System.Drawing.Size(1065, 52);
            this.Task_Bar.TabIndex = 0;
            // 
            // Name_Lbl
            // 
            this.Name_Lbl.AutoSize = true;
            this.Name_Lbl.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(86)))), ((int)(((byte)(104)))));
            this.Name_Lbl.Location = new System.Drawing.Point(12, 14);
            this.Name_Lbl.Name = "Name_Lbl";
            this.Name_Lbl.Size = new System.Drawing.Size(123, 25);
            this.Name_Lbl.TabIndex = 2;
            this.Name_Lbl.Text = "Khayaal Cafe";
            // 
            // Clear_Btn
            // 
            this.Clear_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Clear_Btn.FlatAppearance.BorderSize = 0;
            this.Clear_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear_Btn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(110)))), ((int)(((byte)(123)))));
            this.Clear_Btn.IconChar = FontAwesome.Sharp.IconChar.X;
            this.Clear_Btn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.Clear_Btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Clear_Btn.IconSize = 22;
            this.Clear_Btn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Clear_Btn.Location = new System.Drawing.Point(12, 6);
            this.Clear_Btn.Name = "Clear_Btn";
            this.Clear_Btn.Size = new System.Drawing.Size(73, 27);
            this.Clear_Btn.TabIndex = 1;
            this.Clear_Btn.Text = "Clear ";
            this.Clear_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Clear_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Clear_Btn.UseVisualStyleBackColor = true;
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
            this.Search_Bar.Location = new System.Drawing.Point(453, 12);
            this.Search_Bar.Name = "Search_Bar";
            this.Search_Bar.PasswordChar = '\0';
            this.Search_Bar.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(88)))), ((int)(((byte)(97)))));
            this.Search_Bar.PlaceholderText = "Search Menu Here";
            this.Search_Bar.SelectedText = "";
            this.Search_Bar.ShadowDecoration.Parent = this.Search_Bar;
            this.Search_Bar.Size = new System.Drawing.Size(156, 27);
            this.Search_Bar.TabIndex = 0;
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
            this.splitContainer1.Panel2.Controls.Add(this.Clear_Btn);
            this.splitContainer1.Size = new System.Drawing.Size(1065, 552);
            this.splitContainer1.SplitterDistance = 964;
            this.splitContainer1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(964, 552);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Home_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1065, 604);
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
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Task_Bar;
        private Guna.UI2.WinForms.Guna2TextBox Search_Bar;
        private System.Windows.Forms.Label Name_Lbl;
        private FontAwesome.Sharp.IconButton Clear_Btn;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}