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
    public class Flight_ArrivalsController : Controller
    {
        private Seoul1 db = new Seoul1();

        // GET: Flight_Arrivals
        public ActionResult Index()
        {
            return View(db.Flight_Arrivals.ToList());
        }

        // GET: Flight_Arrivals/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Flight_Arrivals flight_Arrivals = db.Flight_Arrivals.Find(id);
            if (flight_Arrivals == null)
            {
                return HttpNotFound();
            }
            return View(flight_Arrivals);
        }

        // GET: Flight_Arrivals/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Flight_Arrivals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FlightNoID,FlightNo")] Flight_Arrivals flight_Arrivals)
        {
            if (ModelState.IsValid)
            {
                db.Flight_Arrivals.Add(flight_Arrivals);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(flight_Arrivals);
        }

        // GET: Flight_Arrivals/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Flight_Arrivals flight_Arrivals = db.Flight_Arrivals.Find(id);
            if (flight_Arrivals == null)
            {
                return HttpNotFound();
            }
            return View(flight_Arrivals);
        }

        // POST: Flight_Arrivals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FlightNoID,FlightNo")] Flight_Arrivals flight_Arrivals)
        {
            if (ModelState.IsValid)
            {
                db.Entry(flight_Arrivals).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(flight_Arrivals);
        }

        // GET: Flight_Arrivals/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Flight_Arrivals flight_Arrivals = db.Flight_Arrivals.Find(id);
            if (flight_Arrivals == null)
            {
                return HttpNotFound();
            }
            return View(flight_Arrivals);
        }

        // POST: Flight_Arrivals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Flight_Arrivals flight_Arrivals = db.Flight_Arrivals.Find(id);
            db.Flight_Arrivals.Remove(flight_Arrivals);
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
