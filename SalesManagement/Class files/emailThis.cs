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

namespace SalesManagement.Class_files
{
    class emailThis
    {
        public void sendMail(string mail, string body)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com");

                client.Port = 587;
                client.EnableSsl = true;
                client.Timeout = 100000;
                client.DeliveryFormat = SmtpDeliveryFormat.International;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;

                client.Credentials = new NetworkCredential("noreply.teemah@gmail.com", "teemah1234");

                MailMessage msg = new MailMessage();
                
                msg.To.Add(mail);
                msg.From = new MailAddress("noreply.teemah@gmail.com");
                msg.Subject = "Order Details - " + DateTime.Now.ToShortDateString();
                msg.Body = "Test confirmation mail : \n\n" + body + "\n\n\n Thank You from Team-ah!";

                //Attachment att = new Attachment(textBox3.Text);
                //msg.Attachments.Add(att);

                client.Send(msg);
                MessageBox.Show("Confirmation mail has been sent to the customer");

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
