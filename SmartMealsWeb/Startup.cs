using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SmartMealsWeb.Startup))]
namespace SmartMealsWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
