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
    public class TimeTable_ArrivalsController : Controller
    {
        private Seoul1 db = new Seoul1();

        // GET: TimeTable_Arrivals
        public ActionResult Index()
        {
            var timeTable_Arrivals = db.TimeTable_Arrivals.Include(t => t.Airlines_Arrivals).Include(t => t.Cities_Arrivals).Include(t => t.Flight_Arrivals).Include(t => t.Status_Arrivals).Include(t => t.Terminals_Arrivals);
            return View(timeTable_Arrivals.ToList());
        }

        // GET: TimeTable_Arrivals/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TimeTable_Arrivals timeTable_Arrivals = db.TimeTable_Arrivals.Find(id);
            if (timeTable_Arrivals == null)
            {
                return HttpNotFound();
            }
            return View(timeTable_Arrivals);
        }

        // GET: TimeTable_Arrivals/Create
        public ActionResult Create()
        {
            ViewBag.AirID = new SelectList(db.Airlines_Arrivals, "AirID", "Airline");
            ViewBag.CityID = new SelectList(db.Cities_Arrivals, "CityID", "City");
            ViewBag.FlightID = new SelectList(db.Flight_Arrivals, "FlightNoID", "FlightNo");
            ViewBag.StatusID = new SelectList(db.Status_Arrivals, "StatusID", "Status");
            ViewBag.TerminalID = new SelectList(db.Terminals_Arrivals, "TerminalID", "Terminal");
            return View();
        }

        // POST: TimeTable_Arrivals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,FlightID,AirID,CityID,StatusID,TerminalID,ArrivalTime")] TimeTable_Arrivals timeTable_Arrivals)
        {
            if (ModelState.IsValid)
            {
                db.TimeTable_Arrivals.Add(timeTable_Arrivals);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AirID = new SelectList(db.Airlines_Arrivals, "AirID", "Airline", timeTable_Arrivals.AirID);
            ViewBag.CityID = new SelectList(db.Cities_Arrivals, "CityID", "City", timeTable_Arrivals.CityID);
            ViewBag.FlightID = new SelectList(db.Flight_Arrivals, "FlightNoID", "FlightNo", timeTable_Arrivals.FlightID);
            ViewBag.StatusID = new SelectList(db.Status_Arrivals, "StatusID", "Status", timeTable_Arrivals.StatusID);
            ViewBag.TerminalID = new SelectList(db.Terminals_Arrivals, "TerminalID", "Terminal", timeTable_Arrivals.TerminalID);
            return View(timeTable_Arrivals);
        }

        // GET: TimeTable_Arrivals/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TimeTable_Arrivals timeTable_Arrivals = db.TimeTable_Arrivals.Find(id);
            if (timeTable_Arrivals == null)
            {
                return HttpNotFound();
            }
            ViewBag.AirID = new SelectList(db.Airlines_Arrivals, "AirID", "Airline", timeTable_Arrivals.AirID);
            ViewBag.CityID = new SelectList(db.Cities_Arrivals, "CityID", "City", timeTable_Arrivals.CityID);
            ViewBag.FlightID = new SelectList(db.Flight_Arrivals, "FlightNoID", "FlightNo", timeTable_Arrivals.FlightID);
            ViewBag.StatusID = new SelectList(db.Status_Arrivals, "StatusID", "Status", timeTable_Arrivals.StatusID);
            ViewBag.TerminalID = new SelectList(db.Terminals_Arrivals, "TerminalID", "Terminal", timeTable_Arrivals.TerminalID);
            return View(timeTable_Arrivals);
        }

        // POST: TimeTable_Arrivals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,FlightID,AirID,CityID,StatusID,TerminalID,ArrivalTime")] TimeTable_Arrivals timeTable_Arrivals)
        {
            if (ModelState.IsValid)
            {
                db.Entry(timeTable_Arrivals).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AirID = new SelectList(db.Airlines_Arrivals, "AirID", "Airline", timeTable_Arrivals.AirID);
            ViewBag.CityID = new SelectList(db.Cities_Arrivals, "CityID", "City", timeTable_Arrivals.CityID);
            ViewBag.FlightID = new SelectList(db.Flight_Arrivals, "FlightNoID", "FlightNo", timeTable_Arrivals.FlightID);
            ViewBag.StatusID = new SelectList(db.Status_Arrivals, "StatusID", "Status", timeTable_Arrivals.StatusID);
            ViewBag.TerminalID = new SelectList(db.Terminals_Arrivals, "TerminalID", "Terminal", timeTable_Arrivals.TerminalID);
            return View(timeTable_Arrivals);
        }

        // GET: TimeTable_Arrivals/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TimeTable_Arrivals timeTable_Arrivals = db.TimeTable_Arrivals.Find(id);
            if (timeTable_Arrivals == null)
            {
                return HttpNotFound();
            }
            return View(timeTable_Arrivals);
        }

        // POST: TimeTable_Arrivals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TimeTable_Arrivals timeTable_Arrivals = db.TimeTable_Arrivals.Find(id);
            db.TimeTable_Arrivals.Remove(timeTable_Arrivals);
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
