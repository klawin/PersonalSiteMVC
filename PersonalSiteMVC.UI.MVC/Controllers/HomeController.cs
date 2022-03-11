using System.Web.Mvc;

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
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
