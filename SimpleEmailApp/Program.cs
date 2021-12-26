using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace SimpleEmailApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ze které adresy chcete email odeslat?");
                string mailFrom = Console.ReadLine();
                Console.WriteLine("Zadejte emailovou adresu příjemce");
                string mailTo = Console.ReadLine();
                Console.WriteLine("Zadejte heslo emailu");
                string mailPass = Console.ReadLine();
                Console.WriteLine("Zadejte předmět emailu");
                string mailSub = Console.ReadLine();
                Console.WriteLine("Zadejte text");
                string mailMess = Console.ReadLine();

                MailMessage mail = new MailMessage();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(mailFrom);
                mail.To.Add(mailTo);
                mail.Subject = mailSub;
                mail.Body = mailMess;

                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential(mailFrom, mailPass);
                smtp.EnableSsl = true;

                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
