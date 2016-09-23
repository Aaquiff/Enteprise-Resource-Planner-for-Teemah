namespace RawMaterialManagement.Reporting
{
    partial class ReportViewer
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
            this.raw_item_tabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new RawMaterialManagement.Reporting.DataSet1();
            this.rawinvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rawDataSet = new RawMaterialManagement.RawDataSet();
            this.raworderlineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.raw_invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rawDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.raw_invoiceTableAdapter = new RawMaterialManagement.RawDataSetTableAdapters.raw_invoiceTableAdapter();
            this.raw_item_tabTableAdapter = new RawMaterialManagement.Reporting.DataSet1TableAdapters.raw_item_tabTableAdapter();
            this.rawDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.raw_order_lineTableAdapter = new RawMaterialManagement.RawDataSetTableAdapters.raw_order_lineTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.raw_item_tabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawinvoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raworderlineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raw_invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // raw_item_tabBindingSource
            // 
            this.raw_item_tabBindingSource.DataMember = "raw_item_tab";
            this.raw_item_tabBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rawinvoiceBindingSource
            // 
            this.rawinvoiceBindingSource.DataMember = "raw_invoice";
            this.rawinvoiceBindingSource.DataSource = this.rawDataSet;
            // 
            // rawDataSet
            // 
            this.rawDataSet.DataSetName = "RawDataSet";
            this.rawDataSet.EnforceConstraints = false;
            this.rawDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // raworderlineBindingSource
            // 
            this.raworderlineBindingSource.DataMember = "raw_order_line";
            this.raworderlineBindingSource.DataSource = this.rawDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.raw_item_tabBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "RawMaterialManagement.Reporting.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(15, 60);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(729, 372);
            this.reportViewer1.TabIndex = 0;
            // 
            // raw_invoiceBindingSource
            // 
            this.raw_invoiceBindingSource.DataMember = "raw_invoice";
            this.raw_invoiceBindingSource.DataSource = this.rawDataSet;
            // 
            // rawDataSetBindingSource
            // 
            this.rawDataSetBindingSource.DataSource = this.rawDataSet;
            this.rawDataSetBindingSource.Position = 0;
            // 
            // raw_invoiceTableAdapter
            // 
            this.raw_invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // raw_item_tabTableAdapter
            // 
            this.raw_item_tabTableAdapter.ClearBeforeFill = true;
            // 
            // rawDataSetBindingSource1
            // 
            this.rawDataSetBindingSource1.DataSource = this.rawDataSet;
            this.rawDataSetBindingSource1.Position = 0;
            // 
            // raw_order_lineTableAdapter
            // 
            this.raw_order_lineTableAdapter.ClearBeforeFill = true;
            // 
            // ReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(759, 448);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportViewer";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Text = "Stock Report";
            this.Load += new System.EventHandler(this.ReportViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.raw_item_tabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawinvoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raworderlineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raw_invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource raw_invoiceBindingSource;
        private RawDataSet rawDataSet;
        private DataSet1TableAdapters.raw_item_tabTableAdapter raw_item_tabTableAdapter;
        private System.Windows.Forms.BindingSource rawDataSetBindingSource;
        private DataSet1 DataSet1;
        private System.Windows.Forms.BindingSource raw_item_tabBindingSource;
        private System.Windows.Forms.BindingSource rawinvoiceBindingSource;
        private RawDataSetTableAdapters.raw_invoiceTableAdapter raw_invoiceTableAdapter;
        private System.Windows.Forms.BindingSource rawDataSetBindingSource1;
        private System.Windows.Forms.BindingSource raworderlineBindingSource;
        private RawDataSetTableAdapters.raw_order_lineTableAdapter raw_order_lineTableAdapter;

    }
}