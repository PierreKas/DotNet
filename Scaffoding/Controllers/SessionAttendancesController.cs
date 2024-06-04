using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Scaffoding.Models;

namespace Scaffoding.Controllers
{
    public class SessionAttendancesController : Controller
    {
        private RSVPDBEntities db = new RSVPDBEntities();

        // GET: SessionAttendances
        public ActionResult Index()
        {
            var sessionAttendances = db.SessionAttendances.Include(s => s.Attendee).Include(s => s.SessionTb);
            return View(sessionAttendances.ToList());
        }

        // GET: SessionAttendances/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SessionAttendance sessionAttendance = db.SessionAttendances.Find(id);
            if (sessionAttendance == null)
            {
                return HttpNotFound();
            }
            return View(sessionAttendance);
        }

        // GET: SessionAttendances/Create
        public ActionResult Create()
        {
            ViewBag.attendeeId = new SelectList(db.Attendees, "uuid", "FullName");
            ViewBag.sessionId = new SelectList(db.SessionTbs, "uuid", "sessionName");
            return View();
        }

        // POST: SessionAttendances/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "uuid,arrivalTime,attendeeId,sessionId,comment")] SessionAttendance sessionAttendance)
        {
            if (ModelState.IsValid)
            {
                db.SessionAttendances.Add(sessionAttendance);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.attendeeId = new SelectList(db.Attendees, "uuid", "FullName", sessionAttendance.attendeeId);
            ViewBag.sessionId = new SelectList(db.SessionTbs, "uuid", "sessionName", sessionAttendance.sessionId);
            return View(sessionAttendance);
        }

        // GET: SessionAttendances/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SessionAttendance sessionAttendance = db.SessionAttendances.Find(id);
            if (sessionAttendance == null)
            {
                return HttpNotFound();
            }
            ViewBag.attendeeId = new SelectList(db.Attendees, "uuid", "FullName", sessionAttendance.attendeeId);
            ViewBag.sessionId = new SelectList(db.SessionTbs, "uuid", "sessionName", sessionAttendance.sessionId);
            return View(sessionAttendance);
        }

        // POST: SessionAttendances/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "uuid,arrivalTime,attendeeId,sessionId,comment")] SessionAttendance sessionAttendance)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sessionAttendance).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.attendeeId = new SelectList(db.Attendees, "uuid", "FullName", sessionAttendance.attendeeId);
            ViewBag.sessionId = new SelectList(db.SessionTbs, "uuid", "sessionName", sessionAttendance.sessionId);
            return View(sessionAttendance);
        }

        // GET: SessionAttendances/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SessionAttendance sessionAttendance = db.SessionAttendances.Find(id);
            if (sessionAttendance == null)
            {
                return HttpNotFound();
            }
            return View(sessionAttendance);
        }

        // POST: SessionAttendances/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SessionAttendance sessionAttendance = db.SessionAttendances.Find(id);
            db.SessionAttendances.Remove(sessionAttendance);
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
