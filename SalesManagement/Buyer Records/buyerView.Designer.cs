namespace SalesManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(buyerView));
            this.viewTable = new System.Windows.Forms.DataGridView();
            this.storeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactJobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officeNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.districtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditLimitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itpDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewTable
            // 
            this.viewTable.AllowUserToAddRows = false;
            this.viewTable.AllowUserToDeleteRows = false;
            this.viewTable.AllowUserToOrderColumns = true;
            this.viewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.storeNameDataGridViewTextBoxColumn,
            this.contactNameDataGridViewTextBoxColumn,
            this.contactJobDataGridViewTextBoxColumn,
            this.officeNoDataGridViewTextBoxColumn,
            this.personalNoDataGridViewTextBoxColumn,
            this.faxDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.districtDataGridViewTextBoxColumn,
            this.creditLimitDataGridViewTextBoxColumn});
            this.viewTable.Location = new System.Drawing.Point(0, 0);
            this.viewTable.Name = "viewTable";
            this.viewTable.ReadOnly = true;
            this.viewTable.Size = new System.Drawing.Size(1144, 208);
            this.viewTable.TabIndex = 0;
            // 
            // storeNameDataGridViewTextBoxColumn
            // 
            this.storeNameDataGridViewTextBoxColumn.DataPropertyName = "storeName";
            this.storeNameDataGridViewTextBoxColumn.HeaderText = "Store Name";
            this.storeNameDataGridViewTextBoxColumn.Name = "storeNameDataGridViewTextBoxColumn";
            this.storeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactNameDataGridViewTextBoxColumn
            // 
            this.contactNameDataGridViewTextBoxColumn.DataPropertyName = "contactName";
            this.contactNameDataGridViewTextBoxColumn.HeaderText = "Contact Name";
            this.contactNameDataGridViewTextBoxColumn.Name = "contactNameDataGridViewTextBoxColumn";
            this.contactNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactJobDataGridViewTextBoxColumn
            // 
            this.contactJobDataGridViewTextBoxColumn.DataPropertyName = "contactJob";
            this.contactJobDataGridViewTextBoxColumn.HeaderText = "Contact Job Title";
            this.contactJobDataGridViewTextBoxColumn.Name = "contactJobDataGridViewTextBoxColumn";
            this.contactJobDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // officeNoDataGridViewTextBoxColumn
            // 
            this.officeNoDataGridViewTextBoxColumn.DataPropertyName = "officeNo";
            this.officeNoDataGridViewTextBoxColumn.HeaderText = "Office No.";
            this.officeNoDataGridViewTextBoxColumn.Name = "officeNoDataGridViewTextBoxColumn";
            this.officeNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personalNoDataGridViewTextBoxColumn
            // 
            this.personalNoDataGridViewTextBoxColumn.DataPropertyName = "personalNo";
            this.personalNoDataGridViewTextBoxColumn.HeaderText = "Contact No.";
            this.personalNoDataGridViewTextBoxColumn.Name = "personalNoDataGridViewTextBoxColumn";
            this.personalNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // faxDataGridViewTextBoxColumn
            // 
            this.faxDataGridViewTextBoxColumn.DataPropertyName = "fax";
            this.faxDataGridViewTextBoxColumn.HeaderText = "Fax";
            this.faxDataGridViewTextBoxColumn.Name = "faxDataGridViewTextBoxColumn";
            this.faxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // districtDataGridViewTextBoxColumn
            // 
            this.districtDataGridViewTextBoxColumn.DataPropertyName = "district";
            this.districtDataGridViewTextBoxColumn.HeaderText = "District";
            this.districtDataGridViewTextBoxColumn.Name = "districtDataGridViewTextBoxColumn";
            this.districtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // creditLimitDataGridViewTextBoxColumn
            // 
            this.creditLimitDataGridViewTextBoxColumn.DataPropertyName = "creditLimit";
            this.creditLimitDataGridViewTextBoxColumn.HeaderText = "Credit Limit";
            this.creditLimitDataGridViewTextBoxColumn.Name = "creditLimitDataGridViewTextBoxColumn";
            this.creditLimitDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.searchKey.Size = new System.Drawing.Size(776, 20);
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
            this.groupBox1.Location = new System.Drawing.Point(10, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(938, 116);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // radioCredit
            // 
            this.radioCredit.AutoSize = true;
            this.radioCredit.Location = new System.Drawing.Point(811, 73);
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
            this.radioDis.Location = new System.Drawing.Point(650, 73);
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
            this.radioCity.Location = new System.Drawing.Point(505, 73);
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
            this.radioAdd.Location = new System.Drawing.Point(348, 73);
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
            // back
            // 
            this.back.Location = new System.Drawing.Point(1027, 297);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(93, 33);
            this.back.TabIndex = 10;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // buyerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 351);
            this.Controls.Add(this.back);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.viewTable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "buyerView";
            this.Text = "View Customer Details";
            this.Load += new System.EventHandler(this.viewAll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itpDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView viewTable;
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
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactJobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn officeNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn districtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditLimitDataGridViewTextBoxColumn;
    }
}