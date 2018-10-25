using AbbadiTrading.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace AbbadiTrading.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            ViewBag.CurrentPage = "Home";
            return View();
        }
        public ActionResult AboutUs()
        {
            ViewBag.CurrentPage = "AboutUs";
            return View();
        }
        public ActionResult ContactUs()
        {
            ViewBag.CurrentPage = "ContactUs";
            return View();
        }

        public ActionResult Success()
        {
            ViewBag.CurrentPage = "Success";
            return View();
        }

        public ActionResult ErrorMessage()
        {
            ViewBag.CurrentPage = "ErrorMessage";
            return View();
        }
        //public ActionResult Contact() {
        //    return View();
        //}

        [HttpPost]
        public ActionResult ContactUs(ContactUsModel model) 
            {
                if (model != null)
                {
                    var emailBody = GetEmailBody(model);
                    if (!ContactUsEmail(emailBody))
                    {
                        ModelState.AddModelError("EmailServer", "Can not send your message now please try again later!");
                        return RedirectToAction("ErrorMessage");
                    }
                    ViewBag.emailResult = "Thanks for your message we will contact you very soon.";
                    return RedirectToAction("Success");
                }
                ModelState.AddModelError("EmailServer", "Can not get your message!");
                return View();

            }


            private string GetEmailBody(ContactUsModel model)
        {
            var contactTemplateAddress =
                Server.MapPath(Url.Content("~" + "/Content/HtmlTemplates/ContactUsEmailTemplate.htm"));
            var htmlBody = System.IO.File.OpenText(contactTemplateAddress).ReadToEnd();

            htmlBody = htmlBody.Replace("{{name}}", model.Name);
            htmlBody = htmlBody.Replace("{{email}}", model.Email);
            htmlBody = htmlBody.Replace("{{message}}", model.Message);
            return htmlBody;
        }

        public bool ContactUsEmail(string emailBody)
        {
            var fromAddress = new MailAddress("contactus@rhineme.com");
            var toAddress = new MailAddress("info@rhineme.com");
            var smtpAddress = "mail.rhineme.com";
            var smtpPassword = "Rhine@0000";

            var email = new MailMessage
            {
                From = fromAddress,
                Subject = "Rhine Contact Us Page",
                IsBodyHtml = true,
                Body = emailBody
            };
            email.To.Add(toAddress);
            return Send(fromAddress, email, smtpPassword, smtpAddress);
        }
        public bool Send(MailAddress fromAddress, MailMessage email, string smtpPassword, string smtpAddress)
        {
            
            var smtp = new SmtpClient(smtpAddress, 587)
            {
                Credentials = new NetworkCredential(fromAddress.Address, smtpPassword)
            };
            email.Bcc.Add(new MailAddress("info@rhineme.com"));
            try
            {
                smtp.Send(email);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }



    }
}
