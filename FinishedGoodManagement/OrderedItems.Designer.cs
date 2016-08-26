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
            this.txitid = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(318, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(614, 419);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
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
            this.button1.Location = new System.Drawing.Point(119, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
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
            // pro_id
            // 
            this.pro_id.Location = new System.Drawing.Point(117, 19);
            this.pro_id.Name = "pro_id";
            this.pro_id.Size = new System.Drawing.Size(157, 20);
            this.pro_id.TabIndex = 2;
            this.pro_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pro_id_KeyPress);
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
            this.pro_quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pro_quantity_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Maximum Retail Price";
            // 
            // pro_amound
            // 
            this.pro_amound.Location = new System.Drawing.Point(117, 90);
            this.pro_amound.Name = "pro_amound";
            this.pro_amound.Size = new System.Drawing.Size(157, 20);
            this.pro_amound.TabIndex = 2;
            this.pro_amound.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pro_amound_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Unit Price";
            // 
            // txt_amound
            // 
            this.txt_amound.Location = new System.Drawing.Point(117, 119);
            this.txt_amound.Name = "txt_amound";
            this.txt_amound.Size = new System.Drawing.Size(157, 20);
            this.txt_amound.TabIndex = 2;
            this.txt_amound.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_amound_KeyPress);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "ADD";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(223, 311);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 350);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 23);
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
            this.groupBox2.Location = new System.Drawing.Point(24, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 147);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ordered Goods";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(436, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Search by Order ID";
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
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(156, 350);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Clear All";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // OrderedItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 490);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txitid);
            this.Controls.Add(this.txtorder);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.date_delivery);
            this.Controls.Add(this.date_order);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "OrderedItems";
            this.Text = "OrderItems";
            this.Load += new System.EventHandler(this.OrderedItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Label txitid;
        private System.Windows.Forms.Button button5;
    }
}