namespace FinanceManagement
{
    partial class AssetRepair
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
            this.button_refresh = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_repairid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker_repair = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.assetrepairBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teemahDataSet1 = new FinanceManagement.teemahDataSet1();
            this.radioButton_pending = new System.Windows.Forms.RadioButton();
            this.radioButton_done = new System.Windows.Forms.RadioButton();
            this.radioButton_cannot = new System.Windows.Forms.RadioButton();
            this.asset_repairTableAdapter = new FinanceManagement.teemahDataSet1TableAdapters.asset_repairTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button_search = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.assetrepairBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teemahDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox_warranty
            // 
            this.checkBox_warranty.AutoSize = true;
            this.checkBox_warranty.Location = new System.Drawing.Point(167, 316);
            this.checkBox_warranty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox_warranty.Name = "checkBox_warranty";
            this.checkBox_warranty.Size = new System.Drawing.Size(46, 21);
            this.checkBox_warranty.TabIndex = 62;
            this.checkBox_warranty.Text = "Yes";
            this.checkBox_warranty.UseVisualStyleBackColor = true;
            // 
            // checkBox_insurance
            // 
            this.checkBox_insurance.AutoSize = true;
            this.checkBox_insurance.Location = new System.Drawing.Point(167, 269);
            this.checkBox_insurance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox_insurance.Name = "checkBox_insurance";
            this.checkBox_insurance.Size = new System.Drawing.Size(46, 21);
            this.checkBox_insurance.TabIndex = 61;
            this.checkBox_insurance.Text = "Yes";
            this.checkBox_insurance.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Window;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 316);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 17);
            this.label10.TabIndex = 60;
            this.label10.Text = "Warranty :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Window;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 17);
            this.label9.TabIndex = 59;
            this.label9.Text = "Insurance :";
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_back.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.Location = new System.Drawing.Point(23, 527);
            this.button_back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(101, 55);
            this.button_back.TabIndex = 58;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // richTextBox_problem
            // 
            this.richTextBox_problem.Location = new System.Drawing.Point(167, 373);
            this.richTextBox_problem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox_problem.Name = "richTextBox_problem";
            this.richTextBox_problem.Size = new System.Drawing.Size(283, 144);
            this.richTextBox_problem.TabIndex = 57;
            this.richTextBox_problem.Text = "Please enter the problem specified";
            this.richTextBox_problem.Click += new System.EventHandler(this.richTextBox_problem_Click);
            // 
            // textBox_serialnumber
            // 
            this.textBox_serialnumber.Location = new System.Drawing.Point(167, 175);
            this.textBox_serialnumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_serialnumber.Name = "textBox_serialnumber";
            this.textBox_serialnumber.Size = new System.Drawing.Size(283, 25);
            this.textBox_serialnumber.TabIndex = 56;
            // 
            // textBox_assetID
            // 
            this.textBox_assetID.Location = new System.Drawing.Point(167, 69);
            this.textBox_assetID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_assetID.Name = "textBox_assetID";
            this.textBox_assetID.Size = new System.Drawing.Size(283, 25);
            this.textBox_assetID.TabIndex = 55;
            this.textBox_assetID.TextChanged += new System.EventHandler(this.textBox_assetID_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Window;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 373);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 54;
            this.label8.Text = "Problem :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 53;
            this.label2.Text = "Asset ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 52;
            this.label1.Text = "Serial Number :";
            // 
            // button_refresh
            // 
            this.button_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_refresh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_refresh.Location = new System.Drawing.Point(349, 527);
            this.button_refresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(101, 55);
            this.button_refresh.TabIndex = 64;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = false;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.Location = new System.Drawing.Point(132, 527);
            this.button_add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(101, 55);
            this.button_add.TabIndex = 63;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 65;
            this.label3.Text = "Repair ID :";
            // 
            // textBox_repairid
            // 
            this.textBox_repairid.Location = new System.Drawing.Point(167, 17);
            this.textBox_repairid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_repairid.Name = "textBox_repairid";
            this.textBox_repairid.Size = new System.Drawing.Size(283, 25);
            this.textBox_repairid.TabIndex = 66;
            this.textBox_repairid.TextChanged += new System.EventHandler(this.textBox_repairid_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 67;
            this.label4.Text = "Date :";
            // 
            // dateTimePicker_repair
            // 
            this.dateTimePicker_repair.Location = new System.Drawing.Point(167, 124);
            this.dateTimePicker_repair.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker_repair.Name = "dateTimePicker_repair";
            this.dateTimePicker_repair.Size = new System.Drawing.Size(283, 25);
            this.dateTimePicker_repair.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 69;
            this.label5.Text = "Status :";
            // 
            // assetrepairBindingSource
            // 
            this.assetrepairBindingSource.DataMember = "asset_repair";
            this.assetrepairBindingSource.DataSource = this.teemahDataSet1;
            // 
            // teemahDataSet1
            // 
            this.teemahDataSet1.DataSetName = "teemahDataSet1";
            this.teemahDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radioButton_pending
            // 
            this.radioButton_pending.AutoSize = true;
            this.radioButton_pending.Location = new System.Drawing.Point(167, 225);
            this.radioButton_pending.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton_pending.Name = "radioButton_pending";
            this.radioButton_pending.Size = new System.Drawing.Size(73, 21);
            this.radioButton_pending.TabIndex = 72;
            this.radioButton_pending.TabStop = true;
            this.radioButton_pending.Text = "Pending";
            this.radioButton_pending.UseVisualStyleBackColor = true;
            // 
            // radioButton_done
            // 
            this.radioButton_done.AutoSize = true;
            this.radioButton_done.Location = new System.Drawing.Point(248, 225);
            this.radioButton_done.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton_done.Name = "radioButton_done";
            this.radioButton_done.Size = new System.Drawing.Size(57, 21);
            this.radioButton_done.TabIndex = 73;
            this.radioButton_done.TabStop = true;
            this.radioButton_done.Text = "Done";
            this.radioButton_done.UseVisualStyleBackColor = true;
            // 
            // radioButton_cannot
            // 
            this.radioButton_cannot.AutoSize = true;
            this.radioButton_cannot.Location = new System.Drawing.Point(315, 225);
            this.radioButton_cannot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton_cannot.Name = "radioButton_cannot";
            this.radioButton_cannot.Size = new System.Drawing.Size(86, 21);
            this.radioButton_cannot.TabIndex = 74;
            this.radioButton_cannot.TabStop = true;
            this.radioButton_cannot.Text = "Cannot Fix";
            this.radioButton_cannot.UseVisualStyleBackColor = true;
            // 
            // asset_repairTableAdapter
            // 
            this.asset_repairTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(733, 615);
            this.dataGridView2.TabIndex = 75;
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_search.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.Location = new System.Drawing.Point(240, 527);
            this.button_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(101, 55);
            this.button_search.TabIndex = 76;
            this.button_search.Text = "Search, Update";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button_search);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.radioButton_cannot);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.radioButton_done);
            this.panel1.Controls.Add(this.textBox_assetID);
            this.panel1.Controls.Add(this.radioButton_pending);
            this.panel1.Controls.Add(this.textBox_serialnumber);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.richTextBox_problem);
            this.panel1.Controls.Add(this.dateTimePicker_repair);
            this.panel1.Controls.Add(this.button_back);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textBox_repairid);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.checkBox_insurance);
            this.panel1.Controls.Add(this.button_refresh);
            this.panel1.Controls.Add(this.checkBox_warranty);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 615);
            this.panel1.TabIndex = 77;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(467, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(733, 615);
            this.panel2.TabIndex = 78;
            // 
            // AssetRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1200, 615);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AssetRepair";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Asset Repairs";
            this.Load += new System.EventHandler(this.AssetRepair_Load);
            ((System.ComponentModel.ISupportInitialize)(this.assetrepairBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teemahDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_repairid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker_repair;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton_pending;
        private System.Windows.Forms.RadioButton radioButton_done;
        private System.Windows.Forms.RadioButton radioButton_cannot;
        private teemahDataSet1 teemahDataSet1;
        private System.Windows.Forms.BindingSource assetrepairBindingSource;
        private teemahDataSet1TableAdapters.asset_repairTableAdapter asset_repairTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}