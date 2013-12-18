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
            var userID = identity.Ticket.UserData;
            ViewBag.UserID = userID;

            int? uID = int.Parse(userID);

            bool test = mcptouch.Helpers.SecurityCheck.UserOwnsCar(1, 2);

            //var objectResult = db.uspGetMaintenanceAlertsForUser(uID);


            return View();
        }

    }
}
