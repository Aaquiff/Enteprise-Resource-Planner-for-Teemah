namespace FinishedGoodManagement
{
    partial class Report_Viewer_New
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
            this.workorderreportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inv_itpDataSet1 = new FinishedGoodManagement.inv_itpDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.workorderreportTableAdapter = new FinishedGoodManagement.inv_itpDataSet1TableAdapters.workorderreportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.workorderreportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv_itpDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // workorderreportBindingSource
            // 
            this.workorderreportBindingSource.DataMember = "workorderreport";
            this.workorderreportBindingSource.DataSource = this.inv_itpDataSet1;
            // 
            // inv_itpDataSet1
            // 
            this.inv_itpDataSet1.DataSetName = "inv_itpDataSet1";
            this.inv_itpDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.workorderreportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FinishedGoodManagement.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(715, 498);
            this.reportViewer1.TabIndex = 0;
            // 
            // workorderreportTableAdapter
            // 
            this.workorderreportTableAdapter.ClearBeforeFill = true;
            // 
            // Report_Viewer_New
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 498);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report_Viewer_New";
            this.Text = "Report_Viewer_New";
            this.Load += new System.EventHandler(this.Report_Viewer_New_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workorderreportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv_itpDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource workorderreportBindingSource;
        private inv_itpDataSet1 inv_itpDataSet1;
        private inv_itpDataSet1TableAdapters.workorderreportTableAdapter workorderreportTableAdapter;
    }
}