using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using mb905315_MIS4200.Models;
using mb905315_MIS4200.Models.DAL;

namespace mb905315_MIS4200.Controllers
{
    public class VisitsController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: Visits
        public ActionResult Index()
        {
            var visitDetails = db.VisitDetails.Include(v => v.Doctor).Include(v => v.Patient);
            return View(visitDetails.ToList());
        }

        // GET: Visits/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Visit visit = db.VisitDetails.Find(id);
            if (visit == null)
            {
                return HttpNotFound();
            }
            return View(visit);
        }

        // GET: Visits/Create
        public ActionResult Create()
        {
            ViewBag.doctorID = new SelectList(db.Doctor, "doctorID", "firstName");
            ViewBag.patientID = new SelectList(db.Patient, "patientID", "firstName");
            return View();
        }

        // POST: Visits/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "visitID,description,visitDate,patientID,doctorID")] Visit visit)
        {
            if (ModelState.IsValid)
            {
                db.VisitDetails.Add(visit);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.doctorID = new SelectList(db.Doctor, "doctorID", "firstName", visit.doctorID);
            ViewBag.patientID = new SelectList(db.Patient, "patientID", "firstName", visit.patientID);
            return View(visit);
        }

        // GET: Visits/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Visit visit = db.VisitDetails.Find(id);
            if (visit == null)
            {
                return HttpNotFound();
            }
            ViewBag.doctorID = new SelectList(db.Doctor, "doctorID", "firstName", visit.doctorID);
            ViewBag.patientID = new SelectList(db.Patient, "patientID", "firstName", visit.patientID);
            return View(visit);
        }

        // POST: Visits/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "visitID,description,visitDate,patientID,doctorID")] Visit visit)
        {
            if (ModelState.IsValid)
            {
                db.Entry(visit).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.doctorID = new SelectList(db.Doctor, "doctorID", "firstName", visit.doctorID);
            ViewBag.patientID = new SelectList(db.Patient, "patientID", "firstName", visit.patientID);
            return View(visit);
        }

        // GET: Visits/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Visit visit = db.VisitDetails.Find(id);
            if (visit == null)
            {
                return HttpNotFound();
            }
            return View(visit);
        }

        // POST: Visits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Visit visit = db.VisitDetails.Find(id);
            db.VisitDetails.Remove(visit);
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
