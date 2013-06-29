using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace mcptouch.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (User.Identity.Name == "")
            {
                ViewBag.DateRange = mcptouch.Helpers.ProjectDate.GetProjectDateRange();
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Dashboard");
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }
    }
}
