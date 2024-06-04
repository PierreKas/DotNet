using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EventManagementSystem.Data;
using EventManagementSystem.Models;

namespace EventManagementSystem.Controllers
{
    public class AuthenticationsController : BaseController//Controller
    {
        private AuthenticationContext db = new AuthenticationContext();

        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Registration(Registration model)
        {
            if (ModelState.IsValid)
            {
                // Check if the email is already registered
                if (db.Registrations.Any(r => r.Email == model.Email))
                {
                    ModelState.AddModelError("Email", "The email is already registered.");
                    return View(model);
                }

                // Register the user
                db.Registrations.Add(model);
                db.SaveChanges();

                // Optionally, you can log in the user after registration
                // ...

                return RedirectToAction("Login", "Authentications");
            }

            return View(model);
        }

        ///LOGIN
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Registration model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                // Find the user by email
                var user = db.Registrations.FirstOrDefault(r => r.Email == model.Email);

                if (user != null && user.Password == model.Password)
                {
                    if (model.Email.ToLower() == "kasanani@gmail.com")
                    {
                        Session["IsAuthenticated"] = true;
                        Session["IsManager"] = model.Email.ToLower() == "kasanani@gmail.com";
                        return RedirectToAction("Index", "EventTypes");
                    }
                    Session["IsAuthenticated"] = true;
                    Session["IsManager"] = model.Email.ToLower() == "kasanani@gmail.com";
                    //return RedirectToLocal(returnUrl);
                    return RedirectToAction("Index", "EventRegistrations");
                }

                ModelState.AddModelError("", "Invalid login attempt.");
            }

            return View(model);
        }


        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Login", "Authentications");
            }
        }
        ///LOGOUT
        public ActionResult Logout()
        {
            Session["IsAuthenticated"] = null;
            Session["IsManager"] = null;
            return RedirectToAction("Login", "Authentications");
        }
    }
}
