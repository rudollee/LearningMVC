using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllersAndActions.Controllers
{
	public class ExampleController : Controller
	{
		public ViewResult Index()
		{
			//return View("Homepage");
			//return View("Index", "_AlternateLayoutPage");
			//return View("~/Views/Other/Index.cshtml");

			DateTime date = DateTime.Now;
			//return View(date);

			ViewBag.Message = "Hello";
			ViewBag.Date = DateTime.Now;
			ViewBag.TTT = "TestTestTest";
			return View();
		}

		//public RedirectResult Redirect()
		//{
		//	return Redirect("/Example/Index");
		//	//return RedirectPermanent("/Example/Index");
		//}

		public RedirectToRouteResult Redirect()
		{
			//return RedirectToRoute(new { controller = "Example", Action = "Index", ID = "MyID" });
			return RedirectToAction("Index");
			//return RedirectToActionPermanent("Index");
			//return RedirectToAction("Index", "Basic"); // to other controller
		}

		public RedirectToRouteResult RedirectToRoute()
		{
			TempData["Message"] = "Hello";
			TempData["Date"] = DateTime.Now;
			return RedirectToAction("Index");
		}

		public HttpStatusCodeResult StatusCode()
		{
			//return new HttpStatusCodeResult(404, "URL cannot be serviced");
			return HttpNotFound();
			//return new HttpUnauthorizedResult();
		}
	}
}