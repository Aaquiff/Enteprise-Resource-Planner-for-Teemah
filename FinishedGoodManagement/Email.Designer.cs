namespace FinishedGoodManagement
{
    partial class Email
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.btnSent = new System.Windows.Forms.Button();
            this.txtSub = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.Settings = new System.Windows.Forms.GroupBox();
            this.chckSSL = new System.Windows.Forms.CheckBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSmtp = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subject:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(105, 42);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(483, 20);
            this.txtTo.TabIndex = 3;
            // 
            // txtCC
            // 
            this.txtCC.Location = new System.Drawing.Point(105, 70);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(483, 20);
            this.txtCC.TabIndex = 4;
            // 
            // btnSent
            // 
            this.btnSent.Location = new System.Drawing.Point(275, 43);
            this.btnSent.Name = "btnSent";
            this.btnSent.Size = new System.Drawing.Size(75, 23);
            this.btnSent.TabIndex = 6;
            this.btnSent.Text = "Send";
            this.btnSent.UseVisualStyleBackColor = true;
            this.btnSent.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSub
            // 
            this.txtSub.Location = new System.Drawing.Point(105, 96);
            this.txtSub.Name = "txtSub";
            this.txtSub.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSub.Size = new System.Drawing.Size(483, 20);
            this.txtSub.TabIndex = 7;
            this.txtSub.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Message";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(105, 122);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMsg.Size = new System.Drawing.Size(483, 149);
            this.txtMsg.TabIndex = 7;
            this.txtMsg.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.chckSSL);
            this.Settings.Controls.Add(this.txtUsername);
            this.Settings.Controls.Add(this.label5);
            this.Settings.Controls.Add(this.btnSent);
            this.Settings.Controls.Add(this.label8);
            this.Settings.Controls.Add(this.label7);
            this.Settings.Controls.Add(this.txtSmtp);
            this.Settings.Controls.Add(this.txtPort);
            this.Settings.Controls.Add(this.label6);
            this.Settings.Controls.Add(this.txtPassword);
            this.Settings.Location = new System.Drawing.Point(105, 286);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(483, 100);
            this.Settings.TabIndex = 8;
            this.Settings.TabStop = false;
            this.Settings.Text = "Settings";
            // 
            // chckSSL
            // 
            this.chckSSL.AutoSize = true;
            this.chckSSL.Location = new System.Drawing.Point(275, 21);
            this.chckSSL.Name = "chckSSL";
            this.chckSSL.Size = new System.Drawing.Size(46, 17);
            this.chckSSL.TabIndex = 5;
            this.chckSSL.Text = "SSL";
            this.chckSSL.UseVisualStyleBackColor = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(86, 19);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(159, 20);
            this.txtUsername.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "User Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(144, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Smtp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Port";
            // 
            // txtSmtp
            // 
            this.txtSmtp.Location = new System.Drawing.Point(181, 69);
            this.txtSmtp.Name = "txtSmtp";
            this.txtSmtp.Size = new System.Drawing.Size(174, 20);
            this.txtSmtp.TabIndex = 4;
            this.txtSmtp.Text = "smtp.gmail.com";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(86, 69);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(52, 20);
            this.txtPort.TabIndex = 4;
            this.txtPort.Text = "587";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(86, 45);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(159, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 400);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.txtSub);
            this.Controls.Add(this.txtCC);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Email";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email";
            this.Load += new System.EventHandler(this.Email_Load);
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.Button btnSent;
        private System.Windows.Forms.TextBox txtSub;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.GroupBox Settings;
        private System.Windows.Forms.CheckBox chckSSL;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSmtp;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPassword;
    }
}