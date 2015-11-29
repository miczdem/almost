using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mic.Almost.WebUI.Startup))]
namespace Mic.Almost.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
