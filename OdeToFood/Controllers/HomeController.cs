using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var controller = RouteData.Values["controller"];
            var action = RouteData.Values["action"];
            var id = RouteData.Values["id"];

            ViewBag.MensajeIndex = string.Format("Route: {0} {1} {2}", controller, action, id);

            return View();
        }

        public ActionResult About()
        {
            var controller = RouteData.Values["controller"];
            var action = RouteData.Values["action"];
            var id = RouteData.Values["id"];



            ViewBag.Message = string.Format("Your application description page. {0} {1} {2}", controller, action, id);
            ViewBag.Location = "Bogota, Colombia.";

            var model = new AboutModel();
            model.Name = "Jhon Alexander";
            model.Location = "Bogota, Colombia.";

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}