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
            this.contextMenuStripPurchaseOrder = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.contextMenuStripPurchaseOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataAdapter
            // 
            this.dataAdapter.DeleteCommand = null;
            this.dataAdapter.InsertCommand = null;
            this.dataAdapter.SelectCommand = null;
            this.dataAdapter.UpdateCommand = null;
            // 
            // contextMenuStripPurchaseOrder
            // 
            this.contextMenuStripPurchaseOrder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewOrderToolStripMenuItem});
            this.contextMenuStripPurchaseOrder.Name = "contextMenuStripPurchaseOrder";
            this.contextMenuStripPurchaseOrder.Size = new System.Drawing.Size(133, 26);
            // 
            // viewOrderToolStripMenuItem
            // 
            this.viewOrderToolStripMenuItem.Name = "viewOrderToolStripMenuItem";
            this.viewOrderToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewOrderToolStripMenuItem.Text = "View Order";
            this.viewOrderToolStripMenuItem.Click += new System.EventHandler(this.viewOrderToolStripMenuItem_Click);
            // 
            // ManagePurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(930, 371);
            this.ContextMenuStrip = this.contextMenuStripPurchaseOrder;
            this.Name = "ManagePurchaseOrder";
            this.Text = "Manage Purchase Order";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.contextMenuStripPurchaseOrder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.ContextMenuStrip contextMenuStripPurchaseOrder;
        private System.Windows.Forms.ToolStripMenuItem viewOrderToolStripMenuItem;

        //private MySql.Data.MySqlClient.MySqlDataAdapter dataAdapter;
    }
}
