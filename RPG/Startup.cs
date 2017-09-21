using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RPG.Startup))]
namespace RPG
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
