using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    internal static class GenerateOTP
    {
        public static String randomCode;
        public static String to;
        public static void sendOTP(string email)
        {
            String from, pass, messageBody;
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = email;
            from = "ashfaqhoq27@gmail.com";
            pass = "kpfj nopf hseh utoo";
            messageBody = "Your reset code is " + randomCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Password Reseting Code";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            try
            {
                smtp.Send(message);
                MessageBox.Show("An otp is sent to your email. Plase verify this to continue");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static bool VerifyOTP(string email, string verify)
        {
            if (randomCode == verify)
            {
                to = email;
                return true;
            }
            else
            {
                MessageBox.Show("Wrong Code. Try again");
                return false;
            }
        }
    }
}
