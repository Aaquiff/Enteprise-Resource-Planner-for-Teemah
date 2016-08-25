namespace Explorer
{
    partial class ExceptionForm
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
            this.lblException = new System.Windows.Forms.Label();
            this.lblStackTrace = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblException
            // 
            this.lblException.AutoSize = true;
            this.lblException.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblException.Location = new System.Drawing.Point(14, 12);
            this.lblException.Name = "lblException";
            this.lblException.Size = new System.Drawing.Size(132, 37);
            this.lblException.TabIndex = 0;
            this.lblException.Text = "Exception";
            // 
            // lblStackTrace
            // 
            this.lblStackTrace.AutoSize = true;
            this.lblStackTrace.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStackTrace.Location = new System.Drawing.Point(14, 63);
            this.lblStackTrace.Name = "lblStackTrace";
            this.lblStackTrace.Size = new System.Drawing.Size(74, 17);
            this.lblStackTrace.TabIndex = 1;
            this.lblStackTrace.Text = "Stack Trace";
            // 
            // ExceptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(822, 370);
            this.Controls.Add(this.lblStackTrace);
            this.Controls.Add(this.lblException);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ExceptionForm";
            this.Text = "ExceptionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblException;
        private System.Windows.Forms.Label lblStackTrace;
    }
}