namespace RawMaterialManagement
{
    partial class RawMaterialDashBoard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.rawitemtabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rawDataSet = new RawMaterialManagement.RawDataSet();
            this.rawDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.raw_item_tabTableAdapter = new RawMaterialManagement.RawDataSetTableAdapters.raw_item_tabTableAdapter();
            this.rawpurchaseorderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.raw_purchase_orderTableAdapter = new RawMaterialManagement.RawDataSetTableAdapters.raw_purchase_orderTableAdapter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRMRequestCount = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOrdersToBeApprovedCount = new System.Windows.Forms.Button();
            this.metroTileSuppliers = new MetroFramework.Controls.MetroTile();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.rawitemtabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawpurchaseorderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rawitemtabBindingSource
            // 
            this.rawitemtabBindingSource.DataMember = "raw_item_tab";
            this.rawitemtabBindingSource.DataSource = this.rawDataSet;
            // 
            // rawDataSet
            // 
            this.rawDataSet.DataSetName = "RawDataSet";
            this.rawDataSet.EnforceConstraints = false;
            this.rawDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rawDataSetBindingSource
            // 
            this.rawDataSetBindingSource.DataSource = this.rawDataSet;
            this.rawDataSetBindingSource.Position = 0;
            // 
            // raw_item_tabTableAdapter
            // 
            this.raw_item_tabTableAdapter.ClearBeforeFill = true;
            // 
            // rawpurchaseorderBindingSource
            // 
            this.rawpurchaseorderBindingSource.DataMember = "raw_purchase_order";
            this.rawpurchaseorderBindingSource.DataSource = this.rawDataSet;
            // 
            // raw_purchase_orderTableAdapter
            // 
            this.raw_purchase_orderTableAdapter.ClearBeforeFill = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chart2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.btnRMRequestCount);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.btnOrdersToBeApprovedCount);
            this.splitContainer1.Panel2.Controls.Add(this.metroTileSuppliers);
            this.splitContainer1.Size = new System.Drawing.Size(1245, 519);
            this.splitContainer1.SplitterDistance = 588;
            this.splitContainer1.TabIndex = 2;
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            this.chart2.DataSource = this.rawitemtabBindingSource;
            this.chart2.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(0, 0);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueMember = "name";
            series1.YValueMembers = "stock_level";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(588, 519);
            this.chart2.TabIndex = 2;
            this.chart2.Text = "chart2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(204, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Requests Pending Approval";
            this.label2.UseMnemonic = false;
            // 
            // btnRMRequestCount
            // 
            this.btnRMRequestCount.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRMRequestCount.FlatAppearance.BorderSize = 0;
            this.btnRMRequestCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRMRequestCount.Font = new System.Drawing.Font("Segoe UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRMRequestCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRMRequestCount.Location = new System.Drawing.Point(208, 227);
            this.btnRMRequestCount.Name = "btnRMRequestCount";
            this.btnRMRequestCount.Size = new System.Drawing.Size(207, 75);
            this.btnRMRequestCount.TabIndex = 4;
            this.btnRMRequestCount.Text = "00";
            this.btnRMRequestCount.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRMRequestCount.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Orders Pending Approval";
            // 
            // btnOrdersToBeApprovedCount
            // 
            this.btnOrdersToBeApprovedCount.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnOrdersToBeApprovedCount.FlatAppearance.BorderSize = 0;
            this.btnOrdersToBeApprovedCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdersToBeApprovedCount.Font = new System.Drawing.Font("Segoe UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdersToBeApprovedCount.Location = new System.Drawing.Point(12, 227);
            this.btnOrdersToBeApprovedCount.Name = "btnOrdersToBeApprovedCount";
            this.btnOrdersToBeApprovedCount.Size = new System.Drawing.Size(190, 75);
            this.btnOrdersToBeApprovedCount.TabIndex = 2;
            this.btnOrdersToBeApprovedCount.Text = "00";
            this.btnOrdersToBeApprovedCount.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOrdersToBeApprovedCount.UseVisualStyleBackColor = false;
            // 
            // metroTileSuppliers
            // 
            this.metroTileSuppliers.ActiveControl = null;
            this.metroTileSuppliers.BackColor = System.Drawing.Color.Transparent;
            this.metroTileSuppliers.Location = new System.Drawing.Point(12, 12);
            this.metroTileSuppliers.Name = "metroTileSuppliers";
            this.metroTileSuppliers.Size = new System.Drawing.Size(290, 181);
            this.metroTileSuppliers.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTileSuppliers.TabIndex = 0;
            this.metroTileSuppliers.Text = "Suppliers :  00";
            this.metroTileSuppliers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTileSuppliers.TileImage = global::RawMaterialManagement.Properties.Resources.incentive_negotiations_icon;
            this.metroTileSuppliers.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTileSuppliers.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileSuppliers.UseCustomBackColor = true;
            this.metroTileSuppliers.UseCustomForeColor = true;
            this.metroTileSuppliers.UseSelectable = true;
            this.metroTileSuppliers.UseTileImage = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1245, 519);
            this.panel1.TabIndex = 6;
            // 
            // RawMaterialDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 519);
            this.Controls.Add(this.panel1);
            this.Name = "RawMaterialDashBoard";
            this.Text = "Raw Material Dash Board";
            this.Load += new System.EventHandler(this.RawMaterialDashBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rawitemtabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawpurchaseorderBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource rawDataSetBindingSource;
        private RawDataSet rawDataSet;
        private System.Windows.Forms.BindingSource rawitemtabBindingSource;
        private RawDataSetTableAdapters.raw_item_tabTableAdapter raw_item_tabTableAdapter;
        private System.Windows.Forms.BindingSource rawpurchaseorderBindingSource;
        private RawDataSetTableAdapters.raw_purchase_orderTableAdapter raw_purchase_orderTableAdapter;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroTile metroTileSuppliers;
        private System.Windows.Forms.Button btnOrdersToBeApprovedCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRMRequestCount;
        private System.Windows.Forms.Panel panel1;

    }
}