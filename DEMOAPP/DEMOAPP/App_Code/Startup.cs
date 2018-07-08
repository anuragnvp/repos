using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DEMOAPP.Startup))]
namespace DEMOAPP
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
