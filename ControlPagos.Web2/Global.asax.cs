using System;
using Syncfusion.Licensing;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ControlPagos.Web2
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
SyncfusionLicenseProvider.RegisterLicense("MDAxQDMxMzcyZTMxMmUzMEVNUlNGL1dUQkh6eEIwMnVRN2tJS0lkQUI0cmdwemFNbCtEL1BmSGk5eEU9");
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<Models.PagosDBContext, Migrations.Configuration>());
        }
    }
}
