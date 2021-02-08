using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using Narail.Models;

namespace Narail.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contact(ContactFormModel contactModel)
        {
            MailMessage mail  = new MailMessage();
            mail.To.Add("ramazanalltuntepe@gmail.com");
            mail.From = new MailAddress("ramazanalltuntepe@gmail.com");
            mail.Subject = contactModel.ContactSubject;
            mail.Body = contactModel.ContactName + contactModel.ContactMessage + contactModel.ContactPhone + contactModel.ContactPhone;
            mail.IsBodyHtml = true;
            
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Port = 587;
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.EnableSsl = true;
            try
            {
                smtpClient.Send(mail);
                TempData["Message"] = "Gönderim Başarılı!.";
            }
            catch (Exception e)
            {
                TempData["Message"] = "Gönderim Başarısız." + e.Message;
            }
            
            return View();
        }

    }
}
