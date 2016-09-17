namespace FrameworkControls.Forms
{
    partial class TableWindowBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableWindowBase));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPopulate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripDataGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.columnSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new System.Data.DataSet();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearchItemId = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbColumns = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStripDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemNew,
            this.saveToolStripMenuSave,
            this.toolStripMenuItemDelete,
            this.toolStripMenuItemPopulate,
            this.toolStripMenuItemSearch});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(930, 70);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // toolStripMenuItemNew
            // 
            this.toolStripMenuItemNew.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItemNew.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripMenuItemNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemNew.Image")));
            this.toolStripMenuItemNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItemNew.Name = "toolStripMenuItemNew";
            this.toolStripMenuItemNew.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.toolStripMenuItemNew.Size = new System.Drawing.Size(60, 66);
            this.toolStripMenuItemNew.Text = "New";
            this.toolStripMenuItemNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripMenuItemNew.Click += new System.EventHandler(this.toolStripMenuItemNew_Click);
            // 
            // saveToolStripMenuSave
            // 
            this.saveToolStripMenuSave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveToolStripMenuSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saveToolStripMenuSave.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuSave.Image")));
            this.saveToolStripMenuSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.saveToolStripMenuSave.Name = "saveToolStripMenuSave";
            this.saveToolStripMenuSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuSave.Size = new System.Drawing.Size(60, 66);
            this.saveToolStripMenuSave.Text = "Save";
            this.saveToolStripMenuSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.saveToolStripMenuSave.Click += new System.EventHandler(this.saveToolStripMenuSave_Click);
            // 
            // toolStripMenuItemDelete
            // 
            this.toolStripMenuItemDelete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItemDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripMenuItemDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemDelete.Image")));
            this.toolStripMenuItemDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItemDelete.Name = "toolStripMenuItemDelete";
            this.toolStripMenuItemDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.toolStripMenuItemDelete.Size = new System.Drawing.Size(67, 66);
            this.toolStripMenuItemDelete.Text = "Delete";
            this.toolStripMenuItemDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripMenuItemDelete.Click += new System.EventHandler(this.toolStripMenuItemDelete_Click);
            // 
            // toolStripMenuItemPopulate
            // 
            this.toolStripMenuItemPopulate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItemPopulate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripMenuItemPopulate.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemPopulate.Image")));
            this.toolStripMenuItemPopulate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItemPopulate.Name = "toolStripMenuItemPopulate";
            this.toolStripMenuItemPopulate.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.toolStripMenuItemPopulate.Size = new System.Drawing.Size(84, 66);
            this.toolStripMenuItemPopulate.Text = "Populate";
            this.toolStripMenuItemPopulate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripMenuItemPopulate.Click += new System.EventHandler(this.toolStripMenuItemPopulate_Click);
            // 
            // toolStripMenuItemSearch
            // 
            this.toolStripMenuItemSearch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItemSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripMenuItemSearch.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemSearch.Image")));
            this.toolStripMenuItemSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItemSearch.Name = "toolStripMenuItemSearch";
            this.toolStripMenuItemSearch.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.toolStripMenuItemSearch.Size = new System.Drawing.Size(73, 66);
            this.toolStripMenuItemSearch.Text = "Search";
            this.toolStripMenuItemSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripMenuItemSearch.Click += new System.EventHandler(this.toolStripMenuItemSearch_Click);
            // 
            // contextMenuStripDataGrid
            // 
            this.contextMenuStripDataGrid.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripDataGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.columnSizeToolStripMenuItem});
            this.contextMenuStripDataGrid.Name = "contextMenuStripDataGrid";
            this.contextMenuStripDataGrid.Size = new System.Drawing.Size(167, 30);
            // 
            // columnSizeToolStripMenuItem
            // 
            this.columnSizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoSizeToolStripMenuItem});
            this.columnSizeToolStripMenuItem.Name = "columnSizeToolStripMenuItem";
            this.columnSizeToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.columnSizeToolStripMenuItem.Text = "Column Size";
            // 
            // autoSizeToolStripMenuItem
            // 
            this.autoSizeToolStripMenuItem.Name = "autoSizeToolStripMenuItem";
            this.autoSizeToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.autoSizeToolStripMenuItem.Text = "AutoSize";
            this.autoSizeToolStripMenuItem.Click += new System.EventHandler(this.autoSizeToolStripMenuItem_Click);
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "NewDataSet";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.panelSearch);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(890, 291);
            this.metroPanel1.TabIndex = 8;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.SystemColors.Window;
            this.panelSearch.Controls.Add(this.panel1);
            this.panelSearch.Controls.Add(this.panel2);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(890, 31);
            this.panelSearch.TabIndex = 8;
            this.panelSearch.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSearchItemId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 31);
            this.panel1.TabIndex = 3;
            // 
            // txtSearchItemId
            // 
            this.txtSearchItemId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearchItemId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchItemId.Location = new System.Drawing.Point(0, 0);
            this.txtSearchItemId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchItemId.Name = "txtSearchItemId";
            this.txtSearchItemId.Size = new System.Drawing.Size(690, 34);
            this.txtSearchItemId.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbColumns);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 31);
            this.panel2.TabIndex = 4;
            // 
            // cmbColumns
            // 
            this.cmbColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbColumns.DropDownHeight = 136;
            this.cmbColumns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColumns.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbColumns.FormattingEnabled = true;
            this.cmbColumns.IntegralHeight = false;
            this.cmbColumns.ItemHeight = 20;
            this.cmbColumns.Location = new System.Drawing.Point(0, 0);
            this.cmbColumns.Name = "cmbColumns";
            this.cmbColumns.Size = new System.Drawing.Size(200, 28);
            this.cmbColumns.TabIndex = 2;
            // 
            // TableWindowBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 371);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TableWindowBase";
            this.Text = "TableWindowBase";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStripDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.MenuStrip menuStrip1;
        protected System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNew;
        protected System.Windows.Forms.ToolStripMenuItem saveToolStripMenuSave;
        protected System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDelete;
        protected System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPopulate;
        protected System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSearch;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDataGrid;
        private System.Windows.Forms.ToolStripMenuItem columnSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoSizeToolStripMenuItem;
        protected System.Windows.Forms.BindingSource bindingSource;
        protected System.Data.DataSet dataSet;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        protected System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.TextBox txtSearchItemId;
        private System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.ComboBox cmbColumns;
    }
}