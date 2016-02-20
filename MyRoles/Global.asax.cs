using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Business.Interfaces;
using Ninject;

namespace MyRoles
{
    public class MvcApplication : System.Web.HttpApplication
    {
        [Inject]
        public IExample Example { get; set; }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Session_Start()
        {
            Session["User"] = Example.GetUser();
        }
    }
}
