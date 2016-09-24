﻿namespace ProductProcessManagement.Reports
{
    partial class Remark_Report
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
            this.remarkreportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.remark_reportTableAdapter = new ProductProcessManagement.PPReportsTableAdapters.remark_reportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pPReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkreportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.remarkreportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProductProcessManagement.Reports.Remark_Report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1162, 495);
            this.reportViewer1.TabIndex = 0;
            // 
            // pPReports
            // 
            this.pPReports.DataSetName = "PPReports";
            this.pPReports.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // remarkreportBindingSource
            // 
            this.remarkreportBindingSource.DataMember = "remark_report";
            this.remarkreportBindingSource.DataSource = this.pPReports;
            // 
            // remark_reportTableAdapter
            // 
            this.remark_reportTableAdapter.ClearBeforeFill = true;
            // 
            // Remark_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 495);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Remark_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remark Report";
            this.Load += new System.EventHandler(this.Remark_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pPReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkreportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private PPReports pPReports;
        private System.Windows.Forms.BindingSource remarkreportBindingSource;
        private PPReportsTableAdapters.remark_reportTableAdapter remark_reportTableAdapter;
    }
}