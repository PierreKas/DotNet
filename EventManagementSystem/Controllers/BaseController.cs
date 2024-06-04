using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
/////
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EventManagementSystem.Controllers
{
    public class BaseController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            // Get the current controller and action names
            string currentController = filterContext.RouteData.Values["controller"].ToString();
            string currentAction = filterContext.RouteData.Values["action"].ToString();

            // Exclude the registration action from authentication check
            if (currentController == "Authentications" && currentAction == "Registration")
            {
                base.OnActionExecuting(filterContext); // Allow access to the registration action
                return;
            }
            // Check if the user is authenticated
            if (HttpContext.Session["IsAuthenticated"] == null || !(bool)HttpContext.Session["IsAuthenticated"])
            {
                // Check if the current action is not the Login action to avoid redirect loop
                if (filterContext.ActionDescriptor.ActionName != "Login")
                {
                    // If not authenticated and not trying to access the Login action, redirect to the Login action
                    filterContext.Result = new RedirectToRouteResult(
                        new RouteValueDictionary
                        {
                            { "controller", "Authentications" },
                            { "action", "Login" }
                        });
                    return; // Exit the method to prevent further processing
                }
            }
            else
            {
                // Check if the user is a manager
                bool isManager = HttpContext.Session["IsManager"] != null && (bool)HttpContext.Session["IsManager"];

                // Get the current controller name
                //string currentController = filterContext.RouteData.Values["controller"].ToString();

                // Check if the user is not a manager and trying to access a restricted controller (except Login and Error controllers)
                //if (!isManager && currentController != "Attendees" && currentController != "Authentications" && currentController != "Error")
                if (!isManager && currentController != "Attendees" && currentController != "EventRegistrations" && currentController != "Authentications" && currentController != "EventDetails" && currentController != "Error")
                {
                    // If not a manager and trying to access a restricted controller, redirect to the Attendees controller
                    filterContext.Result = new RedirectToRouteResult(
                        new RouteValueDictionary
                        {
                            { "controller", "Attendees" },
                            { "action", "Index" }
                        });
                    return; // Exit the method to prevent further processing
                }
            }

            base.OnActionExecuting(filterContext);
        }
    }
}