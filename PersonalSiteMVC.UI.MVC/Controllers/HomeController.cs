using System.Net;
using System.Net.Mail;
using System.Web.Mvc;
using PersonalSiteMVC.UI.MVC.Models;

namespace PersonalSiteMVC.UI.MVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult About()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Portfolio()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Fed1Studio()
        {
            return View();
        }

        [HttpGet]
        public ActionResult DungeonApp()
        {
            return View();
        }

        [HttpGet]
        public ActionResult StoreFrontApp()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Links()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(ContactViewModel cvm)
        {
            if (!ModelState.IsValid)
            {
                return View(cvm);
            }

            string message = $"You have recieved an email from {cvm.FirstName} {cvm.LastName}.<br />" +
                $"Subject: {cvm.Subject}<br />" +
                $"Message: {cvm.Message}<br />" +
                $"Please reply to {cvm.Email} with your response at your earliest convenience.";

            MailMessage mm = new MailMessage("administrator@kaylawin.com", "kayla.nghi.nguyen@gmail.com", cvm.Subject, message);

            mm.IsBodyHtml = true;
            mm.Priority = MailPriority.High;

            mm.ReplyToList.Add(cvm.Email);

            SmtpClient client = new SmtpClient("mail.kaylawin.com");

            client.Credentials = new NetworkCredential("administrator@kaylawin.com", "P@ssw0rd");

            client.Port = 8889;

            try
            {
                //Attempt to send email
                client.Send(mm);
            }
            catch (System.Exception ex)
            {
                ViewBag.CustomerMessage = $"We're sorry, your request could not be completed at this time. Please try again later. If the issue persists, please contact your site admnistrator and provide the following information:<br />{ex.StackTrace}";
                return View(cvm);
            }

            return View("EmailConfirmation", cvm);
        }
    }
}
