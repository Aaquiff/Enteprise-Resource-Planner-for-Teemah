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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rawitemtabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rawDataSet = new RawMaterialManagement.RawDataSet();
            this.rawDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.raw_item_tabTableAdapter = new RawMaterialManagement.RawDataSetTableAdapters.raw_item_tabTableAdapter();
            this.rawpurchaseorderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.raw_purchase_orderTableAdapter = new RawMaterialManagement.RawDataSetTableAdapters.raw_purchase_orderTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawitemtabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawpurchaseorderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea1.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX.LineWidth = 0;
            chartArea1.AxisX.MajorGrid.LineWidth = 0;
            chartArea1.AxisX2.LineWidth = 0;
            chartArea1.AxisY.LineWidth = 0;
            chartArea1.AxisY.MajorGrid.LineWidth = 0;
            chartArea1.AxisY2.LineWidth = 0;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.rawitemtabBindingSource;
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            series1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.BorderWidth = 0;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series1.IsValueShownAsLabel = true;
            series1.MarkerSize = 1;
            series1.Name = "Series1";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.XValueMember = "name";
            series1.YValueMembers = "stock_level";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1059, 639);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
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
            // RawMaterialDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 639);
            this.Controls.Add(this.chart1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RawMaterialDashBoard";
            this.Text = "Raw Material Dash Board";
            this.Load += new System.EventHandler(this.RawMaterialDashBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawitemtabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawpurchaseorderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.BindingSource rawDataSetBindingSource;
        private RawDataSet rawDataSet;
        private System.Windows.Forms.BindingSource rawitemtabBindingSource;
        private RawDataSetTableAdapters.raw_item_tabTableAdapter raw_item_tabTableAdapter;
        private System.Windows.Forms.BindingSource rawpurchaseorderBindingSource;
        private RawDataSetTableAdapters.raw_purchase_orderTableAdapter raw_purchase_orderTableAdapter;

    }
}