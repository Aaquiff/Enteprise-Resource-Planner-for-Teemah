namespace RawMaterialManagement.Items_Management
{
    partial class ManageItem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.customDataGrid11 = new FrameworkControls.Controls.CustomDataGrid1();
            this.dataGridViewBase1 = new FrameworkControls.Controls.DataGridViewBase();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customDataGrid11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBase1)).BeginInit();
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
            // panel2
            // 
            this.panel2.Controls.Add(this.customDataGrid11);
            this.panel2.Controls.Add(this.dataGridViewBase1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 103);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(814, 291);
            this.panel2.TabIndex = 7;
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
            this.customDataGrid11.Location = new System.Drawing.Point(0, 0);
            this.customDataGrid11.MultiSelect = false;
            this.customDataGrid11.Name = "customDataGrid11";
            this.customDataGrid11.RowHeadersVisible = false;
            this.customDataGrid11.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customDataGrid11.Size = new System.Drawing.Size(814, 291);
            this.customDataGrid11.TabIndex = 0;
            // 
            // dataGridViewBase1
            // 
            this.dataGridViewBase1.AllowUserToAddRows = false;
            this.dataGridViewBase1.AllowUserToDeleteRows = false;
            this.dataGridViewBase1.AllowUserToResizeRows = false;
            this.dataGridViewBase1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBase1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewBase1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBase1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBase1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewBase1.EnableHeadersVisualStyles = false;
            this.dataGridViewBase1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewBase1.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBase1.Name = "dataGridViewBase1";
            this.dataGridViewBase1.RowHeadersVisible = false;
            this.dataGridViewBase1.Size = new System.Drawing.Size(210, 159);
            this.dataGridViewBase1.TabIndex = 1;
            // 
            // ManageItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(814, 394);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ManageItem";
            this.Text = "Manage Item";
            this.Controls.SetChildIndex(this.panelSearch, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customDataGrid11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBase1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private FrameworkControls.Controls.DataGridViewBase dataGridViewBase1;
        private FrameworkControls.Controls.CustomDataGrid1 customDataGrid11;
    }
}
