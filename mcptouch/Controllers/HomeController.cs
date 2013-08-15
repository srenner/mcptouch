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
            if (User != null)
            {
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                ViewBag.DateRange = mcptouch.Helpers.ProjectDate.GetProjectDateRange();
                return View();
            }
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
