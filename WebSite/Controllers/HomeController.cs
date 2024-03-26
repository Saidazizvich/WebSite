using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;
using WebSite.Models;

namespace WebSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
              return View();    
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Services()
        {
            return View();
        }
        public IActionResult Gallery()
        {
            return View();
        }
        public IActionResult Contact(Mail mail)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com",587);
                client.Credentials = new NetworkCredential("efefwdw1@gmail.com", "developer98");
                client.EnableSsl = true;

                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress(mail.Email, mail.Name + "" + mail.SurName);
                mailMessage.To.Add("efefwdw1@gmail.com.com");
                mailMessage.Subject = mail.Topics;
                mailMessage.Body = mail.Message;

                client.Send(mailMessage);

                MailMessage mailMessage2 = new MailMessage();
                mailMessage2.From = new MailAddress("saidasrorkhujaevaziz@gmail.com.com", "Ren A Car");
                mailMessage2.To.Add(mail.Email);
                mailMessage2.Subject = "Mailinize cevab";
                mailMessage2.Body = "Qisa surede donus yapacaz";

                client.Send(mailMessage2);

                ViewBag.Sucess = "Tesekkurler mail gozal sekilda gonderildi";
                return View();
            }
            catch (Exception)
            {

                ViewBag.Error = "Hata Olustu";
            } 

            return View();  
        }
    }
}