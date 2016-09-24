namespace ProductProcessManagement.Reports
{
    partial class Work_Orders_vs_Time
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
            this.workordersvstimeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pPReports = new ProductProcessManagement.PPReports();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.work_orders_vs_timeTableAdapter = new ProductProcessManagement.PPReportsTableAdapters.work_orders_vs_timeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.workordersvstimeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPReports)).BeginInit();
            this.SuspendLayout();
            // 
            // workordersvstimeBindingSource
            // 
            this.workordersvstimeBindingSource.DataMember = "work_orders_vs_time";
            this.workordersvstimeBindingSource.DataSource = this.pPReports;
            // 
            // pPReports
            // 
            this.pPReports.DataSetName = "PPReports";
            this.pPReports.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.workordersvstimeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProductProcessManagement.Reports.Work_Orders_vs_Time.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(675, 580);
            this.reportViewer1.TabIndex = 1;
            // 
            // work_orders_vs_timeTableAdapter
            // 
            this.work_orders_vs_timeTableAdapter.ClearBeforeFill = true;
            // 
            // Work_Orders_vs_Time
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(675, 580);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Work_Orders_vs_Time";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Work Orders vs Time";
            this.Load += new System.EventHandler(this.Work_Orders_vs_Time_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workordersvstimeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPReports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private PPReports pPReports;
        private System.Windows.Forms.BindingSource workordersvstimeBindingSource;
        private PPReportsTableAdapters.work_orders_vs_timeTableAdapter work_orders_vs_timeTableAdapter;
    }
}