using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CeeSharp.Startup))]
namespace CeeSharp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
