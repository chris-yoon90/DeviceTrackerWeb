using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

using DeviceTrackerWeb.DAL;
using DeviceTrackerWeb.Models;

using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DeviceTrackerWeb
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            DeviceTrackerWebContext db = new DeviceTrackerWebContext();
            RoleStore<DTIdentityRole> roleStore = new RoleStore<DTIdentityRole>(db);
            RoleManager<DTIdentityRole> roleManager = new RoleManager<DTIdentityRole>(roleStore);

            if (!roleManager.RoleExists("Administrator"))
            {
                DTIdentityRole newRole = new DTIdentityRole("Administrator", "Admin user can add, edit and delete data");
                roleManager.Create(newRole);
            }

            if (!roleManager.RoleExists("Employee"))
            {
                DTIdentityRole newRole = new DTIdentityRole("Employee", "Employee user can only view");
                roleManager.Create(newRole);
            }

        }
    }
}
