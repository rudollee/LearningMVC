using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelperMethods.Models;

namespace HelperMethods.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
			ViewBag.Fruits = new string[] { "Spple", "Orange", "Pear" };
			ViewBag.Cities = new string[] { "New York", "London", "Paris" };

			string message = "This is an HTML element: <input>";

            return View((object)message);
        }

		public ActionResult CreatePerson()
		{
			return View(new Person());
		}

		[HttpPost]
		public ActionResult CreatePerson(Person Person)
		{
			//return View(Person);
			return View("DisplayPerson", Person);
		}
    }
}