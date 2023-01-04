namespace Khayaal_SAHM.Main_Form_and_Children_Forms_AR.Purchases_Form_and_Mdi_Forms_AR
{
    partial class Purchases_Form_AR
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Name_Combo_Box = new Guna.UI2.WinForms.Guna2ComboBox();
            this.From_Date_Picker = new System.Windows.Forms.DateTimePicker();
            this.To_Date_Picker = new System.Windows.Forms.DateTimePicker();
            this.Name_Label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.From_Label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.To_Label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Count_Label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Count_Value_Label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Purchases_Table = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sub_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Table_Croll_Bar = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.Add_Purchase_Button = new Guna.UI2.WinForms.Guna2Button();
            this.Sum_Sub_Total_Value_Label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Sum_Sub_Total_Label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Sum_Qty_Value_Label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Sum_Qty_Label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Purchases_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // Name_Combo_Box
            // 
            this.Name_Combo_Box.BackColor = System.Drawing.Color.Transparent;
            this.Name_Combo_Box.BorderRadius = 10;
            this.Name_Combo_Box.BorderThickness = 0;
            this.Name_Combo_Box.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Name_Combo_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Name_Combo_Box.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(67)))));
            this.Name_Combo_Box.FocusedColor = System.Drawing.Color.Empty;
            this.Name_Combo_Box.FocusedState.Parent = this.Name_Combo_Box;
            this.Name_Combo_Box.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name_Combo_Box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Name_Combo_Box.FormattingEnabled = true;
            this.Name_Combo_Box.HoverState.Parent = this.Name_Combo_Box;
            this.Name_Combo_Box.ItemHeight = 30;
            this.Name_Combo_Box.ItemsAppearance.Parent = this.Name_Combo_Box;
            this.Name_Combo_Box.Location = new System.Drawing.Point(52, 43);
            this.Name_Combo_Box.Margin = new System.Windows.Forms.Padding(2);
            this.Name_Combo_Box.Name = "Name_Combo_Box";
            this.Name_Combo_Box.ShadowDecoration.Parent = this.Name_Combo_Box;
            this.Name_Combo_Box.Size = new System.Drawing.Size(231, 36);
            this.Name_Combo_Box.TabIndex = 5;
            this.Name_Combo_Box.SelectedIndexChanged += new System.EventHandler(this.Category_Combo_Box_SelectedIndexChanged);
            // 
            // From_Date_Picker
            // 
            this.From_Date_Picker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.From_Date_Picker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(67)))));
            this.From_Date_Picker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(67)))));
            this.From_Date_Picker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(67)))));
            this.From_Date_Picker.CustomFormat = "";
            this.From_Date_Picker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.From_Date_Picker.Location = new System.Drawing.Point(364, 59);
            this.From_Date_Picker.Margin = new System.Windows.Forms.Padding(2);
            this.From_Date_Picker.Name = "From_Date_Picker";
            this.From_Date_Picker.Size = new System.Drawing.Size(121, 20);
            this.From_Date_Picker.TabIndex = 7;
            this.From_Date_Picker.ValueChanged += new System.EventHandler(this.From_Date_Picker_ValueChanged);
            // 
            // To_Date_Picker
            // 
            this.To_Date_Picker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.To_Date_Picker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(67)))));
            this.To_Date_Picker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(67)))));
            this.To_Date_Picker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(67)))));
            this.To_Date_Picker.CustomFormat = "";
            this.To_Date_Picker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.To_Date_Picker.Location = new System.Drawing.Point(566, 59);
            this.To_Date_Picker.Margin = new System.Windows.Forms.Padding(2);
            this.To_Date_Picker.Name = "To_Date_Picker";
            this.To_Date_Picker.Size = new System.Drawing.Size(121, 20);
            this.To_Date_Picker.TabIndex = 8;
            this.To_Date_Picker.ValueChanged += new System.EventHandler(this.To_Date_Picker_ValueChanged);
            // 
            // Name_Label
            // 
            this.Name_Label.BackColor = System.Drawing.Color.Transparent;
            this.Name_Label.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(158)))), ((int)(((byte)(163)))));
            this.Name_Label.Location = new System.Drawing.Point(52, 11);
            this.Name_Label.Margin = new System.Windows.Forms.Padding(2);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(53, 27);
            this.Name_Label.TabIndex = 11;
            this.Name_Label.Text = "Name";
            // 
            // From_Label
            // 
            this.From_Label.BackColor = System.Drawing.Color.Transparent;
            this.From_Label.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(158)))), ((int)(((byte)(163)))));
            this.From_Label.Location = new System.Drawing.Point(364, 11);
            this.From_Label.Margin = new System.Windows.Forms.Padding(2);
            this.From_Label.Name = "From_Label";
            this.From_Label.Size = new System.Drawing.Size(46, 27);
            this.From_Label.TabIndex = 12;
            this.From_Label.Text = "From";
            // 
            // To_Label
            // 
            this.To_Label.BackColor = System.Drawing.Color.Transparent;
            this.To_Label.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.To_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(158)))), ((int)(((byte)(163)))));
            this.To_Label.Location = new System.Drawing.Point(566, 11);
            this.To_Label.Margin = new System.Windows.Forms.Padding(2);
            this.To_Label.Name = "To_Label";
            this.To_Label.Size = new System.Drawing.Size(25, 27);
            this.To_Label.TabIndex = 13;
            this.To_Label.Text = "To";
            // 
            // Count_Label
            // 
            this.Count_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Count_Label.BackColor = System.Drawing.Color.Transparent;
            this.Count_Label.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Count_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(158)))), ((int)(((byte)(163)))));
            this.Count_Label.Location = new System.Drawing.Point(49, 543);
            this.Count_Label.Margin = new System.Windows.Forms.Padding(2);
            this.Count_Label.Name = "Count_Label";
            this.Count_Label.Size = new System.Drawing.Size(64, 27);
            this.Count_Label.TabIndex = 14;
            this.Count_Label.Text = "Count : ";
            // 
            // Count_Value_Label
            // 
            this.Count_Value_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Count_Value_Label.BackColor = System.Drawing.Color.Transparent;
            this.Count_Value_Label.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Count_Value_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(158)))), ((int)(((byte)(163)))));
            this.Count_Value_Label.Location = new System.Drawing.Point(117, 544);
            this.Count_Value_Label.Margin = new System.Windows.Forms.Padding(2);
            this.Count_Value_Label.Name = "Count_Value_Label";
            this.Count_Value_Label.Size = new System.Drawing.Size(13, 27);
            this.Count_Value_Label.TabIndex = 15;
            this.Count_Value_Label.Text = "0";
            // 
            // Purchases_Table
            // 
            this.Purchases_Table.AllowUserToAddRows = false;
            this.Purchases_Table.AllowUserToDeleteRows = false;
            this.Purchases_Table.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(110)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(158)))), ((int)(((byte)(163)))));
            this.Purchases_Table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.Purchases_Table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Purchases_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Purchases_Table.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.Purchases_Table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Purchases_Table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Purchases_Table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(86)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(123)))), ((int)(((byte)(124)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Purchases_Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.Purchases_Table.ColumnHeadersHeight = 48;
            this.Purchases_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Purchases_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Quantity,
            this.Unit_Price,
            this.Sub_Total,
            this.Date,
            this.Notes,
            this.Delete});
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(158)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(110)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Purchases_Table.DefaultCellStyle = dataGridViewCellStyle22;
            this.Purchases_Table.EnableHeadersVisualStyles = false;
            this.Purchases_Table.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.Purchases_Table.Location = new System.Drawing.Point(49, 100);
            this.Purchases_Table.MultiSelect = false;
            this.Purchases_Table.Name = "Purchases_Table";
            this.Purchases_Table.ReadOnly = true;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(86)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(123)))), ((int)(((byte)(124)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Purchases_Table.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.Purchases_Table.RowHeadersVisible = false;
            this.Purchases_Table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(158)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(110)))), ((int)(((byte)(123)))));
            this.Purchases_Table.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.Purchases_Table.RowTemplate.Height = 37;
            this.Purchases_Table.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Purchases_Table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Purchases_Table.Size = new System.Drawing.Size(875, 439);
            this.Purchases_Table.TabIndex = 17;
            this.Purchases_Table.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.Purchases_Table.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.Purchases_Table.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Purchases_Table.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(110)))), ((int)(((byte)(123)))));
            this.Purchases_Table.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.Purchases_Table.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(158)))), ((int)(((byte)(163)))));
            this.Purchases_Table.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.Purchases_Table.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.Purchases_Table.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(86)))), ((int)(((byte)(104)))));
            this.Purchases_Table.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Purchases_Table.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Purchases_Table.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Purchases_Table.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Purchases_Table.ThemeStyle.HeaderStyle.Height = 48;
            this.Purchases_Table.ThemeStyle.ReadOnly = true;
            this.Purchases_Table.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.Purchases_Table.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Purchases_Table.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Purchases_Table.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(158)))), ((int)(((byte)(163)))));
            this.Purchases_Table.ThemeStyle.RowsStyle.Height = 37;
            this.Purchases_Table.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.Purchases_Table.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(110)))), ((int)(((byte)(123)))));
            this.Purchases_Table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Purchases_Table_CellContentClick);
            this.Purchases_Table.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.Best_Seller_Table_RowsAdded);
            this.Purchases_Table.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.Best_Seller_Table_RowsRemoved);
            // 
            // Column1
            // 
            dataGridViewCellStyle15.Format = "N0";
            dataGridViewCellStyle15.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle15;
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle16;
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Quantity
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.Format = "N2";
            dataGridViewCellStyle17.NullValue = null;
            this.Quantity.DefaultCellStyle = dataGridViewCellStyle17;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Unit_Price
            // 
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.Format = "C2";
            dataGridViewCellStyle18.NullValue = null;
            this.Unit_Price.DefaultCellStyle = dataGridViewCellStyle18;
            this.Unit_Price.HeaderText = "Unit Price";
            this.Unit_Price.Name = "Unit_Price";
            this.Unit_Price.ReadOnly = true;
            this.Unit_Price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Unit_Price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Sub_Total
            // 
            dataGridViewCellStyle19.Format = "C2";
            dataGridViewCellStyle19.NullValue = null;
            this.Sub_Total.DefaultCellStyle = dataGridViewCellStyle19;
            this.Sub_Total.HeaderText = "Sub Total";
            this.Sub_Total.Name = "Sub_Total";
            this.Sub_Total.ReadOnly = true;
            this.Sub_Total.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Sub_Total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Date
            // 
            dataGridViewCellStyle20.Format = "g";
            dataGridViewCellStyle20.NullValue = null;
            this.Date.DefaultCellStyle = dataGridViewCellStyle20;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Notes
            // 
            dataGridViewCellStyle21.NullValue = "\"\"";
            this.Notes.DefaultCellStyle = dataGridViewCellStyle21;
            this.Notes.HeaderText = "Notes";
            this.Notes.Name = "Notes";
            this.Notes.ReadOnly = true;
            this.Notes.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Notes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Delete
            // 
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // Table_Croll_Bar
            // 
            this.Table_Croll_Bar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Table_Croll_Bar.AutoRoundedCorners = true;
            this.Table_Croll_Bar.BorderRadius = 8;
            this.Table_Croll_Bar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(110)))), ((int)(((byte)(123)))));
            this.Table_Croll_Bar.HoverState.Parent = null;
            this.Table_Croll_Bar.LargeChange = 10;
            this.Table_Croll_Bar.Location = new System.Drawing.Point(930, 151);
            this.Table_Croll_Bar.MouseWheelBarPartitions = 10;
            this.Table_Croll_Bar.Name = "Table_Croll_Bar";
            this.Table_Croll_Bar.PressedState.Parent = this.Table_Croll_Bar;
            this.Table_Croll_Bar.ScrollbarSize = 18;
            this.Table_Croll_Bar.Size = new System.Drawing.Size(18, 388);
            this.Table_Croll_Bar.TabIndex = 18;
            this.Table_Croll_Bar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(88)))), ((int)(((byte)(95)))));
            this.Table_Croll_Bar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Table_Croll_Bar_Scroll);
            // 
            // Add_Purchase_Button
            // 
            this.Add_Purchase_Button.BorderRadius = 10;
            this.Add_Purchase_Button.CheckedState.Parent = this.Add_Purchase_Button;
            this.Add_Purchase_Button.CustomImages.Parent = this.Add_Purchase_Button;
            this.Add_Purchase_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(67)))));
            this.Add_Purchase_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Purchase_Button.ForeColor = System.Drawing.Color.White;
            this.Add_Purchase_Button.HoverState.Parent = this.Add_Purchase_Button;
            this.Add_Purchase_Button.Location = new System.Drawing.Point(748, 43);
            this.Add_Purchase_Button.Name = "Add_Purchase_Button";
            this.Add_Purchase_Button.ShadowDecoration.Parent = this.Add_Purchase_Button;
            this.Add_Purchase_Button.Size = new System.Drawing.Size(150, 36);
            this.Add_Purchase_Button.TabIndex = 23;
            this.Add_Purchase_Button.Text = "Add Purchase";
            this.Add_Purchase_Button.Click += new System.EventHandler(this.Add_Purchase_Button_Click);
            // 
            // Sum_Sub_Total_Value_Label
            // 
            this.Sum_Sub_Total_Value_Label.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Sum_Sub_Total_Value_Label.BackColor = System.Drawing.Color.Transparent;
            this.Sum_Sub_Total_Value_Label.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sum_Sub_Total_Value_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(158)))), ((int)(((byte)(163)))));
            this.Sum_Sub_Total_Value_Label.Location = new System.Drawing.Point(522, 544);
            this.Sum_Sub_Total_Value_Label.Margin = new System.Windows.Forms.Padding(2);
            this.Sum_Sub_Total_Value_Label.Name = "Sum_Sub_Total_Value_Label";
            this.Sum_Sub_Total_Value_Label.Size = new System.Drawing.Size(13, 27);
            this.Sum_Sub_Total_Value_Label.TabIndex = 25;
            this.Sum_Sub_Total_Value_Label.Text = "0";
            // 
            // Sum_Sub_Total_Label
            // 
            this.Sum_Sub_Total_Label.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Sum_Sub_Total_Label.BackColor = System.Drawing.Color.Transparent;
            this.Sum_Sub_Total_Label.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sum_Sub_Total_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(158)))), ((int)(((byte)(163)))));
            this.Sum_Sub_Total_Label.Location = new System.Drawing.Point(471, 543);
            this.Sum_Sub_Total_Label.Margin = new System.Windows.Forms.Padding(2);
            this.Sum_Sub_Total_Label.Name = "Sum_Sub_Total_Label";
            this.Sum_Sub_Total_Label.Size = new System.Drawing.Size(50, 27);
            this.Sum_Sub_Total_Label.TabIndex = 24;
            this.Sum_Sub_Total_Label.Text = "Sum : ";
            // 
            // Sum_Qty_Value_Label
            // 
            this.Sum_Qty_Value_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Sum_Qty_Value_Label.BackColor = System.Drawing.Color.Transparent;
            this.Sum_Qty_Value_Label.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sum_Qty_Value_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(158)))), ((int)(((byte)(163)))));
            this.Sum_Qty_Value_Label.Location = new System.Drawing.Point(270, 544);
            this.Sum_Qty_Value_Label.Margin = new System.Windows.Forms.Padding(2);
            this.Sum_Qty_Value_Label.Name = "Sum_Qty_Value_Label";
            this.Sum_Qty_Value_Label.Size = new System.Drawing.Size(13, 27);
            this.Sum_Qty_Value_Label.TabIndex = 27;
            this.Sum_Qty_Value_Label.Text = "0";
            // 
            // Sum_Qty_Label
            // 
            this.Sum_Qty_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Sum_Qty_Label.BackColor = System.Drawing.Color.Transparent;
            this.Sum_Qty_Label.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sum_Qty_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(158)))), ((int)(((byte)(163)))));
            this.Sum_Qty_Label.Location = new System.Drawing.Point(216, 543);
            this.Sum_Qty_Label.Margin = new System.Windows.Forms.Padding(2);
            this.Sum_Qty_Label.Name = "Sum_Qty_Label";
            this.Sum_Qty_Label.Size = new System.Drawing.Size(50, 27);
            this.Sum_Qty_Label.TabIndex = 26;
            this.Sum_Qty_Label.Text = "Sum : ";
            // 
            // Purchases_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(974, 581);
            this.Controls.Add(this.Sum_Qty_Value_Label);
            this.Controls.Add(this.Sum_Qty_Label);
            this.Controls.Add(this.Sum_Sub_Total_Value_Label);
            this.Controls.Add(this.Sum_Sub_Total_Label);
            this.Controls.Add(this.Add_Purchase_Button);
            this.Controls.Add(this.Table_Croll_Bar);
            this.Controls.Add(this.Purchases_Table);
            this.Controls.Add(this.Count_Value_Label);
            this.Controls.Add(this.Count_Label);
            this.Controls.Add(this.To_Label);
            this.Controls.Add(this.From_Label);
            this.Controls.Add(this.Name_Label);
            this.Controls.Add(this.To_Date_Picker);
            this.Controls.Add(this.From_Date_Picker);
            this.Controls.Add(this.Name_Combo_Box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Purchases_Form";
            this.Text = "Best_Seller_Form";
            ((System.ComponentModel.ISupportInitialize)(this.Purchases_Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox Name_Combo_Box;
        private System.Windows.Forms.DateTimePicker From_Date_Picker;
        private System.Windows.Forms.DateTimePicker To_Date_Picker;
        private Guna.UI2.WinForms.Guna2HtmlLabel Name_Label;
        private Guna.UI2.WinForms.Guna2HtmlLabel From_Label;
        private Guna.UI2.WinForms.Guna2HtmlLabel To_Label;
        private Guna.UI2.WinForms.Guna2HtmlLabel Count_Label;
        private Guna.UI2.WinForms.Guna2HtmlLabel Count_Value_Label;
        private Guna.UI2.WinForms.Guna2DataGridView Purchases_Table;
        private Guna.UI2.WinForms.Guna2VScrollBar Table_Croll_Bar;
        private Guna.UI2.WinForms.Guna2Button Add_Purchase_Button;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sub_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private Guna.UI2.WinForms.Guna2HtmlLabel Sum_Sub_Total_Value_Label;
        private Guna.UI2.WinForms.Guna2HtmlLabel Sum_Sub_Total_Label;
        private Guna.UI2.WinForms.Guna2HtmlLabel Sum_Qty_Value_Label;
        private Guna.UI2.WinForms.Guna2HtmlLabel Sum_Qty_Label;
    }
}