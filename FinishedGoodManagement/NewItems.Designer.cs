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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.txt_receive = new System.Windows.Forms.Label();
            this.txt_receiveddate = new System.Windows.Forms.DateTimePicker();
            this.batchno = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.manufactureddate = new System.Windows.Forms.DateTimePicker();
            this.expireddate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 639);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Seach By ID";
            // 
            // txtid
            // 
            this.txtid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtid.Location = new System.Drawing.Point(104, 14);
            this.txtid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(527, 25);
            this.txtid.TabIndex = 10;
            this.txtid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(440, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 690);
            this.panel1.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 51);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(645, 639);
            this.panel3.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtid);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(645, 51);
            this.panel4.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 17);
            this.label11.TabIndex = 13;
            this.label11.Text = "Batch No";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(271, 566);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(87, 44);
            this.button6.TabIndex = 21;
            this.button6.Text = "DELETE";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // txt_receive
            // 
            this.txt_receive.AutoSize = true;
            this.txt_receive.Location = new System.Drawing.Point(20, 55);
            this.txt_receive.Name = "txt_receive";
            this.txt_receive.Size = new System.Drawing.Size(91, 17);
            this.txt_receive.TabIndex = 14;
            this.txt_receive.Text = "Received Date";
            // 
            // txt_receiveddate
            // 
            this.txt_receiveddate.Location = new System.Drawing.Point(133, 51);
            this.txt_receiveddate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_receiveddate.Name = "txt_receiveddate";
            this.txt_receiveddate.Size = new System.Drawing.Size(257, 25);
            this.txt_receiveddate.TabIndex = 22;
            // 
            // batchno
            // 
            this.batchno.Location = new System.Drawing.Point(133, 90);
            this.batchno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.batchno.Name = "batchno";
            this.batchno.Size = new System.Drawing.Size(257, 25);
            this.batchno.TabIndex = 17;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(157, 566);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 44);
            this.button5.TabIndex = 20;
            this.button5.Text = "UPDATE";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.manufactureddate);
            this.groupBox3.Controls.Add(this.expireddate);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(23, 137);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(379, 166);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Date";
            // 
            // manufactureddate
            // 
            this.manufactureddate.Location = new System.Drawing.Point(24, 58);
            this.manufactureddate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.manufactureddate.Name = "manufactureddate";
            this.manufactureddate.Size = new System.Drawing.Size(342, 25);
            this.manufactureddate.TabIndex = 1;
            // 
            // expireddate
            // 
            this.expireddate.Location = new System.Drawing.Point(24, 123);
            this.expireddate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.expireddate.Name = "expireddate";
            this.expireddate.Size = new System.Drawing.Size(342, 25);
            this.expireddate.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Manufactured Date";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Expired Date";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(48, 566);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 44);
            this.button4.TabIndex = 19;
            this.button4.Text = "ADD";
            this.button4.UseVisualStyleBackColor = true;
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
            this.groupBox2.Location = new System.Drawing.Point(23, 311);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(379, 226);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product Detail";
            // 
            // packet
            // 
            this.packet.AutoSize = true;
            this.packet.Location = new System.Drawing.Point(217, 182);
            this.packet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.packet.Name = "packet";
            this.packet.Size = new System.Drawing.Size(63, 21);
            this.packet.TabIndex = 9;
            this.packet.TabStop = true;
            this.packet.Text = "Packet";
            this.packet.UseVisualStyleBackColor = true;
            // 
            // box
            // 
            this.box.AutoSize = true;
            this.box.Location = new System.Drawing.Point(134, 182);
            this.box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(47, 21);
            this.box.TabIndex = 9;
            this.box.TabStop = true;
            this.box.Text = "Box";
            this.box.UseVisualStyleBackColor = true;
            // 
            // priceperunit
            // 
            this.priceperunit.Location = new System.Drawing.Point(134, 148);
            this.priceperunit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.priceperunit.Name = "priceperunit";
            this.priceperunit.Size = new System.Drawing.Size(233, 25);
            this.priceperunit.TabIndex = 2;
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(134, 112);
            this.quantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(233, 25);
            this.quantity.TabIndex = 2;
            // 
            // productname
            // 
            this.productname.Location = new System.Drawing.Point(134, 76);
            this.productname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.productname.Name = "productname";
            this.productname.Size = new System.Drawing.Size(233, 25);
            this.productname.TabIndex = 2;
            // 
            // productid
            // 
            this.productid.Location = new System.Drawing.Point(134, 34);
            this.productid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.productid.Name = "productid";
            this.productid.Size = new System.Drawing.Size(233, 25);
            this.productid.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Product ID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(21, 76);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "Product Name";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(21, 112);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 17);
            this.label16.TabIndex = 0;
            this.label16.Text = "Quantity";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(21, 148);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 17);
            this.label17.TabIndex = 0;
            this.label17.Text = "Price Per Unit";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(21, 187);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 17);
            this.label18.TabIndex = 0;
            this.label18.Text = "Packed";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(133, 17);
            this.txt_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(257, 25);
            this.txt_id.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txt_id);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.txt_receive);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.txt_receiveddate);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.batchno);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(440, 690);
            this.panel2.TabIndex = 23;
            // 
            // NewItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 690);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NewItems";
            this.Text = "Add Item";
            this.Load += new System.EventHandler(this.NewItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label txt_receive;
        private System.Windows.Forms.DateTimePicker txt_receiveddate;
        private System.Windows.Forms.TextBox batchno;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker manufactureddate;
        private System.Windows.Forms.DateTimePicker expireddate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton packet;
        private System.Windows.Forms.RadioButton box;
        private System.Windows.Forms.TextBox priceperunit;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.TextBox productname;
        private System.Windows.Forms.TextBox productid;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Panel panel2;
    }
}