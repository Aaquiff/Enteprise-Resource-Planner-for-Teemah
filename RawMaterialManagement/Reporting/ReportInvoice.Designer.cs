namespace RawMaterialManagement.Reporting
{
    partial class ReportInvoice
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.raw_invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rawDataSet = new RawMaterialManagement.RawDataSet();
            this.raw_order_lineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rawpurchaseorderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rawinvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.raw_invoiceTableAdapter = new RawMaterialManagement.RawDataSetTableAdapters.raw_invoiceTableAdapter();
            this.raworderlineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.raw_order_lineTableAdapter = new RawMaterialManagement.RawDataSetTableAdapters.raw_order_lineTableAdapter();
            this.DataSet1 = new RawMaterialManagement.Reporting.DataSet1();
            this.raw_item_tabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.raw_item_tabTableAdapter = new RawMaterialManagement.Reporting.DataSet1TableAdapters.raw_item_tabTableAdapter();
            this.raw_purchase_orderTableAdapter = new RawMaterialManagement.RawDataSetTableAdapters.raw_purchase_orderTableAdapter();
            this.rawsuppliertabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.raw_supplier_tabTableAdapter = new RawMaterialManagement.RawDataSetTableAdapters.raw_supplier_tabTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.raw_invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raw_order_lineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawpurchaseorderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawinvoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raworderlineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raw_item_tabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawsuppliertabBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // raw_invoiceBindingSource
            // 
            this.raw_invoiceBindingSource.DataMember = "raw_invoice";
            this.raw_invoiceBindingSource.DataSource = this.rawDataSet;
            // 
            // rawDataSet
            // 
            this.rawDataSet.DataSetName = "RawDataSet";
            this.rawDataSet.EnforceConstraints = false;
            this.rawDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // raw_order_lineBindingSource
            // 
            this.raw_order_lineBindingSource.DataMember = "raw_order_line";
            this.raw_order_lineBindingSource.DataSource = this.rawDataSet;
            // 
            // rawpurchaseorderBindingSource
            // 
            this.rawpurchaseorderBindingSource.DataMember = "raw_purchase_order";
            this.rawpurchaseorderBindingSource.DataSource = this.rawDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.raw_invoiceBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.raw_order_lineBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.rawpurchaseorderBindingSource;
            reportDataSource4.Name = "DataSetSupplier";
            reportDataSource4.Value = this.rawsuppliertabBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "RawMaterialManagement.Reporting.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(20, 60);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(840, 463);
            this.reportViewer1.TabIndex = 0;
            // 
            // rawinvoiceBindingSource
            // 
            this.rawinvoiceBindingSource.DataMember = "raw_invoice";
            this.rawinvoiceBindingSource.DataSource = this.rawDataSet;
            // 
            // raw_invoiceTableAdapter
            // 
            this.raw_invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // raworderlineBindingSource
            // 
            this.raworderlineBindingSource.DataMember = "raw_order_line";
            this.raworderlineBindingSource.DataSource = this.rawDataSet;
            // 
            // raw_order_lineTableAdapter
            // 
            this.raw_order_lineTableAdapter.ClearBeforeFill = true;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // raw_item_tabBindingSource
            // 
            this.raw_item_tabBindingSource.DataMember = "raw_item_tab";
            this.raw_item_tabBindingSource.DataSource = this.DataSet1;
            // 
            // raw_item_tabTableAdapter
            // 
            this.raw_item_tabTableAdapter.ClearBeforeFill = true;
            // 
            // raw_purchase_orderTableAdapter
            // 
            this.raw_purchase_orderTableAdapter.ClearBeforeFill = true;
            // 
            // rawsuppliertabBindingSource
            // 
            this.rawsuppliertabBindingSource.DataMember = "raw_supplier_tab";
            this.rawsuppliertabBindingSource.DataSource = this.rawDataSet;
            // 
            // raw_supplier_tabTableAdapter
            // 
            this.raw_supplier_tabTableAdapter.ClearBeforeFill = true;
            // 
            // ReportInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 543);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportInvoice";
            this.Text = "ReportInvoice";
            this.Load += new System.EventHandler(this.ReportInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.raw_invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raw_order_lineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawpurchaseorderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawinvoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raworderlineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raw_item_tabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawsuppliertabBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private RawDataSet rawDataSet;
        private System.Windows.Forms.BindingSource rawinvoiceBindingSource;
        private RawDataSetTableAdapters.raw_invoiceTableAdapter raw_invoiceTableAdapter;
        private System.Windows.Forms.BindingSource raworderlineBindingSource;
        private RawDataSetTableAdapters.raw_order_lineTableAdapter raw_order_lineTableAdapter;
        private System.Windows.Forms.BindingSource raw_item_tabBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.raw_item_tabTableAdapter raw_item_tabTableAdapter;
        private System.Windows.Forms.BindingSource raw_invoiceBindingSource;
        private System.Windows.Forms.BindingSource raw_order_lineBindingSource;
        private System.Windows.Forms.BindingSource rawpurchaseorderBindingSource;
        private RawDataSetTableAdapters.raw_purchase_orderTableAdapter raw_purchase_orderTableAdapter;
        private System.Windows.Forms.BindingSource rawsuppliertabBindingSource;
        private RawDataSetTableAdapters.raw_supplier_tabTableAdapter raw_supplier_tabTableAdapter;
    }
}