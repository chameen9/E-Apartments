using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace E_Apartments
{
    public class MailSender
    {
        //setup
        static NetworkCredential mailLoginDetails;
        static SmtpClient mailClient;
        static MailMessage mail;

        public static void SendMailWithoutMessage(string reciverMail, string mailSubject, string mailBody)
        {
            mailLoginDetails = new NetworkCredential("eapartments258@gmail.com", "wmvcnbwyfqjfhhor");   //use app password option for password
            mailClient = new SmtpClient("smtp.gmail.com");
            mailClient.Port = 587;
            mailClient.EnableSsl = true;    //enable ssl for gmail
            mailClient.Credentials = mailLoginDetails;
            mail = new MailMessage { From = new MailAddress("eapartments258@gmail.com", "E-Apartments", Encoding.UTF8) };
            mail.To.Add(new MailAddress(reciverMail));
            //mail.To.Add(new MailAddress("backupaddress"));
            mail.Subject = mailSubject;
            mail.Body = mailBody;
            mail.BodyEncoding = Encoding.UTF8;
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.Normal;    //set mail priority
            mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;   //get fail emails back
            mailClient.SendCompleted += new SendCompletedEventHandler(SendCompletedCallBackWithoutSuccess);
            string usersate = "Sending...";
            mailClient.SendAsync(mail, usersate);
        }
        public static void SendMailWithMessage(string reciverMail, string mailSubject, string mailBody)
        {
            mailLoginDetails = new NetworkCredential("eapartments258@gmail.com", "wmvcnbwyfqjfhhor");
            mailClient = new SmtpClient("smtp.gmail.com");
            mailClient.Port = 587;
            mailClient.EnableSsl = true;
            mailClient.Credentials = mailLoginDetails;
            mail = new MailMessage { From = new MailAddress("eapartments258@gmail.com", "E-Apartments", Encoding.UTF8) };
            mail.To.Add(new MailAddress(reciverMail));
            //mail.To.Add(new MailAddress("backupaddress"));
            mail.Subject = mailSubject;
            mail.Body = mailBody;
            mail.BodyEncoding = Encoding.UTF8;
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.Normal;
            mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            mailClient.SendCompleted += new SendCompletedEventHandler(SendCompletedCallBackWithSuccess);
            string usersate = "Sending...";
            mailClient.SendAsync(mail, usersate);
        }
        private static void SendCompletedCallBackWithoutSuccess(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show(string.Format("{0} send canceled.", e.UserState), "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (e.Error != null)
            {
                MessageBox.Show(string.Format("{0} {1}", e.UserState, e.Error), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private static void SendCompletedCallBackWithSuccess(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show(string.Format("{0} send canceled.", e.UserState), "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (e.Error != null)
            {
                MessageBox.Show(string.Format("{0} {1}", e.UserState, e.Error), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Mail sent successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
