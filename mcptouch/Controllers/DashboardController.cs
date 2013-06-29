using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace mcptouch.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        //
        // GET: /Dashboard/

        public ActionResult Index()
        {
            FormsIdentity identity = (FormsIdentity)HttpContext.User.Identity;
            ViewBag.UserID = identity.Ticket.UserData;
            return View();
        }

    }
}
