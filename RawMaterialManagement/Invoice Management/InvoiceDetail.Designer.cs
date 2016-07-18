namespace RawMaterialManagement.Invoice_Management
{
    partial class InvoiceDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceDetail));
            System.Windows.Forms.Label supplier_idLabel;
            System.Windows.Forms.Label invoice_idLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label totalLabel;
            System.Windows.Forms.Label payment_statusLabel;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colInvoiceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.supplier_idTextBox = new System.Windows.Forms.TextBox();
            this.invoice_tabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetRawMaterial = new RawMaterialManagement.DataSetRawMaterial();
            this.invoice_tabTableAdapter = new RawMaterialManagement.DataSetRawMaterialTableAdapters.invoice_tabTableAdapter();
            this.tableAdapterManager = new RawMaterialManagement.DataSetRawMaterialTableAdapters.TableAdapterManager();
            this.invoice_idTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.payment_statusTextBox = new System.Windows.Forms.TextBox();
            this.invoice_tabDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            supplier_idLabel = new System.Windows.Forms.Label();
            invoice_idLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            payment_statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoice_tabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRawMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoice_tabDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colInvoiceId,
            this.colItemId,
            this.colQuantity,
            this.colUnitPrice});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1001, 245);
            this.dataGridView1.TabIndex = 0;
            // 
            // colInvoiceId
            // 
            this.colInvoiceId.DataPropertyName = "invoice_id";
            this.colInvoiceId.HeaderText = "Invoice Id";
            this.colInvoiceId.Name = "colInvoiceId";
            // 
            // colItemId
            // 
            this.colItemId.DataPropertyName = "item_id";
            this.colItemId.HeaderText = "Item Id";
            this.colItemId.Name = "colItemId";
            // 
            // colQuantity
            // 
            this.colQuantity.DataPropertyName = "quantity";
            this.colQuantity.HeaderText = "Quantity";
            this.colQuantity.Name = "colQuantity";
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.DataPropertyName = "unit_price";
            this.colUnitPrice.HeaderText = "Unit Price";
            this.colUnitPrice.Name = "colUnitPrice";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem4});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1001, 72);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem3.Image")));
            this.toolStripMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(62, 68);
            this.toolStripMenuItem3.Text = "New";
            this.toolStripMenuItem3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(62, 68);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(62, 68);
            this.toolStripMenuItem1.Text = "Delete";
            this.toolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(70, 68);
            this.toolStripMenuItem2.Text = "Populate";
            this.toolStripMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripMenuItem4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem4.Image")));
            this.toolStripMenuItem4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(62, 68);
            this.toolStripMenuItem4.Text = "Search";
            this.toolStripMenuItem4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 446);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 201);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1001, 245);
            this.panel3.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.invoice_tabDataGridView);
            this.panel2.Controls.Add(payment_statusLabel);
            this.panel2.Controls.Add(this.payment_statusTextBox);
            this.panel2.Controls.Add(totalLabel);
            this.panel2.Controls.Add(this.totalTextBox);
            this.panel2.Controls.Add(dateLabel);
            this.panel2.Controls.Add(this.dateDateTimePicker);
            this.panel2.Controls.Add(invoice_idLabel);
            this.panel2.Controls.Add(this.invoice_idTextBox);
            this.panel2.Controls.Add(supplier_idLabel);
            this.panel2.Controls.Add(this.supplier_idTextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1001, 201);
            this.panel2.TabIndex = 12;
            // 
            // supplier_idLabel
            // 
            supplier_idLabel.AutoSize = true;
            supplier_idLabel.Location = new System.Drawing.Point(405, 3);
            supplier_idLabel.Name = "supplier_idLabel";
            supplier_idLabel.Size = new System.Drawing.Size(57, 13);
            supplier_idLabel.TabIndex = 12;
            supplier_idLabel.Text = "Supplier Id";
            // 
            // supplier_idTextBox
            // 
            this.supplier_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoice_tabBindingSource, "supplier_id", true));
            this.supplier_idTextBox.Location = new System.Drawing.Point(405, 19);
            this.supplier_idTextBox.Name = "supplier_idTextBox";
            this.supplier_idTextBox.Size = new System.Drawing.Size(242, 20);
            this.supplier_idTextBox.TabIndex = 13;
            // 
            // invoice_tabBindingSource
            // 
            this.invoice_tabBindingSource.DataMember = "invoice_tab";
            this.invoice_tabBindingSource.DataSource = this.dataSetRawMaterial;
            // 
            // dataSetRawMaterial
            // 
            this.dataSetRawMaterial.DataSetName = "DataSetRawMaterial";
            this.dataSetRawMaterial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoice_tabTableAdapter
            // 
            this.invoice_tabTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.invoice_item_tabTableAdapter = null;
            this.tableAdapterManager.invoice_tabTableAdapter = this.invoice_tabTableAdapter;
            this.tableAdapterManager.item_tabTableAdapter = null;
            this.tableAdapterManager.supplier_tabTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RawMaterialManagement.DataSetRawMaterialTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // invoice_idLabel
            // 
            invoice_idLabel.AutoSize = true;
            invoice_idLabel.Location = new System.Drawing.Point(208, 3);
            invoice_idLabel.Name = "invoice_idLabel";
            invoice_idLabel.Size = new System.Drawing.Size(54, 13);
            invoice_idLabel.TabIndex = 13;
            invoice_idLabel.Text = "Invoice Id";
            // 
            // invoice_idTextBox
            // 
            this.invoice_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoice_tabBindingSource, "invoice_id", true));
            this.invoice_idTextBox.Location = new System.Drawing.Point(208, 19);
            this.invoice_idTextBox.Name = "invoice_idTextBox";
            this.invoice_idTextBox.Size = new System.Drawing.Size(191, 20);
            this.invoice_idTextBox.TabIndex = 14;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(650, 3);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(30, 13);
            dateLabel.TabIndex = 14;
            dateLabel.Text = "Date";
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoice_tabBindingSource, "date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(653, 19);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateDateTimePicker.TabIndex = 15;
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(208, 51);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(31, 13);
            totalLabel.TabIndex = 15;
            totalLabel.Text = "Total";
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoice_tabBindingSource, "total", true));
            this.totalTextBox.Location = new System.Drawing.Point(211, 67);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(188, 20);
            this.totalTextBox.TabIndex = 16;
            // 
            // payment_statusLabel
            // 
            payment_statusLabel.AutoSize = true;
            payment_statusLabel.Location = new System.Drawing.Point(405, 51);
            payment_statusLabel.Name = "payment_statusLabel";
            payment_statusLabel.Size = new System.Drawing.Size(81, 13);
            payment_statusLabel.TabIndex = 16;
            payment_statusLabel.Text = "Payment Status";
            // 
            // payment_statusTextBox
            // 
            this.payment_statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoice_tabBindingSource, "payment_status", true));
            this.payment_statusTextBox.Location = new System.Drawing.Point(405, 67);
            this.payment_statusTextBox.Name = "payment_statusTextBox";
            this.payment_statusTextBox.Size = new System.Drawing.Size(100, 20);
            this.payment_statusTextBox.TabIndex = 17;
            // 
            // invoice_tabDataGridView
            // 
            this.invoice_tabDataGridView.AllowUserToAddRows = false;
            this.invoice_tabDataGridView.AllowUserToDeleteRows = false;
            this.invoice_tabDataGridView.AutoGenerateColumns = false;
            this.invoice_tabDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.invoice_tabDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.invoice_tabDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoice_tabDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.invoice_tabDataGridView.DataSource = this.invoice_tabBindingSource;
            this.invoice_tabDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.invoice_tabDataGridView.Location = new System.Drawing.Point(12, 3);
            this.invoice_tabDataGridView.Name = "invoice_tabDataGridView";
            this.invoice_tabDataGridView.ReadOnly = true;
            this.invoice_tabDataGridView.RowHeadersVisible = false;
            this.invoice_tabDataGridView.Size = new System.Drawing.Size(190, 189);
            this.invoice_tabDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "invoice_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Invoice Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // InvoiceDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1001, 518);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InvoiceDetail";
            this.Text = "Invoice Detail";
            this.Load += new System.EventHandler(this.InvoiceDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoice_tabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRawMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoice_tabDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private DataSetRawMaterial dataSetRawMaterial;
        private System.Windows.Forms.BindingSource invoice_tabBindingSource;
        private DataSetRawMaterialTableAdapters.invoice_tabTableAdapter invoice_tabTableAdapter;
        private DataSetRawMaterialTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox supplier_idTextBox;
        private System.Windows.Forms.TextBox invoice_idTextBox;
        private System.Windows.Forms.TextBox payment_statusTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.DataGridView invoice_tabDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}