using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EquineNowReloaded.Startup))]
namespace EquineNowReloaded
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
