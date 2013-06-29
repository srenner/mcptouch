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
    public class FuelController : Controller
    {
        private mcpnetEntities_dev db = new mcpnetEntities_dev();

        //
        // GET: /Fuel/

        public ActionResult Index()
        {
            var fuels = db.Fuels.Include(f => f.Car);
            return View(fuels.ToList());
        }

        //
        // GET: /Fuel/Details/5

        public ActionResult Details(int id = 0)
        {
            Fuel fuel = db.Fuels.Find(id);
            if (fuel == null)
            {
                return HttpNotFound();
            }
            return View(fuel);
        }

        //
        // GET: /Fuel/Create

        public ActionResult Create()
        {
            ViewBag.CarID = new SelectList(db.Cars, "CarID", "Nickname");
            return View();
        }

        //
        // POST: /Fuel/Create

        [HttpPost]
        public ActionResult Create(Fuel fuel)
        {
            if (ModelState.IsValid)
            {
                db.Fuels.Add(fuel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CarID = new SelectList(db.Cars, "CarID", "Nickname", fuel.CarID);
            return View(fuel);
        }

        //
        // GET: /Fuel/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Fuel fuel = db.Fuels.Find(id);
            if (fuel == null)
            {
                return HttpNotFound();
            }
            ViewBag.CarID = new SelectList(db.Cars, "CarID", "Nickname", fuel.CarID);
            return View(fuel);
        }

        //
        // POST: /Fuel/Edit/5

        [HttpPost]
        public ActionResult Edit(Fuel fuel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fuel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CarID = new SelectList(db.Cars, "CarID", "Nickname", fuel.CarID);
            return View(fuel);
        }

        //
        // GET: /Fuel/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Fuel fuel = db.Fuels.Find(id);
            if (fuel == null)
            {
                return HttpNotFound();
            }
            return View(fuel);
        }

        //
        // POST: /Fuel/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Fuel fuel = db.Fuels.Find(id);
            db.Fuels.Remove(fuel);
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