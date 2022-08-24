using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RaceFood.Startup))]
namespace RaceFood
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
