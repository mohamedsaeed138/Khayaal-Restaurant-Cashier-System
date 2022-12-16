namespace Khayaal_SAHM.Main_Form_and_Children_Forms.Bills_Form_and_Mdi_Forms.Print
{
    partial class Print_Bill
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Bills_DataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurant_CafeDataSet = new Khayaal_SAHM.Restaurant_CafeDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.restaurantCafeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantCafeDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantCafeDataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Bills_DataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurant_CafeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantCafeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantCafeDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantCafeDataSetBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // Bills_DataBindingSource
            // 
            this.Bills_DataBindingSource.DataMember = "Bills_Data";
            this.Bills_DataBindingSource.DataSource = this.restaurant_CafeDataSet;
            // 
            // restaurant_CafeDataSet
            // 
            this.restaurant_CafeDataSet.DataSetName = "Restaurant_CafeDataSet";
            this.restaurant_CafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Bill_Set";
            reportDataSource1.Value = this.restaurantCafeDataSetBindingSource2;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Khayaal_SAHM.Main_Form and Children_Forms.Bills_Form and Mdi_Forms.Print.Report1." +
    "rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(430, 482);
            this.reportViewer1.TabIndex = 0;
            // 
            // restaurantCafeDataSetBindingSource
            // 
            this.restaurantCafeDataSetBindingSource.DataSource = this.restaurant_CafeDataSet;
            this.restaurantCafeDataSetBindingSource.Position = 0;
            // 
            // restaurantCafeDataSetBindingSource1
            // 
            this.restaurantCafeDataSetBindingSource1.DataSource = this.restaurant_CafeDataSet;
            this.restaurantCafeDataSetBindingSource1.Position = 0;
            // 
            // restaurantCafeDataSetBindingSource2
            // 
            this.restaurantCafeDataSetBindingSource2.DataSource = this.restaurant_CafeDataSet;
            this.restaurantCafeDataSetBindingSource2.Position = 0;
            // 
            // Print_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 482);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Print_Bill";
            this.Text = "Print_Bill";
            this.Load += new System.EventHandler(this.Print_Bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Bills_DataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurant_CafeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantCafeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantCafeDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantCafeDataSetBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource restaurantCafeDataSetBindingSource;
        private Restaurant_CafeDataSet restaurant_CafeDataSet;
        private System.Windows.Forms.BindingSource Bills_DataBindingSource;
        private System.Windows.Forms.BindingSource restaurantCafeDataSetBindingSource1;
        private System.Windows.Forms.BindingSource restaurantCafeDataSetBindingSource2;
    }
}