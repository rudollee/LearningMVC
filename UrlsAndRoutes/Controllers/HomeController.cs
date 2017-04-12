using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UrlsAndRoutes.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
			ViewBag.Controller = "Home";
			ViewBag.Action = "Index";
            return View("ActionName");
        }

		public ActionResult CustomVariable(string id = "DefaultId")
		{
			ViewBag.Controller = "Home";
			ViewBag.Action = "CustomVariable";
			ViewBag.CustomVariable = id; // ?? "<no value>"; // id; // RouteData.Values["id"];
			return View();
		}

		//public ViewResult MyActionMethod()
		//{
		//	string myActionUrl = Url.Action("Index", new { id = "MyID" });
		//	string myRouteUrl = Url.RouteUrl(new { controller = "Home", action = "Index" });

		//	return View();
		//}

		//public RedirectToRouteResult MyActionMethod()
		//{
		//	return RedirectToAction("Index");
		//}

		public RedirectToRouteResult MyActionMethod()
		{
			return RedirectToRoute(new { controller = "Home", action = "Index", id = "MyID" });
		}
    }
}