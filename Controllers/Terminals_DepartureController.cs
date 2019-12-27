using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SeoulAirport;

namespace SeoulAirport.Controllers
{
    public class Terminals_DepartureController : Controller
    {
        private Airport2 db = new Airport2();

        // GET: Terminals_Departure
        public ActionResult Index()
        {
            return View(db.Terminals_Departure.ToList());
        }

        // GET: Terminals_Departure/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Terminals_Departure terminals_Departure = db.Terminals_Departure.Find(id);
            if (terminals_Departure == null)
            {
                return HttpNotFound();
            }
            return View(terminals_Departure);
        }

        // GET: Terminals_Departure/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Terminals_Departure/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TerminalID,Terminal")] Terminals_Departure terminals_Departure)
        {
            if (ModelState.IsValid)
            {
                db.Terminals_Departure.Add(terminals_Departure);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(terminals_Departure);
        }

        // GET: Terminals_Departure/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Terminals_Departure terminals_Departure = db.Terminals_Departure.Find(id);
            if (terminals_Departure == null)
            {
                return HttpNotFound();
            }
            return View(terminals_Departure);
        }

        // POST: Terminals_Departure/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TerminalID,Terminal")] Terminals_Departure terminals_Departure)
        {
            if (ModelState.IsValid)
            {
                db.Entry(terminals_Departure).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(terminals_Departure);
        }

        // GET: Terminals_Departure/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Terminals_Departure terminals_Departure = db.Terminals_Departure.Find(id);
            if (terminals_Departure == null)
            {
                return HttpNotFound();
            }
            return View(terminals_Departure);
        }

        // POST: Terminals_Departure/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Terminals_Departure terminals_Departure = db.Terminals_Departure.Find(id);
            db.Terminals_Departure.Remove(terminals_Departure);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
