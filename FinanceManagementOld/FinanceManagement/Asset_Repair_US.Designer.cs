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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton_cannot = new System.Windows.Forms.RadioButton();
            this.radioButton_done = new System.Windows.Forms.RadioButton();
            this.radioButton_pending = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker_repair = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_repairid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox_warranty = new System.Windows.Forms.CheckBox();
            this.checkBox_insurance = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.richTextBox_problem = new System.Windows.Forms.RichTextBox();
            this.textBox_serialnumber = new System.Windows.Forms.TextBox();
            this.textBox_assetID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridView2 = new MetroFramework.Controls.MetroGrid();
            this.repair = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Problem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warranty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insurance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_back = new MetroFramework.Controls.MetroButton();
            this.button_search = new MetroFramework.Controls.MetroButton();
            this.button_update = new MetroFramework.Controls.MetroButton();
            this.button_refresh = new MetroFramework.Controls.MetroButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_refresh);
            this.panel1.Controls.Add(this.button_update);
            this.panel1.Controls.Add(this.button_search);
            this.panel1.Controls.Add(this.button_back);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.radioButton_cannot);
            this.panel1.Controls.Add(this.radioButton_done);
            this.panel1.Controls.Add(this.radioButton_pending);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dateTimePicker_repair);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox_repairid);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.checkBox_warranty);
            this.panel1.Controls.Add(this.checkBox_insurance);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.ColumnHeadersHeight = 40;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.repair,
            this.asset,
            this.date,
            this.status,
            this.Problem,
            this.serial,
            this.warranty,
            this.insurance});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView2.Location = new System.Drawing.Point(364, 23);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(400, 366);
            this.dataGridView2.TabIndex = 99;
            this.dataGridView2.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentDoubleClick);
            // 
            // repair
            // 
            this.repair.DataPropertyName = "Repair_ID";
            this.repair.HeaderText = "Repair ID";
            this.repair.Name = "repair";
            this.repair.ReadOnly = true;
            // 
            // asset
            // 
            this.asset.DataPropertyName = "Asset_ID";
            this.asset.HeaderText = "Asset ID";
            this.asset.Name = "asset";
            this.asset.ReadOnly = true;
            // 
            // date
            // 
            this.date.DataPropertyName = "Job_Date";
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // status
            // 
            this.status.DataPropertyName = "Job_Status";
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // Problem
            // 
            this.Problem.DataPropertyName = "Problem_Specified";
            this.Problem.HeaderText = "Problem";
            this.Problem.Name = "Problem";
            this.Problem.ReadOnly = true;
            // 
            // serial
            // 
            this.serial.DataPropertyName = "Serial_Number";
            this.serial.HeaderText = "Serial Number";
            this.serial.Name = "serial";
            this.serial.ReadOnly = true;
            // 
            // warranty
            // 
            this.warranty.DataPropertyName = "Warranty_Status";
            this.warranty.HeaderText = "Warranty";
            this.warranty.Name = "warranty";
            this.warranty.ReadOnly = true;
            // 
            // insurance
            // 
            this.insurance.DataPropertyName = "Insurance_Status";
            this.insurance.HeaderText = "Insurance";
            this.insurance.Name = "insurance";
            this.insurance.ReadOnly = true;
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(364, 395);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(87, 42);
            this.button_back.TabIndex = 100;
            this.button_back.Text = "Back";
            this.button_back.UseSelectable = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click_1);
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(470, 395);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(87, 42);
            this.button_search.TabIndex = 101;
            this.button_search.Text = "Search";
            this.button_search.UseSelectable = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(579, 395);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(87, 42);
            this.button_update.TabIndex = 102;
            this.button_update.Text = "Update";
            this.button_update.UseSelectable = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(677, 395);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(87, 42);
            this.button_refresh.TabIndex = 103;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseSelectable = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton_cannot;
        private System.Windows.Forms.RadioButton radioButton_done;
        private System.Windows.Forms.RadioButton radioButton_pending;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker_repair;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_repairid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox_warranty;
        private System.Windows.Forms.CheckBox checkBox_insurance;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richTextBox_problem;
        private System.Windows.Forms.TextBox textBox_serialnumber;
        private System.Windows.Forms.TextBox textBox_assetID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MetroFramework.Controls.MetroGrid dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn repair;
        private System.Windows.Forms.DataGridViewTextBoxColumn asset;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Problem;
        private System.Windows.Forms.DataGridViewTextBoxColumn serial;
        private System.Windows.Forms.DataGridViewTextBoxColumn warranty;
        private System.Windows.Forms.DataGridViewTextBoxColumn insurance;
        private MetroFramework.Controls.MetroButton button_refresh;
        private MetroFramework.Controls.MetroButton button_update;
        private MetroFramework.Controls.MetroButton button_search;
        private MetroFramework.Controls.MetroButton button_back;

    }
}