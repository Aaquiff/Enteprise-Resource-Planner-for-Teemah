using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using MySql.Data.MySqlClient;

namespace ProductProcessManagement
{
    class WorkOrderCtrl
    {
        public static string ppmMail = "ppm.teemah@gmail.com";
        public static string tmMail = "tm.teemah@gmail.com";
        public static string rmmMail = "rmm.teemah@gmail.com";
        public static string imMail = "im.teemah@gmail.com";

        public static void notify(string message,string to) {
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

                msg.To.Add(to);
                msg.From = new MailAddress("noreply.teemah@gmail.com");
                msg.Subject = "New Notification";
                msg.Body = "<!DOCTYPE html PUBLIC '-//W3C//DTD XHTML 1.0 Transitional//EN' 'http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd'> <html xmlns='http://www.w3.org/1999/xhtml'> <head> <meta name='viewport' content='width=600, initial-scale=0.5'> <meta http-equiv='Content-Type' content='text/html; charset=utf-8'> <title>New Notification - Teemah ERP </title> <style type='text/css'> div, p, a, li, td { -webkit-text-size-adjust:none; } </style> </head> <body style='margin: 0;padding: 0;BACKGROUND-COLOR: #d3d7dd;'> <table style='' width='100%' border='0' cellspacing='0' cellpadding='0'> <tbody> <tr> <td align='center'> <table width='600' border='0' cellspacing='0' cellpadding='0' style=' '> <tbody> <tr> <td height='20' style=''></td> </tr> <tr> <td> <table width='100%' border='0' cellspacing='0' cellpadding='0'> <tbody> <tr> <td height='5' style=' background-color: #0b4562; '></td> </tr> <tr> <td align='center' style=' */'> <table width='100%' border='0' cellspacing='0' cellpadding='0' style='background-color: #FFFFFF;'> <tbody> <tr> <td height='30' colspan='2'></td> </tr> <tr> <td align='center' style=' '> <table width='95%' border='0' cellspacing='0' cellpadding='0'> <tbody> <tr> <td style=' color: rgb(8, 8, 8); font-size: 14px; font-family: 'Gill Sans', 'Gill Sans MT', Arial, sans-serif; '> <span style='color: #c4000f;font-size:16px;font-family: 'Gill Sans', 'Gill Sans MT', Arial, sans-serif;'><b>New Notification</b></span> <br><br>" + message + " </td> </tr> </tbody> </table> </td> </tr> <tr> <td height='20' style='background-color:#FFF;'></td> </tr> </tbody> </table> </td> </tr> </tbody> </table> </td> </tr> </tbody> </table> </td> </tr> </tbody> </table> </body> </html>";

                client.Send(msg);
            }
            catch (Exception ex)
            {
                
            }
        }
        public static void onProductReq()
        {
            //Send Email to Product Process Manager
            notify("You have a new Product Request from Inventory Manger. Please Log in to Teemah ERP to take action!", ppmMail);
        }

        public static void onProductAccpeted()
        {
            //Send an Email to inventory manger
            notify("Your Product request has been accepted. Work Order has just started.", imMail);
            //mark the request as accepted
        }

        public static void onProductDenied()
        {
            //Send an Email to inventory Mnager
            notify("Your Product request has been denied. Contact Product Process Manger for more information.", imMail);
            //mark teh request as denied
        }



        public static void onStarted() {
            //Send an Email to Product process Manager
            notify("New Work Order has been started. Please Log in to Teemah ERP to take action!", ppmMail);
            //Send an email to raw materail manager
            notify("You have a new Raw Material Request from Product Process Manger. Please Log in to Teemah ERP to take action!", rmmMail);
        }

        public static void onRawMatReqAccepted() { 
            //Send an Email to Product Proces Manager
            notify("A Raw Material Request has been accepeted by the Raw Materials Manager. Please Log in to Teemah ERP to take action!", ppmMail);

            //Send an email to transport manager
            notify("Transport is needed to carry raw materails to factory. Please contact Product Process Manager for more info!", ppmMail);
        }


        public static void onRawMatReqDenied()
        {
            //Send an Email to Product Process Manager
            notify("A Raw Material Request has been denied by the Raw Materials Manager. Please Log in to Teemah ERP to take action!", ppmMail);
        }








    }
}
