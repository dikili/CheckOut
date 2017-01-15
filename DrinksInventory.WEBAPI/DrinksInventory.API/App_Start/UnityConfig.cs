using Microsoft.Practices.Unity;
using System.Web.Http;
using DrinksInventory.Data.Interfaces;
using DrinksInventory.Data.Repositories;
using Unity.WebApi;

namespace DrinksInventory.API
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            container.RegisterType<IDrinkRepository, DrinkListRepository>();
  
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}