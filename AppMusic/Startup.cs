using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppMusic.Startup))]
namespace AppMusic
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
