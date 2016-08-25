namespace FinishedGoodManagement
{
    partial class NewItems
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
            this.txt_receiveddate = new System.Windows.Forms.DateTimePicker();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.batchno = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.manufactureddate = new System.Windows.Forms.DateTimePicker();
            this.expireddate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.packet = new System.Windows.Forms.RadioButton();
            this.box = new System.Windows.Forms.RadioButton();
            this.priceperunit = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.TextBox();
            this.productname = new System.Windows.Forms.TextBox();
            this.productid = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_receive = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_receiveddate
            // 
            this.txt_receiveddate.Location = new System.Drawing.Point(97, 44);
            this.txt_receiveddate.Name = "txt_receiveddate";
            this.txt_receiveddate.Size = new System.Drawing.Size(163, 20);
            this.txt_receiveddate.TabIndex = 8;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(227, 410);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "DELETE";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(130, 410);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "UPDATE";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(401, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(551, 416);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(36, 410);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "ADD";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(97, 18);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(163, 20);
            this.txt_id.TabIndex = 2;
            // 
            // batchno
            // 
            this.batchno.Location = new System.Drawing.Point(97, 74);
            this.batchno.Name = "batchno";
            this.batchno.Size = new System.Drawing.Size(163, 20);
            this.batchno.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.manufactureddate);
            this.groupBox3.Controls.Add(this.expireddate);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(15, 110);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(380, 100);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Date";
            // 
            // manufactureddate
            // 
            this.manufactureddate.Location = new System.Drawing.Point(115, 23);
            this.manufactureddate.Name = "manufactureddate";
            this.manufactureddate.Size = new System.Drawing.Size(200, 20);
            this.manufactureddate.TabIndex = 1;
            // 
            // expireddate
            // 
            this.expireddate.Location = new System.Drawing.Point(115, 63);
            this.expireddate.Name = "expireddate";
            this.expireddate.Size = new System.Drawing.Size(200, 20);
            this.expireddate.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Manufactured Date";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Expired Date";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.packet);
            this.groupBox2.Controls.Add(this.box);
            this.groupBox2.Controls.Add(this.priceperunit);
            this.groupBox2.Controls.Add(this.quantity);
            this.groupBox2.Controls.Add(this.productname);
            this.groupBox2.Controls.Add(this.productid);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Location = new System.Drawing.Point(15, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 159);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product Detail";
            // 
            // packet
            // 
            this.packet.AutoSize = true;
            this.packet.Location = new System.Drawing.Point(186, 139);
            this.packet.Name = "packet";
            this.packet.Size = new System.Drawing.Size(59, 17);
            this.packet.TabIndex = 9;
            this.packet.TabStop = true;
            this.packet.Text = "Packet";
            this.packet.UseVisualStyleBackColor = true;
            // 
            // box
            // 
            this.box.AutoSize = true;
            this.box.Location = new System.Drawing.Point(115, 139);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(43, 17);
            this.box.TabIndex = 9;
            this.box.TabStop = true;
            this.box.Text = "Box";
            this.box.UseVisualStyleBackColor = true;
            this.box.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // priceperunit
            // 
            this.priceperunit.Location = new System.Drawing.Point(115, 113);
            this.priceperunit.Name = "priceperunit";
            this.priceperunit.Size = new System.Drawing.Size(200, 20);
            this.priceperunit.TabIndex = 2;
            this.priceperunit.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(115, 86);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(200, 20);
            this.quantity.TabIndex = 2;
            this.quantity.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // productname
            // 
            this.productname.Location = new System.Drawing.Point(115, 58);
            this.productname.Name = "productname";
            this.productname.Size = new System.Drawing.Size(200, 20);
            this.productname.TabIndex = 2;
            this.productname.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // productid
            // 
            this.productid.Location = new System.Drawing.Point(115, 26);
            this.productid.Name = "productid";
            this.productid.Size = new System.Drawing.Size(200, 20);
            this.productid.TabIndex = 2;
            this.productid.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Product ID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 58);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Product Name";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 86);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Quantity";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 113);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Price Per Unit";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(18, 143);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Packed";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Batch No";
            // 
            // txt_receive
            // 
            this.txt_receive.AutoSize = true;
            this.txt_receive.Location = new System.Drawing.Point(12, 47);
            this.txt_receive.Name = "txt_receive";
            this.txt_receive.Size = new System.Drawing.Size(79, 13);
            this.txt_receive.TabIndex = 0;
            this.txt_receive.Text = "Received Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Seach By ID";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(604, 14);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 10;
            this.txtid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NewItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 484);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.txt_receiveddate);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.batchno);
            this.Controls.Add(this.txt_receive);
            this.Controls.Add(this.label11);
            this.Name = "NewItems";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.NewItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox batchno;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox productname;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label txt_receive;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker manufactureddate;
        private System.Windows.Forms.DateTimePicker expireddate;
        private System.Windows.Forms.TextBox priceperunit;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.TextBox productid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DateTimePicker txt_receiveddate;
        private System.Windows.Forms.RadioButton packet;
        private System.Windows.Forms.RadioButton box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
    }
}