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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_orderID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.date_order = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.date_delivery = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.pro_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pro_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pro_quantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pro_amound = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_amound = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtorder = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ordered ID";
            // 
            // txt_orderID
            // 
            this.txt_orderID.Location = new System.Drawing.Point(106, 10);
            this.txt_orderID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_orderID.Name = "txt_orderID";
            this.txt_orderID.Size = new System.Drawing.Size(233, 25);
            this.txt_orderID.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1162, 732);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // date_order
            // 
            this.date_order.Location = new System.Drawing.Point(106, 60);
            this.date_order.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.date_order.Name = "date_order";
            this.date_order.Size = new System.Drawing.Size(233, 25);
            this.date_order.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(131, 424);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "UPDATE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ordered Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Delivery Date";
            // 
            // date_delivery
            // 
            this.date_delivery.Location = new System.Drawing.Point(106, 109);
            this.date_delivery.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.date_delivery.Name = "date_delivery";
            this.date_delivery.Size = new System.Drawing.Size(233, 25);
            this.date_delivery.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Product ID";
            // 
            // pro_id
            // 
            this.pro_id.Location = new System.Drawing.Point(136, 25);
            this.pro_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pro_id.Name = "pro_id";
            this.pro_id.Size = new System.Drawing.Size(182, 25);
            this.pro_id.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Product Name";
            // 
            // pro_name
            // 
            this.pro_name.Location = new System.Drawing.Point(136, 56);
            this.pro_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pro_name.Name = "pro_name";
            this.pro_name.Size = new System.Drawing.Size(182, 25);
            this.pro_name.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Quantity";
            // 
            // pro_quantity
            // 
            this.pro_quantity.Location = new System.Drawing.Point(136, 88);
            this.pro_quantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pro_quantity.Name = "pro_quantity";
            this.pro_quantity.Size = new System.Drawing.Size(182, 25);
            this.pro_quantity.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Max Retail Price";
            // 
            // pro_amound
            // 
            this.pro_amound.Location = new System.Drawing.Point(136, 121);
            this.pro_amound.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pro_amound.Name = "pro_amound";
            this.pro_amound.Size = new System.Drawing.Size(182, 25);
            this.pro_amound.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Unit Price";
            // 
            // txt_amound
            // 
            this.txt_amound.Location = new System.Drawing.Point(136, 156);
            this.txt_amound.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_amound.Name = "txt_amound";
            this.txt_amound.Size = new System.Drawing.Size(182, 25);
            this.txt_amound.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 424);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 30);
            this.button2.TabIndex = 5;
            this.button2.Text = "ADD";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(252, 424);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 30);
            this.button3.TabIndex = 5;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(106, 463);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 30);
            this.button4.TabIndex = 5;
            this.button4.Text = "PRINT INVOICE";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.pro_name);
            this.groupBox2.Controls.Add(this.pro_id);
            this.groupBox2.Controls.Add(this.pro_quantity);
            this.groupBox2.Controls.Add(this.pro_amound);
            this.groupBox2.Controls.Add(this.txt_amound);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(20, 170);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(336, 192);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ordered Goods";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Search by Order ID";
            // 
            // txtorder
            // 
            this.txtorder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtorder.Location = new System.Drawing.Point(129, 10);
            this.txtorder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtorder.Name = "txtorder";
            this.txtorder.Size = new System.Drawing.Size(1021, 25);
            this.txtorder.TabIndex = 8;
            this.txtorder.TextChanged += new System.EventHandler(this.txtorder_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.txt_orderID);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.date_order);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.date_delivery);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 779);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(364, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1162, 779);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtorder);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1162, 47);
            this.panel3.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 47);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1162, 732);
            this.panel4.TabIndex = 11;
            // 
            // OrderedItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1526, 779);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OrderedItems";
            this.Text = "OrderItems";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_orderID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker date_order;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker date_delivery;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pro_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pro_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pro_quantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pro_amound;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_amound;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtorder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
    }
}