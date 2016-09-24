namespace ProductProcessManagement.Reports
{
    partial class Products_vs_Time
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
            this.productsvstimeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.products_vs_timeTableAdapter = new ProductProcessManagement.PPReportsTableAdapters.products_vs_timeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pPReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsvstimeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Products_vs_Time";
            reportDataSource1.Value = this.productsvstimeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProductProcessManagement.Reports.Products_vs_Time.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(656, 574);
            this.reportViewer1.TabIndex = 0;
            // 
            // pPReports
            // 
            this.pPReports.DataSetName = "PPReports";
            this.pPReports.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsvstimeBindingSource
            // 
            this.productsvstimeBindingSource.DataMember = "products_vs_time";
            this.productsvstimeBindingSource.DataSource = this.pPReports;
            // 
            // products_vs_timeTableAdapter
            // 
            this.products_vs_timeTableAdapter.ClearBeforeFill = true;
            // 
            // Products_vs_Time
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 574);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Products_vs_Time";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products vs Time";
            this.Load += new System.EventHandler(this.Products_vs_Time_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pPReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsvstimeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private PPReports pPReports;
        private System.Windows.Forms.BindingSource productsvstimeBindingSource;
        private PPReportsTableAdapters.products_vs_timeTableAdapter products_vs_timeTableAdapter;

    }
}