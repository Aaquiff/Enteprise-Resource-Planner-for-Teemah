namespace FinanceManagement
{
    partial class FinanceManagementDashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinanceManagementDashBoard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_budget = new System.Windows.Forms.Button();
            this.button_expense = new System.Windows.Forms.Button();
            this.button_asset = new System.Windows.Forms.Button();
            this.button_home = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button_budget);
            this.panel1.Controls.Add(this.button_expense);
            this.panel1.Controls.Add(this.button_asset);
            this.panel1.Controls.Add(this.button_home);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(109, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 344);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button_budget
            // 
            this.button_budget.BackColor = System.Drawing.Color.Purple;
            this.button_budget.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_budget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_budget.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_budget.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_budget.Image = ((System.Drawing.Image)(resources.GetObject("button_budget.Image")));
            this.button_budget.Location = new System.Drawing.Point(57, 47);
            this.button_budget.Name = "button_budget";
            this.button_budget.Size = new System.Drawing.Size(221, 123);
            this.button_budget.TabIndex = 8;
            this.button_budget.Text = "Budget Management";
            this.button_budget.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_budget.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_budget.UseVisualStyleBackColor = false;
            this.button_budget.Click += new System.EventHandler(this.button_budget_Click_1);
            // 
            // button_expense
            // 
            this.button_expense.BackColor = System.Drawing.Color.Purple;
            this.button_expense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_expense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_expense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_expense.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_expense.Image = ((System.Drawing.Image)(resources.GetObject("button_expense.Image")));
            this.button_expense.Location = new System.Drawing.Point(284, 47);
            this.button_expense.Name = "button_expense";
            this.button_expense.Size = new System.Drawing.Size(221, 123);
            this.button_expense.TabIndex = 5;
            this.button_expense.Text = "Expense Management";
            this.button_expense.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_expense.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_expense.UseVisualStyleBackColor = false;
            this.button_expense.Click += new System.EventHandler(this.button_expense_Click);
            // 
            // button_asset
            // 
            this.button_asset.BackColor = System.Drawing.Color.Purple;
            this.button_asset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_asset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_asset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_asset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_asset.Image = ((System.Drawing.Image)(resources.GetObject("button_asset.Image")));
            this.button_asset.Location = new System.Drawing.Point(57, 176);
            this.button_asset.Name = "button_asset";
            this.button_asset.Size = new System.Drawing.Size(221, 123);
            this.button_asset.TabIndex = 6;
            this.button_asset.Text = "Asset Management";
            this.button_asset.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_asset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_asset.UseVisualStyleBackColor = false;
            this.button_asset.Click += new System.EventHandler(this.button_asset_Click);
            // 
            // button_home
            // 
            this.button_home.BackColor = System.Drawing.Color.Purple;
            this.button_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_home.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_home.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_home.Image = ((System.Drawing.Image)(resources.GetObject("button_home.Image")));
            this.button_home.Location = new System.Drawing.Point(284, 176);
            this.button_home.Name = "button_home";
            this.button_home.Size = new System.Drawing.Size(221, 123);
            this.button_home.TabIndex = 7;
            this.button_home.Text = "Home";
            this.button_home.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_home.UseVisualStyleBackColor = false;
            this.button_home.Click += new System.EventHandler(this.button_home_Click);
            // 
            // FinanceManagementDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "FinanceManagementDashBoard";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finance Management Dash Board";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_expense;
        private System.Windows.Forms.Button button_asset;
        private System.Windows.Forms.Button button_home;
        private System.Windows.Forms.Button button_budget;




    }
}

