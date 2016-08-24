namespace FinanceManagement
{
    partial class Asset_Repair_US
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.radioButton_cannot = new System.Windows.Forms.RadioButton();
            this.radioButton_done = new System.Windows.Forms.RadioButton();
            this.radioButton_pending = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker_repair = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_repairid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_refresh = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.checkBox_warranty = new System.Windows.Forms.CheckBox();
            this.checkBox_insurance = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button_back = new System.Windows.Forms.Button();
            this.richTextBox_problem = new System.Windows.Forms.RichTextBox();
            this.textBox_serialnumber = new System.Windows.Forms.TextBox();
            this.textBox_assetID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_search = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_search);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.radioButton_cannot);
            this.panel1.Controls.Add(this.radioButton_done);
            this.panel1.Controls.Add(this.radioButton_pending);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dateTimePicker_repair);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox_repairid);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button_refresh);
            this.panel1.Controls.Add(this.button_update);
            this.panel1.Controls.Add(this.checkBox_warranty);
            this.panel1.Controls.Add(this.checkBox_insurance);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.button_back);
            this.panel1.Controls.Add(this.richTextBox_problem);
            this.panel1.Controls.Add(this.textBox_serialnumber);
            this.panel1.Controls.Add(this.textBox_assetID);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 461);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView2.Location = new System.Drawing.Point(364, 23);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(408, 363);
            this.dataGridView2.TabIndex = 97;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // radioButton_cannot
            // 
            this.radioButton_cannot.AutoSize = true;
            this.radioButton_cannot.Location = new System.Drawing.Point(262, 182);
            this.radioButton_cannot.Name = "radioButton_cannot";
            this.radioButton_cannot.Size = new System.Drawing.Size(75, 17);
            this.radioButton_cannot.TabIndex = 96;
            this.radioButton_cannot.TabStop = true;
            this.radioButton_cannot.Text = "Cannot Fix";
            this.radioButton_cannot.UseVisualStyleBackColor = true;
            this.radioButton_cannot.CheckedChanged += new System.EventHandler(this.radioButton_cannot_CheckedChanged);
            // 
            // radioButton_done
            // 
            this.radioButton_done.AutoSize = true;
            this.radioButton_done.Location = new System.Drawing.Point(205, 182);
            this.radioButton_done.Name = "radioButton_done";
            this.radioButton_done.Size = new System.Drawing.Size(51, 17);
            this.radioButton_done.TabIndex = 95;
            this.radioButton_done.TabStop = true;
            this.radioButton_done.Text = "Done";
            this.radioButton_done.UseVisualStyleBackColor = true;
            this.radioButton_done.CheckedChanged += new System.EventHandler(this.radioButton_done_CheckedChanged);
            // 
            // radioButton_pending
            // 
            this.radioButton_pending.AutoSize = true;
            this.radioButton_pending.Location = new System.Drawing.Point(135, 182);
            this.radioButton_pending.Name = "radioButton_pending";
            this.radioButton_pending.Size = new System.Drawing.Size(64, 17);
            this.radioButton_pending.TabIndex = 94;
            this.radioButton_pending.TabStop = true;
            this.radioButton_pending.Text = "Pending";
            this.radioButton_pending.UseVisualStyleBackColor = true;
            this.radioButton_pending.CheckedChanged += new System.EventHandler(this.radioButton_pending_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 93;
            this.label5.Text = "Status :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dateTimePicker_repair
            // 
            this.dateTimePicker_repair.Location = new System.Drawing.Point(135, 105);
            this.dateTimePicker_repair.Name = "dateTimePicker_repair";
            this.dateTimePicker_repair.Size = new System.Drawing.Size(205, 20);
            this.dateTimePicker_repair.TabIndex = 92;
            this.dateTimePicker_repair.ValueChanged += new System.EventHandler(this.dateTimePicker_repair_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 91;
            this.label4.Text = "Date :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox_repairid
            // 
            this.textBox_repairid.Location = new System.Drawing.Point(135, 23);
            this.textBox_repairid.Name = "textBox_repairid";
            this.textBox_repairid.Size = new System.Drawing.Size(205, 20);
            this.textBox_repairid.TabIndex = 90;
            this.textBox_repairid.TextChanged += new System.EventHandler(this.textBox_repairid_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 89;
            this.label3.Text = "Repair ID :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_refresh.Location = new System.Drawing.Point(685, 395);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(87, 42);
            this.button_refresh.TabIndex = 88;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = false;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.Location = new System.Drawing.Point(577, 395);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(87, 42);
            this.button_update.TabIndex = 87;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_add_Click);
            // 
            // checkBox_warranty
            // 
            this.checkBox_warranty.AutoSize = true;
            this.checkBox_warranty.Location = new System.Drawing.Point(135, 252);
            this.checkBox_warranty.Name = "checkBox_warranty";
            this.checkBox_warranty.Size = new System.Drawing.Size(44, 17);
            this.checkBox_warranty.TabIndex = 86;
            this.checkBox_warranty.Text = "Yes";
            this.checkBox_warranty.UseVisualStyleBackColor = true;
            this.checkBox_warranty.CheckedChanged += new System.EventHandler(this.checkBox_warranty_CheckedChanged);
            // 
            // checkBox_insurance
            // 
            this.checkBox_insurance.AutoSize = true;
            this.checkBox_insurance.Location = new System.Drawing.Point(135, 216);
            this.checkBox_insurance.Name = "checkBox_insurance";
            this.checkBox_insurance.Size = new System.Drawing.Size(44, 17);
            this.checkBox_insurance.TabIndex = 85;
            this.checkBox_insurance.Text = "Yes";
            this.checkBox_insurance.UseVisualStyleBackColor = true;
            this.checkBox_insurance.CheckedChanged += new System.EventHandler(this.checkBox_insurance_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 84;
            this.label10.Text = "Warranty :";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 83;
            this.label9.Text = "Insurance :";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.Location = new System.Drawing.Point(364, 395);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(87, 42);
            this.button_back.TabIndex = 82;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // richTextBox_problem
            // 
            this.richTextBox_problem.Location = new System.Drawing.Point(135, 295);
            this.richTextBox_problem.Name = "richTextBox_problem";
            this.richTextBox_problem.Size = new System.Drawing.Size(205, 111);
            this.richTextBox_problem.TabIndex = 81;
            this.richTextBox_problem.Text = "Please enter the problem specified";
            this.richTextBox_problem.TextChanged += new System.EventHandler(this.richTextBox_problem_TextChanged);
            // 
            // textBox_serialnumber
            // 
            this.textBox_serialnumber.Location = new System.Drawing.Point(135, 144);
            this.textBox_serialnumber.Name = "textBox_serialnumber";
            this.textBox_serialnumber.Size = new System.Drawing.Size(205, 20);
            this.textBox_serialnumber.TabIndex = 80;
            this.textBox_serialnumber.TextChanged += new System.EventHandler(this.textBox_serialnumber_TextChanged);
            // 
            // textBox_assetID
            // 
            this.textBox_assetID.Location = new System.Drawing.Point(135, 63);
            this.textBox_assetID.Name = "textBox_assetID";
            this.textBox_assetID.Size = new System.Drawing.Size(205, 20);
            this.textBox_assetID.TabIndex = 79;
            this.textBox_assetID.TextChanged += new System.EventHandler(this.textBox_assetID_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 78;
            this.label8.Text = "Problem :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 77;
            this.label2.Text = "Asset ID :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 76;
            this.label1.Text = "Serial Number :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.Location = new System.Drawing.Point(472, 395);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(87, 42);
            this.button_search.TabIndex = 98;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Asset_Repair_US
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel1);
            this.Name = "Asset_Repair_US";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asset Repair Status Update and Search";
            this.Load += new System.EventHandler(this.Asset_Repair_US_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.RadioButton radioButton_cannot;
        private System.Windows.Forms.RadioButton radioButton_done;
        private System.Windows.Forms.RadioButton radioButton_pending;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker_repair;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_repairid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.CheckBox checkBox_warranty;
        private System.Windows.Forms.CheckBox checkBox_insurance;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.RichTextBox richTextBox_problem;
        private System.Windows.Forms.TextBox textBox_serialnumber;
        private System.Windows.Forms.TextBox textBox_assetID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.ErrorProvider errorProvider1;

    }
}