using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ControllersAndActions.Infrastructure;

namespace ControllersAndActions.Controllers
{
    public class DerivedController : Controller
    {
        public ActionResult Index()
        {
			ViewBag.Message = "Hello from the DerivedController Index method";
            return View("MyView");
        }

		//public void ProduceOutput()
		//{
		//	if (Server.MachineName == "TINY")
		//	{
		//		Response.Redirect("/Basic/Index");
		//	}
		//	else
		//	{
		//		Response.Write("Controller: Derived, Action: ProduceOutput");
		//	}
		//}
		
		public ActionResult ProduceOutput()
		{
			if (Server.MachineName == "TINY")
			{
				return new CustomRedirectResult { Url = "/Basic/Index" };
			}
			else
			{
				Response.Write("Controller: Derived, Action: ProduceOutput");
				return null;
			}
		}

		public ActionResult RenameProduct()
		{
			//Request.QueryString
			//Request.Form
			//Request.Cookies
			//Request.HttpMethod
			//Request.Headers
			//Request.Url
			//Request.UserHostAddress
			//RouteData.Route
			//RouteData.Values
			//HttpContext.Application
			//HttpContext.Cache
			//HttpContext.Items
			//HttpContext.Session
			//User
			//TempData

			string userName = User.Identity.Name;
			string serverName = Server.MachineName;
			string clientIP = Request.UserHostAddress;
			DateTime dateStamp = HttpContext.Timestamp;

			string oldProductName = Request.Form["OldName"];
			string newProductName = Request.Form["NewName"];

			//ViewData["RenameResult"] = result;
			return View("ProductRenamed");
		}

		public ActionResult ShowWeatherForecast(string city, DateTime forDate)
		{
			//string city = (string)RouteData.Values["city"];
			//DateTime forDate = DateTime.Parse(Request.Form["forDate"]);
			return View();
		}

		public ActionResult Search(string query = "all", int page = 1)
		{
			// ...
			return View();
		}

		public ActionResult Refer()
		{
			// inner type of ActionResult
			//ActionResult
			//PartialView
			//RedirectToRoute
			//RedirectResult
			//ContentResult
			//FileResult
			//JsonResult
			//JavaScriptResult
			//HttpUnauthorizedResult
			//HttpNotFoundResult
			//HttpStatusCodeResult
			//EmptyResult

			return View();
		}

    }
}