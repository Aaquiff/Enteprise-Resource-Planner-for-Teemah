namespace RawMaterialManagement.Order_Management
{
    partial class ManagePurchaseOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();            this.contextMenuStripPurchaseOrder = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customDataGrid11 = new FrameworkControls.Controls.CustomDataGrid1();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.contextMenuStripPurchaseOrder.SuspendLayout();
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
            // contextMenuStripPurchaseOrder
            // 
            this.contextMenuStripPurchaseOrder.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripPurchaseOrder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewOrderToolStripMenuItem});
            this.contextMenuStripPurchaseOrder.Name = "contextMenuStripPurchaseOrder";
            this.contextMenuStripPurchaseOrder.Size = new System.Drawing.Size(133, 26);
            // 
            // viewOrderToolStripMenuItem
            // 
            this.viewOrderToolStripMenuItem.Name = "viewOrderToolStripMenuItem";
            this.viewOrderToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.viewOrderToolStripMenuItem.Text = "View Order";
            this.viewOrderToolStripMenuItem.Click += new System.EventHandler(this.viewOrderToolStripMenuItem_Click);
            // 
            // customDataGrid11
            // 
            this.customDataGrid11.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // ManagePurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(930, 371);
            this.ContextMenuStrip = this.contextMenuStripPurchaseOrder;
            this.Controls.Add(this.customDataGrid11);
            this.Name = "ManagePurchaseOrder";
            this.Text = "Manage Purchase Order";
            this.Controls.SetChildIndex(this.panelSearch, 0);
            this.Controls.SetChildIndex(this.customDataGrid11, 0);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.contextMenuStripPurchaseOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customDataGrid11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.ContextMenuStrip contextMenuStripPurchaseOrder;
        private System.Windows.Forms.ToolStripMenuItem viewOrderToolStripMenuItem;
        private FrameworkControls.Controls.CustomDataGrid1 customDataGrid11;
    }
}
