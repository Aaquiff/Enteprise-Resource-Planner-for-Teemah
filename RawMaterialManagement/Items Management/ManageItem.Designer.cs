namespace RawMaterialManagement.Items_Management
{
    partial class ManageItem
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewBase1 = new FrameworkControls.Controls.DataGridViewBase();
            this.customDataGrid11 = new FrameworkControls.Controls.CustomDataGrid1();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBase1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customDataGrid11)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbColumns
            // 
            this.cmbColumns.Size = new System.Drawing.Size(121, 24);
            // 
            // panelSearch
            // 
            this.panelSearch.Location = new System.Drawing.Point(0, 70);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.customDataGrid11);
            this.panel2.Controls.Add(this.dataGridViewBase1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 131);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(930, 240);
            this.panel2.TabIndex = 7;
            // 
            // customDataGrid11
            // 
            this.customDataGrid11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customDataGrid11.Name = "customDataGrid11";
            // 
            // ManageItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(930, 371);
            this.Controls.Add(this.panel2);
            this.Name = "ManageItem";
            this.Text = "Manage Item";
            this.Controls.SetChildIndex(this.panelSearch, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBase1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customDataGrid11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private FrameworkControls.Controls.DataGridViewBase dataGridViewBase1;
        private FrameworkControls.Controls.CustomDataGrid1 customDataGrid11;
    }
}
