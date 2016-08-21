﻿namespace RawMaterialManagement.Invoice_Management
{
    partial class InvoiceDetails
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
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.raw_invoice_tabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rawDataSet = new RawMaterialManagement.RawDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnChooseOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInvoiceId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.raw_invoice_tabTableAdapter = new RawMaterialManagement.RawDataSetTableAdapters.raw_invoice_tabTableAdapter();
            this.tableAdapterManager = new RawMaterialManagement.RawDataSetTableAdapters.TableAdapterManager();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridViewBase1 = new FrameworkControls.Controls.DataGridViewBase();
            this.invoiceidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.raw_invoice_tabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBase1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 28);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Net Value";
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.raw_invoice_tabBindingSource, "net_value", true));
            this.textBox6.Location = new System.Drawing.Point(10, 48);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(128, 22);
            this.textBox6.TabIndex = 13;
            // 
            // raw_invoice_tabBindingSource
            // 
            this.raw_invoice_tabBindingSource.DataMember = "raw_invoice_tab";
            this.raw_invoice_tabBindingSource.DataSource = this.rawDataSet;
            // 
            // rawDataSet
            // 
            this.rawDataSet.DataSetName = "RawDataSet";
            this.rawDataSet.EnforceConstraints = false;
            this.rawDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(3, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 86);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment";
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.raw_invoice_tabBindingSource, "gross_value", true));
            this.textBox8.Location = new System.Drawing.Point(282, 48);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(128, 22);
            this.textBox8.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(279, 28);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Gross Value";
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.raw_invoice_tabBindingSource, "tax_value", true));
            this.textBox7.Location = new System.Drawing.Point(146, 48);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(128, 22);
            this.textBox7.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(143, 28);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Tax Value";
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1125, 73);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripMenuItem3.Image = global::RawMaterialManagement.Properties.Resources.ic_add_circle_outline_2x;
            this.toolStripMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(60, 69);
            this.toolStripMenuItem3.Text = "New";
            this.toolStripMenuItem3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saveToolStripMenuItem.Image = global::RawMaterialManagement.Properties.Resources.ic_save_2x;
            this.saveToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(60, 69);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripMenuItem1.Image = global::RawMaterialManagement.Properties.Resources.ic_delete_2x;
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(60, 69);
            this.toolStripMenuItem1.Text = "Delete";
            this.toolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripMenuItem2.Image = global::RawMaterialManagement.Properties.Resources.ic_file_download_2x;
            this.toolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(70, 69);
            this.toolStripMenuItem2.Text = "Populate";
            this.toolStripMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripMenuItem4.Image = global::RawMaterialManagement.Properties.Resources.ic_search_2x;
            this.toolStripMenuItem4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(60, 69);
            this.toolStripMenuItem4.Text = "Search";
            this.toolStripMenuItem4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1125, 598);
            this.panel1.TabIndex = 31;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewBase1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1125, 598);
            this.splitContainer1.SplitterDistance = 168;
            this.splitContainer1.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.dateTimePicker3);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.btnChooseOrder);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtInvoiceId);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtOrderId);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(615, 214);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Invoice";
            // 
            // btnChooseOrder
            // 
            this.btnChooseOrder.BackColor = System.Drawing.Color.OliveDrab;
            this.btnChooseOrder.FlatAppearance.BorderSize = 0;
            this.btnChooseOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btnChooseOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChooseOrder.Location = new System.Drawing.Point(463, 51);
            this.btnChooseOrder.Name = "btnChooseOrder";
            this.btnChooseOrder.Size = new System.Drawing.Size(140, 26);
            this.btnChooseOrder.TabIndex = 17;
            this.btnChooseOrder.Text = "Choose Order";
            this.btnChooseOrder.UseVisualStyleBackColor = false;
            this.btnChooseOrder.Click += new System.EventHandler(this.btnChooseOrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Invoice Id";
            // 
            // txtInvoiceId
            // 
            this.txtInvoiceId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.raw_invoice_tabBindingSource, "invoice_id", true));
            this.txtInvoiceId.Location = new System.Drawing.Point(10, 51);
            this.txtInvoiceId.Margin = new System.Windows.Forms.Padding(4);
            this.txtInvoiceId.Name = "txtInvoiceId";
            this.txtInvoiceId.Size = new System.Drawing.Size(219, 22);
            this.txtInvoiceId.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(461, 86);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Status";
            // 
            // txtOrderId
            // 
            this.txtOrderId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.raw_invoice_tabBindingSource, "order_id", true));
            this.txtOrderId.Location = new System.Drawing.Point(237, 51);
            this.txtOrderId.Margin = new System.Windows.Forms.Padding(4);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.ReadOnly = true;
            this.txtOrderId.Size = new System.Drawing.Size(219, 22);
            this.txtOrderId.TabIndex = 2;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.raw_invoice_tabBindingSource, "status", true));
            this.textBox5.Location = new System.Drawing.Point(464, 106);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(139, 22);
            this.textBox5.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Order Number";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.raw_invoice_tabBindingSource, "currency", true));
            this.textBox4.Location = new System.Drawing.Point(10, 106);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(219, 22);
            this.textBox4.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 88);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Currency";
            // 
            // raw_invoice_tabTableAdapter
            // 
            this.raw_invoice_tabTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.raw_invoice_tabTableAdapter = this.raw_invoice_tabTableAdapter;
            this.tableAdapterManager.raw_item_tabTableAdapter = null;
            this.tableAdapterManager.raw_order_lineTableAdapter = null;
            this.tableAdapterManager.raw_purchase_orderTableAdapter = null;
            this.tableAdapterManager.raw_supplier_tabTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RawMaterialManagement.RawDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.raw_invoice_tabBindingSource, "due_date", true));
            this.dateTimePicker2.Location = new System.Drawing.Point(10, 165);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(219, 22);
            this.dateTimePicker2.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Due Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.raw_invoice_tabBindingSource, "due_date", true));
            this.label10.Location = new System.Drawing.Point(234, 146);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "Original Due Date";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.raw_invoice_tabBindingSource, "original_due_date", true));
            this.dateTimePicker3.Location = new System.Drawing.Point(236, 165);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(219, 22);
            this.dateTimePicker3.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.raw_invoice_tabBindingSource, "discount", true));
            this.textBox1.Location = new System.Drawing.Point(418, 48);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 22);
            this.textBox1.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(415, 28);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Discount";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.raw_invoice_tabBindingSource, "date", true));
            this.textBox2.Location = new System.Drawing.Point(237, 106);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(219, 22);
            this.textBox2.TabIndex = 22;
            // 
            // dataGridViewBase1
            // 
            this.dataGridViewBase1.AllowUserToAddRows = false;
            this.dataGridViewBase1.AllowUserToDeleteRows = false;
            this.dataGridViewBase1.AllowUserToResizeRows = false;
            this.dataGridViewBase1.AutoGenerateColumns = false;
            this.dataGridViewBase1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBase1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewBase1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBase1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoiceidDataGridViewTextBoxColumn,
            this.order_id});
            this.dataGridViewBase1.DataSource = this.raw_invoice_tabBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBase1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBase1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBase1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewBase1.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBase1.Name = "dataGridViewBase1";
            this.dataGridViewBase1.ReadOnly = true;
            this.dataGridViewBase1.RowHeadersVisible = false;
            this.dataGridViewBase1.RowTemplate.Height = 30;
            this.dataGridViewBase1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBase1.Size = new System.Drawing.Size(168, 598);
            this.dataGridViewBase1.TabIndex = 0;
            // 
            // invoiceidDataGridViewTextBoxColumn
            // 
            this.invoiceidDataGridViewTextBoxColumn.DataPropertyName = "invoice_id";
            this.invoiceidDataGridViewTextBoxColumn.HeaderText = "INVOICE ID";
            this.invoiceidDataGridViewTextBoxColumn.Name = "invoiceidDataGridViewTextBoxColumn";
            this.invoiceidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // order_id
            // 
            this.order_id.DataPropertyName = "order_id";
            this.order_id.HeaderText = "ORDER ID";
            this.order_id.Name = "order_id";
            this.order_id.ReadOnly = true;
            // 
            // InvoiceDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 598);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InvoiceDetails";
            this.Text = "InvoiceDetails";
            this.Load += new System.EventHandler(this.InvoiceDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.raw_invoice_tabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBase1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.Panel panel1;
        private RawDataSet rawDataSet;
        private System.Windows.Forms.BindingSource raw_invoice_tabBindingSource;
        private RawDataSetTableAdapters.raw_invoice_tabTableAdapter raw_invoice_tabTableAdapter;
        private RawDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInvoiceId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private FrameworkControls.Controls.DataGridViewBase dataGridViewBase1;
        private System.Windows.Forms.Button btnChooseOrder;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_id;
    }
}