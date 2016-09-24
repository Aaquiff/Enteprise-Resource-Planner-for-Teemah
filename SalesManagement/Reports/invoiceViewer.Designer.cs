namespace SalesManagement
{
    partial class invoiceViewer
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetForInvoice = new SalesManagement.DataSetForInvoice();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceTableAdapter = new SalesManagement.DataSetForInvoiceTableAdapters.invoiceTableAdapter();
            this.proddetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proddetailsTableAdapter = new SalesManagement.DataSetForInvoiceTableAdapters.proddetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetForInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proddetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.invoiceBindingSource;
            reportDataSource4.Name = "DataSet2";
            reportDataSource4.Value = this.proddetailsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SalesManagement.Reports.invoice.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(708, 385);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // DataSetForInvoice
            // 
            this.DataSetForInvoice.DataSetName = "DataSetForInvoice";
            this.DataSetForInvoice.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataMember = "invoice";
            this.invoiceBindingSource.DataSource = this.DataSetForInvoice;
            // 
            // invoiceTableAdapter
            // 
            this.invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // proddetailsBindingSource
            // 
            this.proddetailsBindingSource.DataMember = "proddetails";
            this.proddetailsBindingSource.DataSource = this.DataSetForInvoice;
            // 
            // proddetailsTableAdapter
            // 
            this.proddetailsTableAdapter.ClearBeforeFill = true;
            // 
            // invoiceViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 385);
            this.Controls.Add(this.reportViewer1);
            this.Name = "invoiceViewer";
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.invoiceViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetForInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proddetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private DataSetForInvoice DataSetForInvoice;
        private System.Windows.Forms.BindingSource proddetailsBindingSource;
        private DataSetForInvoiceTableAdapters.invoiceTableAdapter invoiceTableAdapter;
        private DataSetForInvoiceTableAdapters.proddetailsTableAdapter proddetailsTableAdapter;
    }
}