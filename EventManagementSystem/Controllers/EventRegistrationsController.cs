using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EventManagementSystem.Models;

namespace EventManagementSystem.Controllers
{
    public class EventRegistrationsController : BaseController
    {
        private EventMgtTBEntities db = new EventMgtTBEntities();

        // GET: EventRegistrations
        public ActionResult Index()
        {
            var eventRegistrations = db.EventRegistrations.Include(e => e.Attendee).Include(e => e.EventDetail);
            return View(eventRegistrations.ToList());
        }

        // GET: EventRegistrations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventRegistration eventRegistration = db.EventRegistrations.Find(id);
            if (eventRegistration == null)
            {
                return HttpNotFound();
            }
            return View(eventRegistration);
        }

        // GET: EventRegistrations/Create
        public ActionResult Create()
        {
            ViewBag.AttendeeID = new SelectList(db.Attendees, "uuID", "email");
            ViewBag.eventID = new SelectList(db.EventDetails, "uuId", "eventName");
            return View();
        }

        // POST: EventRegistrations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "uuID,eventID,AttendeeID")] EventRegistration eventRegistration)
        {
            //Venue maxVenue= new Venue();
            if (ModelState.IsValid)
            {
                // Check if the event already has 3 registered attendees
                int existingRegistrationsCount = db.EventRegistrations.Count(r => r.eventID == eventRegistration.eventID);
                int venueMax;
                //int venueCap = db.Venues.Max(r => r.capacity == maxVenue.capacity);
                if (existingRegistrationsCount >= 3)
                {
                    // Event is full, display a message
                    ModelState.AddModelError("", "The event is already full. No more registrations can be accepted.");
                    ViewBag.AttendeeID = new SelectList(db.Attendees, "uuID", "email", eventRegistration.AttendeeID);
                    ViewBag.eventID = new SelectList(db.EventDetails, "uuId", "eventName", eventRegistration.eventID);
                    return View(eventRegistration);
                }

                db.EventRegistrations.Add(eventRegistration);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AttendeeID = new SelectList(db.Attendees, "uuID", "email", eventRegistration.AttendeeID);
            ViewBag.eventID = new SelectList(db.EventDetails, "uuId", "eventName", eventRegistration.eventID);
            return View(eventRegistration);
        }

        // GET: EventRegistrations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventRegistration eventRegistration = db.EventRegistrations.Find(id);
            if (eventRegistration == null)
            {
                return HttpNotFound();
            }
            ViewBag.AttendeeID = new SelectList(db.Attendees, "uuID", "email", eventRegistration.AttendeeID);
            ViewBag.eventID = new SelectList(db.EventDetails, "uuId", "eventName", eventRegistration.eventID);
            return View(eventRegistration);
        }

        // POST: EventRegistrations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "uuID,eventID,AttendeeID")] EventRegistration eventRegistration)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eventRegistration).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AttendeeID = new SelectList(db.Attendees, "uuID", "email", eventRegistration.AttendeeID);
            ViewBag.eventID = new SelectList(db.EventDetails, "uuId", "eventName", eventRegistration.eventID);
            return View(eventRegistration);
        }

        // GET: EventRegistrations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventRegistration eventRegistration = db.EventRegistrations.Find(id);
            if (eventRegistration == null)
            {
                return HttpNotFound();
            }
            return View(eventRegistration);
        }

        // POST: EventRegistrations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EventRegistration eventRegistration = db.EventRegistrations.Find(id);
            db.EventRegistrations.Remove(eventRegistration);
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
