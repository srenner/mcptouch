using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mcptouch.Models;

namespace mcptouch.Controllers
{
    public class MaintenanceController : Controller
    {
        private mcpnetEntities_dev db = new mcpnetEntities_dev();

        //
        // GET: /Maintenance/

        public ActionResult Index()
        {
            var maintenances = db.Maintenances.Include(m => m.Car).Include(m => m.Job);
            return View(maintenances.ToList());
        }

        //
        // GET: /Maintenance/Details/5

        public ActionResult Details(int id = 0)
        {
            Maintenance maintenance = db.Maintenances.Find(id);
            if (maintenance == null)
            {
                return HttpNotFound();
            }
            return View(maintenance);
        }

        //
        // GET: /Maintenance/Create

        public ActionResult Create()
        {
            ViewBag.CarID = new SelectList(db.Cars, "CarID", "Nickname");
            ViewBag.JobID = new SelectList(db.Jobs, "JobID", "JobDescr");
            return View();
        }

        //
        // POST: /Maintenance/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Maintenance maintenance)
        {
            if (ModelState.IsValid)
            {
                db.Maintenances.Add(maintenance);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CarID = new SelectList(db.Cars, "CarID", "Nickname", maintenance.CarID);
            ViewBag.JobID = new SelectList(db.Jobs, "JobID", "JobDescr", maintenance.JobID);
            return View(maintenance);
        }

        //
        // GET: /Maintenance/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Maintenance maintenance = db.Maintenances.Find(id);
            if (maintenance == null)
            {
                return HttpNotFound();
            }
            ViewBag.CarID = new SelectList(db.Cars, "CarID", "Nickname", maintenance.CarID);
            ViewBag.JobID = new SelectList(db.Jobs, "JobID", "JobDescr", maintenance.JobID);
            return View(maintenance);
        }

        //
        // POST: /Maintenance/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Maintenance maintenance)
        {
            if (ModelState.IsValid)
            {
                db.Entry(maintenance).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CarID = new SelectList(db.Cars, "CarID", "Nickname", maintenance.CarID);
            ViewBag.JobID = new SelectList(db.Jobs, "JobID", "JobDescr", maintenance.JobID);
            return View(maintenance);
        }

        //
        // GET: /Maintenance/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Maintenance maintenance = db.Maintenances.Find(id);
            if (maintenance == null)
            {
                return HttpNotFound();
            }
            return View(maintenance);
        }

        //
        // POST: /Maintenance/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Maintenance maintenance = db.Maintenances.Find(id);
            db.Maintenances.Remove(maintenance);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}