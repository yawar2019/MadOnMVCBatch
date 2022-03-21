using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MadOnMVCBatch
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "Nidhi",
                url: "india/Army",
                defaults: new { controller = "new", action = "Index3", id = UrlParameter.Optional }
            );

           


            routes.MapRoute(
               name: "Default",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "new", action = "Index4", id = UrlParameter.Optional }
           );


        }
    }
}
