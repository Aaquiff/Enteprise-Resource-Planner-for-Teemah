namespace RawMaterialManagement.Reporting
{
    partial class ReportSupplier
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.raworderlineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rawDataSet = new RawMaterialManagement.RawDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.raw_order_lineTableAdapter = new RawMaterialManagement.RawDataSetTableAdapters.raw_order_lineTableAdapter();
            this.rawsuppliertabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.raw_supplier_tabTableAdapter = new RawMaterialManagement.RawDataSetTableAdapters.raw_supplier_tabTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.raworderlineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawsuppliertabBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // raworderlineBindingSource
            // 
            this.raworderlineBindingSource.DataMember = "raw_order_line";
            this.raworderlineBindingSource.DataSource = this.rawDataSet;
            // 
            // rawDataSet
            // 
            this.rawDataSet.DataSetName = "RawDataSet";
            this.rawDataSet.EnforceConstraints = false;
            this.rawDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource5.Name = "DataSetOrderLine";
            reportDataSource5.Value = this.raworderlineBindingSource;
            reportDataSource6.Name = "DataSetSupplier";
            reportDataSource6.Value = this.rawsuppliertabBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "RawMaterialManagement.Reporting.ReportSupplier.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(20, 60);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(947, 381);
            this.reportViewer1.TabIndex = 0;
            // 
            // raw_order_lineTableAdapter
            // 
            this.raw_order_lineTableAdapter.ClearBeforeFill = true;
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
            // ReportSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 461);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportSupplier";
            this.Text = "ReportSupplier";
            this.Load += new System.EventHandler(this.ReportSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.raworderlineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawsuppliertabBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private RawDataSet rawDataSet;
        private System.Windows.Forms.BindingSource raworderlineBindingSource;
        private RawDataSetTableAdapters.raw_order_lineTableAdapter raw_order_lineTableAdapter;
        private System.Windows.Forms.BindingSource rawsuppliertabBindingSource;
        private RawDataSetTableAdapters.raw_supplier_tabTableAdapter raw_supplier_tabTableAdapter;
    }
}