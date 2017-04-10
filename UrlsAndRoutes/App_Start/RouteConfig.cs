using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Mvc.Routing.Constraints;

namespace UrlsAndRoutes
{
	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			//routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			//routes.MapRoute(
			//    name: "Default",
			//    url: "{controller}/{action}/{id}",
			//    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
			//);

			//routes.MapRoute("ShopSchema2", "Shop/OldAction", new { controller = "Home", action = "Index" });

			//routes.MapRoute("ShopSchema", "Shop/{action}", new { controller = "Home" });

			//routes.MapRoute("", "X{controller}/{action}");

			//Route myRoute = new Route("{controller}/{action}", new MvcRouteHandler());
			//routes.Add("MyRoute", myRoute);

			//routes.MapRoute("MyRoute", "{controller}/{action}");

			//routes.MapRoute("MyRoute", "{controller}/{action}", new { action = "Index" });

			//routes.MapRoute("MyRoute", "{controller}/{action}", new { controller = "Home", action = "Index" });

			//routes.MapRoute("", "Public/{controller}/{action}", new { controler = "Home", action = "Index" });

			//routes.MapRoute("MyRoute", "{controller}/{action}/{id}", new { controller = "Home", action = "Index", id = UrlParameter.Optional /* "DefaultId" */ });

			//routes.MapRoute("MyRoute", "{controller}/{action}/{id}/{*catchall}", new { controller = "Home", action = "Index", id = UrlParameter.Optional });

			//routes.MapRoute("MyRoute", "{controller}/{action}/{id}/{*catchall}", new { controller = "Home", action = "Index", id = UrlParameter.Optional },
			//	new[] { "URLsAndRoutes.AdditionalControllers" });

			//routes.MapRoute("MyRoute", "{controller}/{action}/{id}/{*catchall}", new { controller = "Home", action = "Index", id = UrlParameter.Optional },
			//	new[] { "URLsAndRoutes.Controllers" });

			//Route myRoute = routes.MapRoute("AddControllerRoute", "Home/{action}/{id}/{*catchall}",
			//	new { controller = "Home", action = "Index", id = UrlParameter.Optional },
			//	new[] { "UrlsAndRoutes.AdditionalControllers" });

			//myRoute.DataTokens["UseNamespaceFallback"] = false;

			//routes.MapRoute("MyRoute", "{controller}/{action}/{id}/{*catchall}",
			//	new { controller = "Home", action = "Index", id = UrlParameter.Optional },
			//	new { controller = "^H.*", action = "^Index$ | ^About$" },
			//	new[] { "URLsAndROutes.Controllers" });

			//routes.MapRoute("MyRoute", "{controller}/{action}/{id}/{*catchall}",
			//	new { controller = "Home", action = "Index", id = UrlParameter.Optional },
			//	new { controller = "^H.*", action = "^Index|About", httpMethod = new HttpMethodConstraint("GET"), id = new RangeRouteConstraint(10, 20) },
			//	new[] { "URLsAndROutes.Controllers" });

			routes.MapRoute("MyRoute", "{controller}/{action}/{id}/{*catchall}",
				new { controller = "Home", action = "Index", id = UrlParameter.Optional },
				new { controller = "^H.*", action = "^Index|About", httpMethod = new HttpMethodConstraint("GET"),
					id = new CompoundRouteConstraint(new IRouteConstraint[] { new AlphaRouteConstraint(), new MinLengthRouteConstraint(6) }) },
				new[] { "URLsAndROutes.Controllers" });
		}
	}
}
