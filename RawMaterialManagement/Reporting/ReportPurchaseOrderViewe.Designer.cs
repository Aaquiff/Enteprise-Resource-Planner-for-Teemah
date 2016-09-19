namespace RawMaterialManagement.Reporting
{
    partial class ReportPurchaseOrderViewe
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
            this.rawDataSet = new RawMaterialManagement.RawDataSet();
            this.rawpurchaseorderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.raw_purchase_orderTableAdapter = new RawMaterialManagement.RawDataSetTableAdapters.raw_purchase_orderTableAdapter();
            this.raworderlineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.raw_order_lineTableAdapter = new RawMaterialManagement.RawDataSetTableAdapters.raw_order_lineTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rawDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawpurchaseorderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raworderlineBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "PurchaseOrderDataSet";
            reportDataSource3.Value = this.rawpurchaseorderBindingSource;
            reportDataSource4.Name = "PurchaseOrderLineDataSet";
            reportDataSource4.Value = this.raworderlineBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "RawMaterialManagement.Reporting.PurchaseOrderReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1026, 467);
            this.reportViewer1.TabIndex = 0;
            // 
            // rawDataSet
            // 
            this.rawDataSet.DataSetName = "RawDataSet";
            this.rawDataSet.EnforceConstraints = false;
            this.rawDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rawpurchaseorderBindingSource
            // 
            this.rawpurchaseorderBindingSource.DataMember = "raw_purchase_order";
            this.rawpurchaseorderBindingSource.DataSource = this.rawDataSet;
            // 
            // raw_purchase_orderTableAdapter
            // 
            this.raw_purchase_orderTableAdapter.ClearBeforeFill = true;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 527);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.metroDateTime1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1026, 60);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.reportViewer1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1026, 467);
            this.panel3.TabIndex = 3;
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.CustomFormat = "yyyy";
            this.metroDateTime1.Location = new System.Drawing.Point(109, 9);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 30);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(362, 30);
            this.metroDateTime1.TabIndex = 0;
            this.metroDateTime1.ValueChanged += new System.EventHandler(this.metroDateTime1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select a Year ";
            // 
            // ReportPurchaseOrderViewe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 607);
            this.Controls.Add(this.panel1);
            this.Name = "ReportPurchaseOrderViewe";
            this.Text = "Purchase Order Report";
            this.Load += new System.EventHandler(this.ReportPurchaseOrderViewe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rawDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawpurchaseorderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raworderlineBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private RawDataSet rawDataSet;
        private System.Windows.Forms.BindingSource rawpurchaseorderBindingSource;
        private RawDataSetTableAdapters.raw_purchase_orderTableAdapter raw_purchase_orderTableAdapter;
        private System.Windows.Forms.BindingSource raworderlineBindingSource;
        private RawDataSetTableAdapters.raw_order_lineTableAdapter raw_order_lineTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private System.Windows.Forms.Label label1;
    }
}