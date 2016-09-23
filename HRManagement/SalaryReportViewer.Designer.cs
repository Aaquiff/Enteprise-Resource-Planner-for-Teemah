namespace HRManagement
{
    partial class SalaryReportViewer
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
            this.advancesalaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itpDataSet1 = new HRManagement.itpDataSet1();
            this.salaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itpDataSet = new HRManagement.itpDataSet();
            this.salaryTableAdapter = new HRManagement.itpDataSetTableAdapters.salaryTableAdapter();
            this.advancesalaryTableAdapter = new HRManagement.itpDataSet1TableAdapters.advancesalaryTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.itpDataSet2 = new HRManagement.itpDataSet2();
            this.itpDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.advancesalaryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.advancesalaryTableAdapter1 = new HRManagement.itpDataSet2TableAdapters.advancesalaryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.advancesalaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itpDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itpDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itpDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancesalaryBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // advancesalaryBindingSource
            // 
            this.advancesalaryBindingSource.DataMember = "advancesalary";
            this.advancesalaryBindingSource.DataSource = this.itpDataSet1;
            // 
            // itpDataSet1
            // 
            this.itpDataSet1.DataSetName = "itpDataSet1";
            this.itpDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salaryBindingSource
            // 
            this.salaryBindingSource.DataMember = "salary";
            this.salaryBindingSource.DataSource = this.itpDataSet;
            // 
            // itpDataSet
            // 
            this.itpDataSet.DataSetName = "itpDataSet";
            this.itpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salaryTableAdapter
            // 
            this.salaryTableAdapter.ClearBeforeFill = true;
            // 
            // advancesalaryTableAdapter
            // 
            this.advancesalaryTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.advancesalaryBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HRManagement.SalaryReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(724, 456);
            this.reportViewer1.TabIndex = 0;
            // 
            // itpDataSet2
            // 
            this.itpDataSet2.DataSetName = "itpDataSet2";
            this.itpDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itpDataSet2BindingSource
            // 
            this.itpDataSet2BindingSource.DataSource = this.itpDataSet2;
            this.itpDataSet2BindingSource.Position = 0;
            // 
            // advancesalaryBindingSource1
            // 
            this.advancesalaryBindingSource1.DataMember = "advancesalary";
            this.advancesalaryBindingSource1.DataSource = this.itpDataSet2;
            // 
            // advancesalaryTableAdapter1
            // 
            this.advancesalaryTableAdapter1.ClearBeforeFill = true;
            // 
            // SalaryReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 456);
            this.Controls.Add(this.reportViewer1);
            this.Name = "SalaryReportViewer";
            this.Text = "SalaryReportViewer";
            this.Load += new System.EventHandler(this.SalaryReportViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.advancesalaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itpDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itpDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itpDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancesalaryBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource salaryBindingSource;
        private itpDataSet itpDataSet;
        private itpDataSetTableAdapters.salaryTableAdapter salaryTableAdapter;
        private System.Windows.Forms.BindingSource advancesalaryBindingSource;
        private itpDataSet1 itpDataSet1;
        private itpDataSet1TableAdapters.advancesalaryTableAdapter advancesalaryTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private itpDataSet2 itpDataSet2;
        private System.Windows.Forms.BindingSource itpDataSet2BindingSource;
        private System.Windows.Forms.BindingSource advancesalaryBindingSource1;
        private itpDataSet2TableAdapters.advancesalaryTableAdapter advancesalaryTableAdapter1;
    }
}