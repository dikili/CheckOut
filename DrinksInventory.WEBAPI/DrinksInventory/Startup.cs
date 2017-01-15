using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DrinksInventory.Startup))]
namespace DrinksInventory
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
