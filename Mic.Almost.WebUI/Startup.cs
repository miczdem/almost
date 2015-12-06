using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Mic.Almost.WebUI.Startup))]
namespace Mic.Almost.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureIoC(app);
            ConfigureAuth(app);
        }
    }


}
