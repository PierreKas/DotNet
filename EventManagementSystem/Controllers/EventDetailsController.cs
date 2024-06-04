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
    public class EventDetailsController : BaseController// Controller
    {
        private EventMgtTBEntities db = new EventMgtTBEntities();

        // GET: EventDetails
        public ActionResult Index()
        {
            var eventDetails = db.EventDetails.Include(e => e.EventType).Include(e => e.Venue);
            return View(eventDetails.ToList());
        }

        // GET: EventDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventDetail eventDetail = db.EventDetails.Find(id);
            if (eventDetail == null)
            {
                return HttpNotFound();
            }
            return View(eventDetail);
        }

        // GET: EventDetails/Create
        public ActionResult Create()
        {
            ViewBag.eventTypeID = new SelectList(db.EventTypes, "uuId", "typeEvent");
            ViewBag.venueID = new SelectList(db.Venues, "uuId", "place");
            return View();
        }

        // POST: EventDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "uuId,eventName,eventDescription,venueID,eventDate,eventTime,eventTypeID")] EventDetail eventDetail)
        {
            if (ModelState.IsValid)
            {
                db.EventDetails.Add(eventDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.eventTypeID = new SelectList(db.EventTypes, "uuId", "typeEvent", eventDetail.eventTypeID);
            ViewBag.venueID = new SelectList(db.Venues, "uuId", "place", eventDetail.venueID);
            return View(eventDetail);
        }

        // GET: EventDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventDetail eventDetail = db.EventDetails.Find(id);
            if (eventDetail == null)
            {
                return HttpNotFound();
            }
            ViewBag.eventTypeID = new SelectList(db.EventTypes, "uuId", "typeEvent", eventDetail.eventTypeID);
            ViewBag.venueID = new SelectList(db.Venues, "uuId", "place", eventDetail.venueID);
            return View(eventDetail);
        }

        // POST: EventDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "uuId,eventName,eventDescription,venueID,eventDate,eventTime,eventTypeID")] EventDetail eventDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eventDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.eventTypeID = new SelectList(db.EventTypes, "uuId", "typeEvent", eventDetail.eventTypeID);
            ViewBag.venueID = new SelectList(db.Venues, "uuId", "place", eventDetail.venueID);
            return View(eventDetail);
        }

        // GET: EventDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventDetail eventDetail = db.EventDetails.Find(id);
            if (eventDetail == null)
            {
                return HttpNotFound();
            }
            return View(eventDetail);
        }

        // POST: EventDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EventDetail eventDetail = db.EventDetails.Find(id);
            db.EventDetails.Remove(eventDetail);
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
