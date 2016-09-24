namespace FinishedGoodManagement
{
    partial class ReportViewerOLD
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
            this.inv_itpDataSet = new FinishedGoodManagement.inv_itpDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.workorderreportTableAdapter = new FinishedGoodManagement.inv_itpDataSetTableAdapters.workorderreportTableAdapter();
            this.workorderreportTableAdapter1 = new FinishedGoodManagement.inv_itpDataSetTableAdapters.workorderreportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.workorderreportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv_itpDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // workorderreportBindingSource
            // 
            this.workorderreportBindingSource.DataMember = "workorderreport";
            this.workorderreportBindingSource.DataSource = this.inv_itpDataSet;
            // 
            // inv_itpDataSet
            // 
            this.inv_itpDataSet.DataSetName = "inv_itpDataSet";
            this.inv_itpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.workorderreportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FinishedGoodManagement.WorkOrderReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(768, 408);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // workorderreportTableAdapter
            // 
            this.workorderreportTableAdapter.ClearBeforeFill = true;
            // 
            // workorderreportTableAdapter1
            // 
            this.workorderreportTableAdapter1.ClearBeforeFill = true;
            // 
            // ReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 408);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportViewer";
            this.Text = "ReportViewer";
            this.Load += new System.EventHandler(this.ReportViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workorderreportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv_itpDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource workorderreportBindingSource;
        private inv_itpDataSet inv_itpDataSet;
        private inv_itpDataSetTableAdapters.workorderreportTableAdapter workorderreportTableAdapter;
        private inv_itpDataSetTableAdapters.workorderreportTableAdapter workorderreportTableAdapter1;

    }
}