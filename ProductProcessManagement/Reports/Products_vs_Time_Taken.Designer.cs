namespace ProductProcessManagement.Reports
{
    partial class Products_vs_Time_Taken
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pPReports = new ProductProcessManagement.PPReports();
            this.productsvstimetakenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.products_vs_time_takenTableAdapter = new ProductProcessManagement.PPReportsTableAdapters.products_vs_time_takenTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pPReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsvstimetakenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Products_vs_Time_Taken";
            reportDataSource1.Value = this.productsvstimetakenBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProductProcessManagement.Reports.Products_vs_Time_Taken.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(595, 550);
            this.reportViewer1.TabIndex = 0;
            // 
            // pPReports
            // 
            this.pPReports.DataSetName = "PPReports";
            this.pPReports.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsvstimetakenBindingSource
            // 
            this.productsvstimetakenBindingSource.DataMember = "products_vs_time_taken";
            this.productsvstimetakenBindingSource.DataSource = this.pPReports;
            // 
            // products_vs_time_takenTableAdapter
            // 
            this.products_vs_time_takenTableAdapter.ClearBeforeFill = true;
            // 
            // Products_vs_Time_Taken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 550);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Products_vs_Time_Taken";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products vs Time Taken";
            this.Load += new System.EventHandler(this.Products_vs_Time_Taken_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pPReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsvstimetakenBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private PPReports pPReports;
        private System.Windows.Forms.BindingSource productsvstimetakenBindingSource;
        private PPReportsTableAdapters.products_vs_time_takenTableAdapter products_vs_time_takenTableAdapter;
    }
}