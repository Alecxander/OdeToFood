using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class CuisineController : Controller
    {
        // GET: Cuisine
        //[Authorize]
        [Log]
        public ActionResult Search(string name = "french")
        {
            throw new Exception("Error de prueba");

            var message = Server.HtmlEncode(name);
            //return Content(message);
            //return RedirectPermanent("http://www.google.com");
            //return RedirectToAction("Index", "Home", new { name = name } );
            //return File(Server.MapPath("~/Content/site.css"), "text/css");
            //return Json(new { Message = message, Name = "Alexander" }, JsonRequestBehavior.AllowGet);
            //return RedirectToAction("About", "Home", new { name = name });
            //return RedirectToRoute("AboutDefault");
            return Content(message);
        }

        //[HttpGet]
        //public ActionResult Search()
        //{
        //    var message = Server.HtmlEncode("Alexander");
        //    //return Content(message);
        //    //return RedirectPermanent("http://www.google.com");
        //    //return RedirectToAction("Index", "Home", new { name = name } );
        //    //return File(Server.MapPath("~/Content/site.css"), "text/css");
        //    //return Json(new { Message = message, Name = "Alexander" }, JsonRequestBehavior.AllowGet);
        //    //return RedirectToAction("About", "Home", new { name = name });
        //    //return RedirectToRoute("AboutDefault");
        //    return Content(message);
        //}
    }
}