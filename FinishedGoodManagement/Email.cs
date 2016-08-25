using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace FinishedGoodManagement
{
    public partial class Email : Form
    {

        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;
        public Email()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login = new NetworkCredential(txtUsername.Text, txtPassword.Text);
            client = new SmtpClient(txtSmtp.Text);
            client.Port = Convert.ToInt32(txtPort.Text);
            client.EnableSsl = chckSSL.Checked;
            client.Credentials = login;
            msg =new MailMessage {From =new MailAddress(txtUsername.Text + txtSmtp.Text.Replace("smtp.","@"),"Lucy",Encoding.UTF8)};
            msg.To.Add(new MailAddress(txtTo.Text));
            if (!string.IsNullOrEmpty(txtCC.Text))
                msg.To.Add(new MailAddress(txtCC.Text));
            msg.Subject = txtSub.Text;
            msg.Body = txtMsg.Text;
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.Priority = MailPriority.Normal;
            msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
            string userstate = "Sending.....";
            client.SendAsync(msg, userstate);   

        }

        private void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
                MessageBox.Show(string.Format("{0} send cancelled.", e.UserState), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (e.Error != null)
                MessageBox.Show(string.Format("{0} {1}", e.UserState, e.Error), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Your Message has been Successfully sent.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            throw new NotImplementedException();    

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Email_Load(object sender, EventArgs e)
        {

        }
    }
}
