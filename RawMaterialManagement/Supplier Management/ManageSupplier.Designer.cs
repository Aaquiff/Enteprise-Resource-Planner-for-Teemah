namespace RawMaterialManagement.Supplier_Management
{
    partial class ManageSupplier
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.customDataGrid11 = new FrameworkControls.Controls.CustomDataGrid1();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customDataGrid11)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbColumns
            // 
            this.cmbColumns.ItemHeight = 17;
            this.cmbColumns.Size = new System.Drawing.Size(175, 25);
            // 
            // txtSearchItemId
            // 
            this.txtSearchItemId.Size = new System.Drawing.Size(639, 29);
            // 
            // panelSearch
            // 
            this.panelSearch.Location = new System.Drawing.Point(0, 70);
            this.panelSearch.Size = new System.Drawing.Size(814, 33);
            // 
            // customDataGrid11
            // 
            this.customDataGrid11.AllowUserToAddRows = false;
            this.customDataGrid11.AllowUserToDeleteRows = false;
            this.customDataGrid11.AllowUserToResizeRows = false;
            this.customDataGrid11.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customDataGrid11.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            this.customDataGrid11.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.customDataGrid11.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customDataGrid11.DefaultCellStyle = dataGridViewCellStyle2;
            this.customDataGrid11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customDataGrid11.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.customDataGrid11.EnableHeadersVisualStyles = false;
            this.customDataGrid11.GridColor = System.Drawing.SystemColors.Control;
            this.customDataGrid11.Location = new System.Drawing.Point(0, 103);
            this.customDataGrid11.MultiSelect = false;
            this.customDataGrid11.Name = "customDataGrid11";
            this.customDataGrid11.RowHeadersVisible = false;
            this.customDataGrid11.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customDataGrid11.Size = new System.Drawing.Size(814, 291);
            this.customDataGrid11.TabIndex = 8;
            // 
            // ManageSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(814, 394);
            this.Controls.Add(this.customDataGrid11);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ManageSupplier";
            this.Text = "Manage Supplier";
            this.Controls.SetChildIndex(this.panelSearch, 0);
            this.Controls.SetChildIndex(this.customDataGrid11, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customDataGrid11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FrameworkControls.Controls.CustomDataGrid1 customDataGrid11;


        //private MySql.Data.MySqlClient.MySqlDataAdapter dataAdapter;
    }
}
