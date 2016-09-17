using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Webs.MapPackage.Startup))]
namespace Webs.MapPackage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
