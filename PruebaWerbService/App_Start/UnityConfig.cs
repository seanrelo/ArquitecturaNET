using System.Web.Http;
using Unity;
using Unity.WebApi;

using PruebaWerbService.Fachada;

namespace PruebaWerbService
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            container.RegisterType<IFachada, FachadaImpl>();
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}