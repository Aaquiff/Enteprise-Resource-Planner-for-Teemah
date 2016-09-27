namespace DistributionManagement
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
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(651, 457);
            this.reportViewer2.TabIndex = 0;
            // 
            // ReportViewer
            // 
            this.ClientSize = new System.Drawing.Size(651, 457);
            this.Controls.Add(this.reportViewer2);
            this.Name = "ReportViewer";
            this.Load += new System.EventHandler(this.ReportViewer_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private inv_itpDataSet inv_itpDataSet;
        private System.Windows.Forms.BindingSource routeBindingSource;
        private inv_itpDataSetTableAdapters.routeTableAdapter routeTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
    }
}