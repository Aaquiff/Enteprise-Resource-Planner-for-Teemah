namespace FinishedGoodManagement
{
    partial class OrderedItems
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.date_order = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.date_delivery = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pro_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pro_quantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pro_amound = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.status = new System.Windows.Forms.ComboBox();
            this.pro_id = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtorder = new System.Windows.Forms.TextBox();
            this.txitid = new System.Windows.Forms.Label();
            this.dataGridView1 = new MetroFramework.Controls.MetroGrid();
            this.quantityy = new System.Windows.Forms.Label();
            this.order = new System.Windows.Forms.Label();
            this.totalquantity = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // date_order
            // 
            this.date_order.Location = new System.Drawing.Point(98, 23);
            this.date_order.Name = "date_order";
            this.date_order.Size = new System.Drawing.Size(200, 20);
            this.date_order.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "UPDATE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ordered Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Delivery Date";
            // 
            // date_delivery
            // 
            this.date_delivery.Location = new System.Drawing.Point(98, 69);
            this.date_delivery.Name = "date_delivery";
            this.date_delivery.Size = new System.Drawing.Size(200, 20);
            this.date_delivery.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Product ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Product Name";
            // 
            // pro_name
            // 
            this.pro_name.Location = new System.Drawing.Point(117, 43);
            this.pro_name.Name = "pro_name";
            this.pro_name.ReadOnly = true;
            this.pro_name.Size = new System.Drawing.Size(157, 20);
            this.pro_name.TabIndex = 2;
            this.pro_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pro_name_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Quantity";
            // 
            // pro_quantity
            // 
            this.pro_quantity.Location = new System.Drawing.Point(117, 67);
            this.pro_quantity.Name = "pro_quantity";
            this.pro_quantity.Size = new System.Drawing.Size(157, 20);
            this.pro_quantity.TabIndex = 2;
            this.pro_quantity.TextChanged += new System.EventHandler(this.pro_quantity_TextChanged);
            this.pro_quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pro_quantity_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Unit Price";
            // 
            // pro_amound
            // 
            this.pro_amound.Location = new System.Drawing.Point(117, 90);
            this.pro_amound.Name = "pro_amound";
            this.pro_amound.ReadOnly = true;
            this.pro_amound.Size = new System.Drawing.Size(157, 20);
            this.pro_amound.TabIndex = 2;
            this.pro_amound.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pro_amound_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Status";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(168, 311);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 33);
            this.button4.TabIndex = 5;
            this.button4.Text = "PRINT INVOICE";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.status);
            this.groupBox2.Controls.Add(this.pro_id);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.pro_name);
            this.groupBox2.Controls.Add(this.pro_quantity);
            this.groupBox2.Controls.Add(this.pro_amound);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(24, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 147);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ordered Goods";
            // 
            // status
            // 
            this.status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "Pending",
            "Approved",
            "Cancel"});
            this.status.Location = new System.Drawing.Point(117, 116);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(157, 21);
            this.status.TabIndex = 13;
            // 
            // pro_id
            // 
            this.pro_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pro_id.FormattingEnabled = true;
            this.pro_id.Location = new System.Drawing.Point(117, 16);
            this.pro_id.Name = "pro_id";
            this.pro_id.Size = new System.Drawing.Size(157, 21);
            this.pro_id.TabIndex = 3;
            this.pro_id.TextChanged += new System.EventHandler(this.pro_id_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(436, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Search by Invoice ID";
            // 
            // txtorder
            // 
            this.txtorder.Location = new System.Drawing.Point(561, 16);
            this.txtorder.Name = "txtorder";
            this.txtorder.Size = new System.Drawing.Size(135, 20);
            this.txtorder.TabIndex = 8;
            this.txtorder.TextChanged += new System.EventHandler(this.txtorder_TextChanged);
            // 
            // txitid
            // 
            this.txitid.AutoSize = true;
            this.txitid.Location = new System.Drawing.Point(21, 0);
            this.txitid.Name = "txitid";
            this.txitid.Size = new System.Drawing.Size(35, 13);
            this.txitid.TabIndex = 9;
            this.txitid.Text = "label1";
            this.txitid.Visible = false;
            this.txitid.Click += new System.EventHandler(this.txitid_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(412, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(623, 365);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick_1);
            // 
            // quantityy
            // 
            this.quantityy.AutoSize = true;
            this.quantityy.Location = new System.Drawing.Point(207, 8);
            this.quantityy.Name = "quantityy";
            this.quantityy.Size = new System.Drawing.Size(35, 13);
            this.quantityy.TabIndex = 13;
            this.quantityy.Text = "label1";
            this.quantityy.Visible = false;
            // 
            // order
            // 
            this.order.AutoSize = true;
            this.order.Location = new System.Drawing.Point(332, 10);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(35, 13);
            this.order.TabIndex = 14;
            this.order.Text = "label1";
            this.order.Visible = false;
            // 
            // totalquantity
            // 
            this.totalquantity.AutoSize = true;
            this.totalquantity.Location = new System.Drawing.Point(371, 66);
            this.totalquantity.Name = "totalquantity";
            this.totalquantity.Size = new System.Drawing.Size(35, 13);
            this.totalquantity.TabIndex = 15;
            this.totalquantity.Text = "label1";
            this.totalquantity.Visible = false;
            // 
            // OrderedItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 490);
            this.Controls.Add(this.totalquantity);
            this.Controls.Add(this.order);
            this.Controls.Add(this.quantityy);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txitid);
            this.Controls.Add(this.txtorder);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.date_delivery);
            this.Controls.Add(this.date_order);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "OrderedItems";
            this.Text = "OrderItems";
            this.Load += new System.EventHandler(this.OrderedItems_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker date_order;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker date_delivery;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pro_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pro_quantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pro_amound;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtorder;
        private System.Windows.Forms.Label txitid;
        private System.Windows.Forms.ComboBox pro_id;
        private MetroFramework.Controls.MetroGrid dataGridView1;
        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.Label quantityy;
        private System.Windows.Forms.Label order;
        private System.Windows.Forms.Label totalquantity;
    }
}