using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DEMOWEBSITE.Startup))]
namespace DEMOWEBSITE
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
