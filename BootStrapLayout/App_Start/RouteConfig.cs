﻿using System.Web.Mvc;
using System.Web.Routing;

namespace BootStrapLayout
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.LowercaseUrls = true;
            routes.MapRoute("Default", "{controller}/{action}/{id}", new
            {
                controller = "Home",
                action = "Index",
                id = UrlParameter.Optional
            }).RouteHandler = new DashRouteHandler();
            
        }
    }
}
