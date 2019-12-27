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
    public class Terminals_ArrivalsController : Controller
    {
        private Seoul1 db = new Seoul1();

        // GET: Terminals_Arrivals
        public ActionResult Index()
        {
            return View(db.Terminals_Arrivals.ToList());
        }

        // GET: Terminals_Arrivals/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Terminals_Arrivals terminals_Arrivals = db.Terminals_Arrivals.Find(id);
            if (terminals_Arrivals == null)
            {
                return HttpNotFound();
            }
            return View(terminals_Arrivals);
        }

        // GET: Terminals_Arrivals/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Terminals_Arrivals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TerminalID,Terminal")] Terminals_Arrivals terminals_Arrivals)
        {
            if (ModelState.IsValid)
            {
                db.Terminals_Arrivals.Add(terminals_Arrivals);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(terminals_Arrivals);
        }

        // GET: Terminals_Arrivals/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Terminals_Arrivals terminals_Arrivals = db.Terminals_Arrivals.Find(id);
            if (terminals_Arrivals == null)
            {
                return HttpNotFound();
            }
            return View(terminals_Arrivals);
        }

        // POST: Terminals_Arrivals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TerminalID,Terminal")] Terminals_Arrivals terminals_Arrivals)
        {
            if (ModelState.IsValid)
            {
                db.Entry(terminals_Arrivals).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(terminals_Arrivals);
        }

        // GET: Terminals_Arrivals/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Terminals_Arrivals terminals_Arrivals = db.Terminals_Arrivals.Find(id);
            if (terminals_Arrivals == null)
            {
                return HttpNotFound();
            }
            return View(terminals_Arrivals);
        }

        // POST: Terminals_Arrivals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Terminals_Arrivals terminals_Arrivals = db.Terminals_Arrivals.Find(id);
            db.Terminals_Arrivals.Remove(terminals_Arrivals);
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
