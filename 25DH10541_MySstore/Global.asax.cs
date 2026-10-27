using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace _25DH10541_MySstore
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            _25DH10541_MySstore.FilterConfig.RegisterGlobalFilters(
    System.Web.Mvc.GlobalFilters.Filters);

            _25DH10541_MySstore.RouteConfig.RegisterRoutes(
                System.Web.Routing.RouteTable.Routes);

            _25DH10541_MySstore.BundleConfig.RegisterBundles(
                System.Web.Optimization.BundleTable.Bundles);
        }
    }
}
