using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Eco_war.UI.Startup))]
namespace Eco_war.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
