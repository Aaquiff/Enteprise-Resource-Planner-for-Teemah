namespace FinanceManagement
{
    partial class AssetRepairReport
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
            this.asset_repairBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teemahDataSet3 = new FinanceManagement.teemahDataSet3();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.asset_repairTableAdapter = new FinanceManagement.teemahDataSet3TableAdapters.asset_repairTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.asset_repairBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teemahDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // asset_repairBindingSource
            // 
            this.asset_repairBindingSource.DataMember = "asset_repair";
            this.asset_repairBindingSource.DataSource = this.teemahDataSet3;
            // 
            // teemahDataSet3
            // 
            this.teemahDataSet3.DataSetName = "teemahDataSet3";
            this.teemahDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.asset_repairBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FinanceManagement.RepairReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(20, 60);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(979, 414);
            this.reportViewer1.TabIndex = 0;
            // 
            // asset_repairTableAdapter
            // 
            this.asset_repairTableAdapter.ClearBeforeFill = true;
            // 
            // AssetRepairReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 494);
            this.Controls.Add(this.reportViewer1);
            this.Name = "AssetRepairReport";
            this.Text = "Asset Repair Report";
            this.Load += new System.EventHandler(this.AssetRepairReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.asset_repairBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teemahDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource asset_repairBindingSource;
        private teemahDataSet3 teemahDataSet3;
        private teemahDataSet3TableAdapters.asset_repairTableAdapter asset_repairTableAdapter;
    }
}