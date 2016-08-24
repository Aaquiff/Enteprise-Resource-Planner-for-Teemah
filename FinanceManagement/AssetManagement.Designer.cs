namespace FinanceManagement
{
    partial class AssetManagement
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox_status = new System.Windows.Forms.CheckBox();
            this.checkBox_warranty = new System.Windows.Forms.CheckBox();
            this.checkBox_insurance = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button_refresh = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.richTextBox_description = new System.Windows.Forms.RichTextBox();
            this.textBox_usage = new System.Windows.Forms.TextBox();
            this.textBox_lifetime = new System.Windows.Forms.TextBox();
            this.textBox_value = new System.Windows.Forms.TextBox();
            this.textBox_ownership = new System.Windows.Forms.TextBox();
            this.textBox_serialnumber = new System.Windows.Forms.TextBox();
            this.textBox_assetID = new System.Windows.Forms.TextBox();
            this.comboBox_property = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.assetBindingSource = new System.Windows.Forms.BindingSource();
            this.teemahDataSetBindingSource = new System.Windows.Forms.BindingSource();
            this.teemahDataSet = new FinanceManagement.teemahDataSet();
            this.assetTableAdapter = new FinanceManagement.teemahDataSetTableAdapters.assetTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teemahDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teemahDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.checkBox_status);
            this.panel1.Controls.Add(this.checkBox_warranty);
            this.panel1.Controls.Add(this.checkBox_insurance);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.button_refresh);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Controls.Add(this.button_back);
            this.panel1.Controls.Add(this.richTextBox_description);
            this.panel1.Controls.Add(this.textBox_usage);
            this.panel1.Controls.Add(this.textBox_lifetime);
            this.panel1.Controls.Add(this.textBox_value);
            this.panel1.Controls.Add(this.textBox_ownership);
            this.panel1.Controls.Add(this.textBox_serialnumber);
            this.panel1.Controls.Add(this.textBox_assetID);
            this.panel1.Controls.Add(this.comboBox_property);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1316, 574);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1012, 501);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 52);
            this.button2.TabIndex = 56;
            this.button2.Text = "Search, Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.Location = new System.Drawing.Point(491, 18);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(805, 463);
            this.dataGridView2.TabIndex = 55;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(836, 501);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 52);
            this.button1.TabIndex = 54;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox_status
            // 
            this.checkBox_status.AutoSize = true;
            this.checkBox_status.Location = new System.Drawing.Point(192, 294);
            this.checkBox_status.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_status.Name = "checkBox_status";
            this.checkBox_status.Size = new System.Drawing.Size(64, 20);
            this.checkBox_status.TabIndex = 52;
            this.checkBox_status.Text = "Active";
            this.checkBox_status.UseVisualStyleBackColor = true;
            // 
            // checkBox_warranty
            // 
            this.checkBox_warranty.AutoSize = true;
            this.checkBox_warranty.Location = new System.Drawing.Point(192, 257);
            this.checkBox_warranty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_warranty.Name = "checkBox_warranty";
            this.checkBox_warranty.Size = new System.Drawing.Size(51, 20);
            this.checkBox_warranty.TabIndex = 51;
            this.checkBox_warranty.Text = "Yes";
            this.checkBox_warranty.UseVisualStyleBackColor = true;
            this.checkBox_warranty.CheckedChanged += new System.EventHandler(this.checkBox_warranty_CheckedChanged);
            // 
            // checkBox_insurance
            // 
            this.checkBox_insurance.AutoSize = true;
            this.checkBox_insurance.Location = new System.Drawing.Point(192, 222);
            this.checkBox_insurance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_insurance.Name = "checkBox_insurance";
            this.checkBox_insurance.Size = new System.Drawing.Size(51, 20);
            this.checkBox_insurance.TabIndex = 50;
            this.checkBox_insurance.Text = "Yes";
            this.checkBox_insurance.UseVisualStyleBackColor = true;
            this.checkBox_insurance.CheckedChanged += new System.EventHandler(this.checkBox_insurance_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(24, 294);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 49;
            this.label11.Text = "Status :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 258);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 48;
            this.label10.Text = "Warranty :";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 222);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "Insurance :";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_refresh.Location = new System.Drawing.Point(1180, 501);
            this.button_refresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(116, 52);
            this.button_refresh.TabIndex = 45;
            this.button_refresh.Text = "Repair";
            this.button_refresh.UseVisualStyleBackColor = false;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.Location = new System.Drawing.Point(665, 501);
            this.button_add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(116, 52);
            this.button_add.TabIndex = 44;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.Location = new System.Drawing.Point(491, 501);
            this.button_back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(116, 52);
            this.button_back.TabIndex = 43;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // richTextBox_description
            // 
            this.richTextBox_description.Location = new System.Drawing.Point(192, 416);
            this.richTextBox_description.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox_description.Name = "richTextBox_description";
            this.richTextBox_description.Size = new System.Drawing.Size(272, 136);
            this.richTextBox_description.TabIndex = 41;
            this.richTextBox_description.Text = "Type all other wanted details here";
            this.richTextBox_description.Click += new System.EventHandler(this.richTextBox_description_Click);
            this.richTextBox_description.TextChanged += new System.EventHandler(this.richTextBox_description_TextChanged);
            // 
            // textBox_usage
            // 
            this.textBox_usage.Location = new System.Drawing.Point(192, 372);
            this.textBox_usage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_usage.Name = "textBox_usage";
            this.textBox_usage.Size = new System.Drawing.Size(272, 22);
            this.textBox_usage.TabIndex = 40;
            this.textBox_usage.TextChanged += new System.EventHandler(this.textBox_usage_TextChanged);
            // 
            // textBox_lifetime
            // 
            this.textBox_lifetime.Location = new System.Drawing.Point(192, 330);
            this.textBox_lifetime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_lifetime.Name = "textBox_lifetime";
            this.textBox_lifetime.Size = new System.Drawing.Size(272, 22);
            this.textBox_lifetime.TabIndex = 39;
            this.textBox_lifetime.TextChanged += new System.EventHandler(this.textBox_lifetime_TextChanged);
            // 
            // textBox_value
            // 
            this.textBox_value.Location = new System.Drawing.Point(192, 178);
            this.textBox_value.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_value.Name = "textBox_value";
            this.textBox_value.Size = new System.Drawing.Size(272, 22);
            this.textBox_value.TabIndex = 38;
            this.textBox_value.TextChanged += new System.EventHandler(this.textBox_value_TextChanged);
            // 
            // textBox_ownership
            // 
            this.textBox_ownership.Location = new System.Drawing.Point(192, 138);
            this.textBox_ownership.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_ownership.Name = "textBox_ownership";
            this.textBox_ownership.Size = new System.Drawing.Size(272, 22);
            this.textBox_ownership.TabIndex = 37;
            this.textBox_ownership.TabIndexChanged += new System.EventHandler(this.textBox_ownership_TabIndexChanged);
            this.textBox_ownership.TextChanged += new System.EventHandler(this.textBox_ownership_TextChanged);
            // 
            // textBox_serialnumber
            // 
            this.textBox_serialnumber.Location = new System.Drawing.Point(192, 97);
            this.textBox_serialnumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_serialnumber.Name = "textBox_serialnumber";
            this.textBox_serialnumber.Size = new System.Drawing.Size(272, 22);
            this.textBox_serialnumber.TabIndex = 36;
            this.textBox_serialnumber.TextChanged += new System.EventHandler(this.textBox_serialnumber_TextChanged);
            // 
            // textBox_assetID
            // 
            this.textBox_assetID.Location = new System.Drawing.Point(192, 18);
            this.textBox_assetID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_assetID.Name = "textBox_assetID";
            this.textBox_assetID.Size = new System.Drawing.Size(272, 22);
            this.textBox_assetID.TabIndex = 35;
            this.textBox_assetID.TextChanged += new System.EventHandler(this.textBox_assetID_TextChanged);
            // 
            // comboBox_property
            // 
            this.comboBox_property.AllowDrop = true;
            this.comboBox_property.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_property.FormattingEnabled = true;
            this.comboBox_property.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox_property.Items.AddRange(new object[] {
            "Building",
            "Equipments",
            "Furniture",
            "Land",
            "Machinery"});
            this.comboBox_property.Location = new System.Drawing.Point(192, 57);
            this.comboBox_property.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_property.Name = "comboBox_property";
            this.comboBox_property.Size = new System.Drawing.Size(272, 24);
            this.comboBox_property.Sorted = true;
            this.comboBox_property.TabIndex = 34;
            this.comboBox_property.SelectedIndexChanged += new System.EventHandler(this.comboBox_type_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 414);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Description :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 375);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Usage : (Years)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 334);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Life-Time : (Years)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 182);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Value :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Ownership :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Property :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Asset ID :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Serial Number :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // assetBindingSource
            // 
            this.assetBindingSource.DataMember = "asset";
            this.assetBindingSource.DataSource = this.teemahDataSetBindingSource;
            // 
            // teemahDataSetBindingSource
            // 
            this.teemahDataSetBindingSource.DataSource = this.teemahDataSet;
            this.teemahDataSetBindingSource.Position = 0;
            // 
            // teemahDataSet
            // 
            this.teemahDataSet.DataSetName = "teemahDataSet";
            this.teemahDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assetTableAdapter
            // 
            this.assetTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AssetManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1316, 574);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AssetManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asset Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teemahDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teemahDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn assetIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn propertyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownershipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assetValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lifeTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearUsageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.RichTextBox richTextBox_description;
        private System.Windows.Forms.TextBox textBox_usage;
        private System.Windows.Forms.TextBox textBox_lifetime;
        private System.Windows.Forms.TextBox textBox_value;
        private System.Windows.Forms.TextBox textBox_ownership;
        private System.Windows.Forms.TextBox textBox_serialnumber;
        private System.Windows.Forms.TextBox textBox_assetID;
        private System.Windows.Forms.ComboBox comboBox_property;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox_status;
        private System.Windows.Forms.CheckBox checkBox_warranty;
        private System.Windows.Forms.CheckBox checkBox_insurance;
        private System.Windows.Forms.BindingSource teemahDataSetBindingSource;
        private teemahDataSet teemahDataSet;
        private System.Windows.Forms.BindingSource assetBindingSource;
        private teemahDataSetTableAdapters.assetTableAdapter assetTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button2;
        //private teemahDataSet2 teemahDataSet2;
        //private teemahDataSet2TableAdapters.assetTableAdapter assetTableAdapter1;
        //private teemahDataSet3 teemahDataSet3;
        //private teemahDataSet3TableAdapters.assetTableAdapter assetTableAdapter2;
    }
}