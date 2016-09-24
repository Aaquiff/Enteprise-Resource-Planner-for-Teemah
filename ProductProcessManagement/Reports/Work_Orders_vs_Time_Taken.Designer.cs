namespace ProductProcessManagement.Reports
{
    partial class Work_Orders_vs_Time_Taken
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
            this.workordersvstimetakenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.work_orders_vs_time_takenTableAdapter = new ProductProcessManagement.PPReportsTableAdapters.work_orders_vs_time_takenTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pPReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workordersvstimetakenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.workordersvstimetakenBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProductProcessManagement.Reports.Work_Orders_vs_Time_taken.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(693, 561);
            this.reportViewer1.TabIndex = 0;
            // 
            // pPReports
            // 
            this.pPReports.DataSetName = "PPReports";
            this.pPReports.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workordersvstimetakenBindingSource
            // 
            this.workordersvstimetakenBindingSource.DataMember = "work_orders_vs_time_taken";
            this.workordersvstimetakenBindingSource.DataSource = this.pPReports;
            // 
            // work_orders_vs_time_takenTableAdapter
            // 
            this.work_orders_vs_time_takenTableAdapter.ClearBeforeFill = true;
            // 
            // Work_Orders_vs_Time_Taken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 561);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Work_Orders_vs_Time_Taken";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Work Orders vs Time Taken";
            this.Load += new System.EventHandler(this.Work_Orders_vs_Time_Taken_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pPReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workordersvstimetakenBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private PPReports pPReports;
        private System.Windows.Forms.BindingSource workordersvstimetakenBindingSource;
        private PPReportsTableAdapters.work_orders_vs_time_takenTableAdapter work_orders_vs_time_takenTableAdapter;
    }
}