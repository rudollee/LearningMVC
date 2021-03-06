﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EssentialTools.Models;

namespace EssentialTools.Controllers
{
    public class HomeController : Controller
    {
		private IValueCalculator calc;
		private Product[] products =
		{
			new Product {Name = "Kayak", Category = "Watersports", Price = 275M },
			new Product {Name = "Lifejacket", Category = "Watersports", Price = 48.95M},
			new Product {Name = "Soccer ball", Category = "Soccer", Price = 19.50M },
			new Product {Name = "Coner flag", Category = "Soccer", Price = 34.95M }
		};

		public HomeController(IValueCalculator calcParam)
		{
			calc = calcParam;
		}

        public ActionResult Index()
        {
			//LinqValueCalculator calc = new LinqValueCalculator();
			//IValueCalculator calc = new LinqValueCalculator();
			//IKernel ninjectKernel = new StandardKernel();
			//ninjectKernel.Bind<IValueCalculator>().To<LinqValueCalculator>();
			//IValueCalculator calc = ninjectKernel.Get<IValueCalculator>();

			ShoppingCart cart = new ShoppingCart(calc)
			{
				Products = products
			};

			decimal totalValue = cart.CalculatorProdutTotal();

			return View(totalValue);
        }
    }
}