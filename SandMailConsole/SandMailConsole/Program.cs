using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;


namespace SandMailConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            //формируем письмо 
            MailMessage mm = new MailMessage("joess63t@yandex.ru", "ufrc@yandex.ru");
            mm.Subject = "Заголовок письма";
            mm.Body = "Тело письма";
            mm.IsBodyHtml = false;                                  // не использовать html  в теле письма


            //Авторизация на сервере smtp
            SmtpClient sc = new SmtpClient("smtp.yandex.ru", 25);
            sc.EnableSsl = true;
            sc.DeliveryMethod = SmtpDeliveryMethod.Network;
            sc.UseDefaultCredentials = false;
            sc.Credentials = new NetworkCredential("joess63t@yandex.ru", "Alhimik163");


            try
            {
                sc.Send(mm);
            }
            
            catch 
            {
                Console.WriteLine("Error");
            }



        }
    }
}
