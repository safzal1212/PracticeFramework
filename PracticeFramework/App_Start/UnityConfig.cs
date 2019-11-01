using PracticeFramework.Services;
using PracticeFramework.Services.Implimentation;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace PracticeFramework
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<IPracticeFramework, PracticeFrameworkService>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}