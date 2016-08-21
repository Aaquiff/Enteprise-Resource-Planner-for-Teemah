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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colsItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colsItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colsDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitOfMeasure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataAdapter
            // 
            this.dataAdapter1.DeleteCommand = null;
            this.dataAdapter1.InsertCommand = null;
            this.dataAdapter1.SelectCommand = null;
            this.dataAdapter1.UpdateCommand = null;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colsItemId,
            this.colsItemName,
            this.colsDescription,
            this.colStockLevel,
            this.colUnitOfMeasure,
            this.colItemCategory,
            this.colBarcode});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(930, 301);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // colsItemId
            // 
            this.colsItemId.DataPropertyName = "item_id";
            this.colsItemId.HeaderText = "Item Id";
            this.colsItemId.Name = "colsItemId";
            this.colsItemId.ReadOnly = true;
            // 
            // colsItemName
            // 
            this.colsItemName.DataPropertyName = "name";
            this.colsItemName.HeaderText = "Item Name";
            this.colsItemName.Name = "colsItemName";
            // 
            // colsDescription
            // 
            this.colsDescription.DataPropertyName = "description";
            this.colsDescription.HeaderText = "Description";
            this.colsDescription.Name = "colsDescription";
            // 
            // colStockLevel
            // 
            this.colStockLevel.DataPropertyName = "stock_level";
            this.colStockLevel.HeaderText = "Stock Level";
            this.colStockLevel.Name = "colStockLevel";
            // 
            // colUnitOfMeasure
            // 
            this.colUnitOfMeasure.DataPropertyName = "unit_of_measure";
            this.colUnitOfMeasure.HeaderText = "Unit Of Measure";
            this.colUnitOfMeasure.Name = "colUnitOfMeasure";
            // 
            // colItemCategory
            // 
            this.colItemCategory.DataPropertyName = "item_category";
            this.colItemCategory.HeaderText = "Item Category";
            this.colItemCategory.Name = "colItemCategory";
            // 
            // colBarcode
            // 
            this.colBarcode.DataPropertyName = "bar_code";
            this.colBarcode.HeaderText = "Bar Code";
            this.colBarcode.Name = "colBarcode";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(930, 301);
            this.panel2.TabIndex = 7;
            // 
            // ManageItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(930, 371);
            this.Controls.Add(this.panel2);
            this.Name = "ManageItem";
            this.Text = "Manage Item";
            this.Controls.SetChildIndex(this.panel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitOfMeasure;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBarcode;
        private System.Windows.Forms.Panel panel2;
    }
}
