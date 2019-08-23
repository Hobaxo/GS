using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Unity;
using Unity.AspNet.Mvc;
using Users.Repositories;
using Users.Services;

namespace Users.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            RegisterContainer();
        }

        private static void RegisterContainer()
        {
            var container = new UnityContainer();
            container.RegisterType<IUsersService, UsersService>();
            container.RegisterType<IUsersRepository, UsersRepository>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}
