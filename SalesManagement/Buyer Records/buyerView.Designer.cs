namespace SalesManagement.Buyer_Records
{
    partial class buyerView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(buyerView));
            this.buyerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itpDataSet = new SalesManagement.itpDataSet();
            this.buyerTableAdapter = new SalesManagement.itpDataSetTableAdapters.buyerTableAdapter();
            this.searchKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioCredit = new System.Windows.Forms.RadioButton();
            this.radioDis = new System.Windows.Forms.RadioButton();
            this.radioCity = new System.Windows.Forms.RadioButton();
            this.radioAdd = new System.Windows.Forms.RadioButton();
            this.radioContact = new System.Windows.Forms.RadioButton();
            this.radioStore = new System.Windows.Forms.RadioButton();
            this.viewTable = new MetroFramework.Controls.MetroGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.buyerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itpDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewTable)).BeginInit();
            this.SuspendLayout();
            // 
            // buyerBindingSource
            // 
            this.buyerBindingSource.DataMember = "buyer";
            this.buyerBindingSource.DataSource = this.itpDataSet;
            // 
            // itpDataSet
            // 
            this.itpDataSet.DataSetName = "itpDataSet";
            this.itpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buyerTableAdapter
            // 
            this.buyerTableAdapter.ClearBeforeFill = true;
            // 
            // searchKey
            // 
            this.searchKey.Location = new System.Drawing.Point(111, 28);
            this.searchKey.Name = "searchKey";
            this.searchKey.Size = new System.Drawing.Size(965, 20);
            this.searchKey.TabIndex = 1;
            this.searchKey.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search query :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioCredit);
            this.groupBox1.Controls.Add(this.radioDis);
            this.groupBox1.Controls.Add(this.radioCity);
            this.groupBox1.Controls.Add(this.radioAdd);
            this.groupBox1.Controls.Add(this.radioContact);
            this.groupBox1.Controls.Add(this.radioStore);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.searchKey);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1120, 116);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // radioCredit
            // 
            this.radioCredit.AutoSize = true;
            this.radioCredit.Location = new System.Drawing.Point(1000, 73);
            this.radioCredit.Name = "radioCredit";
            this.radioCredit.Size = new System.Drawing.Size(76, 17);
            this.radioCredit.TabIndex = 14;
            this.radioCredit.TabStop = true;
            this.radioCredit.Text = "Credit Limit";
            this.radioCredit.UseVisualStyleBackColor = true;
            // 
            // radioDis
            // 
            this.radioDis.AutoSize = true;
            this.radioDis.Location = new System.Drawing.Point(770, 73);
            this.radioDis.Name = "radioDis";
            this.radioDis.Size = new System.Drawing.Size(57, 17);
            this.radioDis.TabIndex = 13;
            this.radioDis.TabStop = true;
            this.radioDis.Text = "District";
            this.radioDis.UseVisualStyleBackColor = true;
            // 
            // radioCity
            // 
            this.radioCity.AutoSize = true;
            this.radioCity.Location = new System.Drawing.Point(576, 73);
            this.radioCity.Name = "radioCity";
            this.radioCity.Size = new System.Drawing.Size(42, 17);
            this.radioCity.TabIndex = 12;
            this.radioCity.TabStop = true;
            this.radioCity.Text = "City";
            this.radioCity.UseVisualStyleBackColor = true;
            // 
            // radioAdd
            // 
            this.radioAdd.AutoSize = true;
            this.radioAdd.Location = new System.Drawing.Point(392, 73);
            this.radioAdd.Name = "radioAdd";
            this.radioAdd.Size = new System.Drawing.Size(63, 17);
            this.radioAdd.TabIndex = 11;
            this.radioAdd.TabStop = true;
            this.radioAdd.Text = "Address";
            this.radioAdd.UseVisualStyleBackColor = true;
            // 
            // radioContact
            // 
            this.radioContact.AutoSize = true;
            this.radioContact.Location = new System.Drawing.Point(175, 73);
            this.radioContact.Name = "radioContact";
            this.radioContact.Size = new System.Drawing.Size(93, 17);
            this.radioContact.TabIndex = 10;
            this.radioContact.TabStop = true;
            this.radioContact.Text = "Contact Name";
            this.radioContact.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioContact.UseVisualStyleBackColor = true;
            // 
            // radioStore
            // 
            this.radioStore.AutoSize = true;
            this.radioStore.Location = new System.Drawing.Point(16, 73);
            this.radioStore.Name = "radioStore";
            this.radioStore.Size = new System.Drawing.Size(81, 17);
            this.radioStore.TabIndex = 9;
            this.radioStore.TabStop = true;
            this.radioStore.Text = "Store Name";
            this.radioStore.UseVisualStyleBackColor = true;
            this.radioStore.CheckedChanged += new System.EventHandler(this.radioStore_CheckedChanged);
            // 
            // viewTable
            // 
            this.viewTable.AllowUserToAddRows = false;
            this.viewTable.AllowUserToDeleteRows = false;
            this.viewTable.AllowUserToOrderColumns = true;
            this.viewTable.AllowUserToResizeRows = false;
            this.viewTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.viewTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.viewTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.viewTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.viewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.viewTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.viewTable.EnableHeadersVisualStyles = false;
            this.viewTable.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.viewTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.viewTable.Location = new System.Drawing.Point(12, 146);
            this.viewTable.Name = "viewTable";
            this.viewTable.ReadOnly = true;
            this.viewTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.viewTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.viewTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewTable.Size = new System.Drawing.Size(1120, 229);
            this.viewTable.Style = MetroFramework.MetroColorStyle.Silver;
            this.viewTable.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 393);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1144, 37);
            this.panel1.TabIndex = 16;
            // 
            // buyerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 430);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.viewTable);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "buyerView";
            this.Text = "View Customer Details";
            this.Load += new System.EventHandler(this.viewAll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buyerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itpDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private itpDataSet itpDataSet;
        private System.Windows.Forms.BindingSource buyerBindingSource;
        private itpDataSetTableAdapters.buyerTableAdapter buyerTableAdapter;
        private System.Windows.Forms.TextBox searchKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioCredit;
        private System.Windows.Forms.RadioButton radioDis;
        private System.Windows.Forms.RadioButton radioCity;
        private System.Windows.Forms.RadioButton radioAdd;
        private System.Windows.Forms.RadioButton radioContact;
        private System.Windows.Forms.RadioButton radioStore;
        private MetroFramework.Controls.MetroGrid viewTable;
        private System.Windows.Forms.Panel panel1;
    }
}