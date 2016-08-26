namespace RawMaterialManagement.Raw_Material_Requests
{
    partial class frmRawMaterialRequests
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.raw_item_tabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.contextMenuStripRequest = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.approveRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customDataGrid11 = new FrameworkControls.Controls.CustomDataGrid1();
            this.rawMatReqIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rawmatreqBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rawDataSet = new RawMaterialManagement.RawDataSet();
            this.rawmatreqTableAdapter = new RawMaterialManagement.RawDataSetTableAdapters.rawmatreqTableAdapter();
            this.tableAdapterManager = new RawMaterialManagement.RawDataSetTableAdapters.TableAdapterManager();
            this.raw_item_tabTableAdapter = new RawMaterialManagement.RawDataSetTableAdapters.raw_item_tabTableAdapter();
            this.rejectRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raw_item_tabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStripRequest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customDataGrid11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawmatreqBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1288, 312);
            this.panel2.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Item Name";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.raw_item_tabBindingSource, "name", true));
            this.textBox4.Location = new System.Drawing.Point(334, 30);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(294, 25);
            this.textBox4.TabIndex = 8;
            // 
            // raw_item_tabBindingSource
            // 
            this.raw_item_tabBindingSource.DataMember = "raw_item_tab_rawmatreq";
            this.raw_item_tabBindingSource.DataSource = this.rawmatreqBindingSource;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Description";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.raw_item_tabBindingSource, "description", true));
            this.textBox3.Location = new System.Drawing.Point(34, 98);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(291, 179);
            this.textBox3.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(634, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Stock Level";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Item Id";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.raw_item_tabBindingSource, "stock_level", true));
            this.textBox2.Location = new System.Drawing.Point(634, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(294, 25);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.raw_item_tabBindingSource, "item_id", true));
            this.textBox1.Location = new System.Drawing.Point(34, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(294, 25);
            this.textBox1.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.customDataGrid11);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(1288, 632);
            this.splitContainer1.SplitterDistance = 316;
            this.splitContainer1.TabIndex = 17;
            // 
            // contextMenuStripRequest
            // 
            this.contextMenuStripRequest.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.approveRequestToolStripMenuItem,
            this.rejectRequestToolStripMenuItem});
            this.contextMenuStripRequest.Name = "contextMenuStripRequest";
            this.contextMenuStripRequest.Size = new System.Drawing.Size(165, 70);
            // 
            // approveRequestToolStripMenuItem
            // 
            this.approveRequestToolStripMenuItem.Name = "approveRequestToolStripMenuItem";
            this.approveRequestToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.approveRequestToolStripMenuItem.Text = "Approve Request";
            this.approveRequestToolStripMenuItem.Click += new System.EventHandler(this.approveRequestToolStripMenuItem_Click);
            // 
            // customDataGrid11
            // 
            this.customDataGrid11.AllowUserToAddRows = false;
            this.customDataGrid11.AllowUserToDeleteRows = false;
            this.customDataGrid11.AllowUserToResizeRows = false;
            this.customDataGrid11.AutoGenerateColumns = false;
            this.customDataGrid11.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customDataGrid11.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            this.customDataGrid11.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.customDataGrid11.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customDataGrid11.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rawMatReqIdDataGridViewTextBoxColumn,
            this.productIdDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.requestDateDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn,
            this.referenceDataGridViewTextBoxColumn});
            this.customDataGrid11.DataSource = this.rawmatreqBindingSource;
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
            this.customDataGrid11.Location = new System.Drawing.Point(0, 0);
            this.customDataGrid11.MultiSelect = false;
            this.customDataGrid11.Name = "customDataGrid11";
            this.customDataGrid11.RowHeadersVisible = false;
            this.customDataGrid11.RowTemplate.ContextMenuStrip = this.contextMenuStripRequest;
            this.customDataGrid11.RowTemplate.Height = 30;
            this.customDataGrid11.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customDataGrid11.Size = new System.Drawing.Size(1288, 316);
            this.customDataGrid11.TabIndex = 2;
            // 
            // rawMatReqIdDataGridViewTextBoxColumn
            // 
            this.rawMatReqIdDataGridViewTextBoxColumn.DataPropertyName = "rawMatReqId";
            this.rawMatReqIdDataGridViewTextBoxColumn.HeaderText = "RAWMATREQID";
            this.rawMatReqIdDataGridViewTextBoxColumn.Name = "rawMatReqIdDataGridViewTextBoxColumn";
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "productId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "PRODUCTID";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "QUANTITY";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // requestDateDataGridViewTextBoxColumn
            // 
            this.requestDateDataGridViewTextBoxColumn.DataPropertyName = "requestDate";
            this.requestDateDataGridViewTextBoxColumn.HeaderText = "REQUESTDATE";
            this.requestDateDataGridViewTextBoxColumn.Name = "requestDateDataGridViewTextBoxColumn";
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "orderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "ORDERDATE";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "STATUS";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "NOTES";
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            // 
            // referenceDataGridViewTextBoxColumn
            // 
            this.referenceDataGridViewTextBoxColumn.DataPropertyName = "reference";
            this.referenceDataGridViewTextBoxColumn.HeaderText = "REFERENCE";
            this.referenceDataGridViewTextBoxColumn.Name = "referenceDataGridViewTextBoxColumn";
            // 
            // rawmatreqBindingSource
            // 
            this.rawmatreqBindingSource.DataMember = "rawmatreq";
            this.rawmatreqBindingSource.DataSource = this.rawDataSet;
            // 
            // rawDataSet
            // 
            this.rawDataSet.DataSetName = "RawDataSet";
            this.rawDataSet.EnforceConstraints = false;
            this.rawDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rawmatreqTableAdapter
            // 
            this.rawmatreqTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.raw_invoice_tabTableAdapter = null;
            this.tableAdapterManager.raw_item_tabTableAdapter = this.raw_item_tabTableAdapter;
            this.tableAdapterManager.raw_order_lineTableAdapter = null;
            this.tableAdapterManager.raw_purchase_orderTableAdapter = null;
            this.tableAdapterManager.raw_supplier_tabTableAdapter = null;
            this.tableAdapterManager.rawmatreqTableAdapter = this.rawmatreqTableAdapter;
            this.tableAdapterManager.UpdateOrder = RawMaterialManagement.RawDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // raw_item_tabTableAdapter
            // 
            this.raw_item_tabTableAdapter.ClearBeforeFill = true;
            // 
            // rejectRequestToolStripMenuItem
            // 
            this.rejectRequestToolStripMenuItem.Name = "rejectRequestToolStripMenuItem";
            this.rejectRequestToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.rejectRequestToolStripMenuItem.Text = "Reject Request";
            this.rejectRequestToolStripMenuItem.Click += new System.EventHandler(this.rejectRequestToolStripMenuItem_Click);
            // 
            // frmRawMaterialRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1288, 632);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmRawMaterialRequests";
            this.Text = "Raw Material Requests";
            this.Load += new System.EventHandler(this.frmRawMaterialRequests_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raw_item_tabBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStripRequest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customDataGrid11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawmatreqBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private RawDataSet rawDataSet;
        private System.Windows.Forms.BindingSource rawmatreqBindingSource;
        private RawDataSetTableAdapters.rawmatreqTableAdapter rawmatreqTableAdapter;
        private RawDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private RawDataSetTableAdapters.raw_item_tabTableAdapter raw_item_tabTableAdapter;
        private System.Windows.Forms.BindingSource raw_item_tabBindingSource;
        private FrameworkControls.Controls.CustomDataGrid1 customDataGrid11;
        private System.Windows.Forms.DataGridViewTextBoxColumn rawMatReqIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripRequest;
        private System.Windows.Forms.ToolStripMenuItem approveRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rejectRequestToolStripMenuItem;
    }
}