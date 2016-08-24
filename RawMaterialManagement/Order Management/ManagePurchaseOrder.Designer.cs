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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuStripPurchaseOrder = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customDataGrid11 = new FrameworkControls.Controls.CustomDataGrid1();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.contextMenuStripPurchaseOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customDataGrid11)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbColumns
            // 
            this.cmbColumns.ItemHeight = 17;
            this.cmbColumns.Size = new System.Drawing.Size(175, 25);
            // 
            // txtSearchItemId
            // 
            this.txtSearchItemId.Size = new System.Drawing.Size(639, 29);
            // 
            // panelSearch
            // 
            this.panelSearch.Location = new System.Drawing.Point(0, 70);
            this.panelSearch.Size = new System.Drawing.Size(814, 33);
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
            this.customDataGrid11.AllowUserToAddRows = false;
            this.customDataGrid11.AllowUserToDeleteRows = false;
            this.customDataGrid11.AllowUserToResizeRows = false;
            this.customDataGrid11.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customDataGrid11.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            this.customDataGrid11.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.customDataGrid11.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customDataGrid11.DefaultCellStyle = dataGridViewCellStyle2;
            this.customDataGrid11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customDataGrid11.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.customDataGrid11.EnableHeadersVisualStyles = false;
            this.customDataGrid11.GridColor = System.Drawing.SystemColors.Control;
            this.customDataGrid11.Location = new System.Drawing.Point(0, 103);
            this.customDataGrid11.MultiSelect = false;
            this.customDataGrid11.Name = "customDataGrid11";
            this.customDataGrid11.RowHeadersVisible = false;
            this.customDataGrid11.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customDataGrid11.Size = new System.Drawing.Size(814, 291);
            this.customDataGrid11.TabIndex = 9;
            // 
            // ManagePurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(814, 394);
            this.ContextMenuStrip = this.contextMenuStripPurchaseOrder;
            this.Controls.Add(this.customDataGrid11);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ManagePurchaseOrder";
            this.Text = "Manage Purchase Order";
            this.Controls.SetChildIndex(this.panelSearch, 0);
            this.Controls.SetChildIndex(this.customDataGrid11, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
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
