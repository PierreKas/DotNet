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
    public class SessionTbsController : Controller
    {
        private RSVPDBEntities db = new RSVPDBEntities();

        // GET: SessionTbs
        public ActionResult Index()
        {
            return View(db.SessionTbs.ToList());
        }

        // GET: SessionTbs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SessionTb sessionTb = db.SessionTbs.Find(id);
            if (sessionTb == null)
            {
                return HttpNotFound();
            }
            return View(sessionTb);
        }

        // GET: SessionTbs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SessionTbs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "uuid,sessionName,location,timing,capacity")] SessionTb sessionTb)
        {
            if (ModelState.IsValid)
            {
                db.SessionTbs.Add(sessionTb);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sessionTb);
        }

        // GET: SessionTbs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SessionTb sessionTb = db.SessionTbs.Find(id);
            if (sessionTb == null)
            {
                return HttpNotFound();
            }
            return View(sessionTb);
        }

        // POST: SessionTbs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "uuid,sessionName,location,timing,capacity")] SessionTb sessionTb)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sessionTb).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sessionTb);
        }

        // GET: SessionTbs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SessionTb sessionTb = db.SessionTbs.Find(id);
            if (sessionTb == null)
            {
                return HttpNotFound();
            }
            return View(sessionTb);
        }

        // POST: SessionTbs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SessionTb sessionTb = db.SessionTbs.Find(id);
            db.SessionTbs.Remove(sessionTb);
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
