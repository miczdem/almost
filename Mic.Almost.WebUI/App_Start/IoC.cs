using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Owin;

namespace Mic.Almost.WebUI
{
    public partial class Startup
    {
        public void ConfigureIoC(IAppBuilder app)
        {
            var builder = new ContainerBuilder();

            // STANDARD MVC SETUP:
            DependencyInjection.IoC.Register(builder);

            // Register your MVC controllers.
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            
            // Run other optional steps, like registering model binders,
            // web abstractions, etc., then set the dependency resolver
            // to be Autofac.
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            // OWIN MVC SETUP:

            // Register the Autofac middleware FIRST, then the Autofac MVC middleware.
            app.UseAutofacMiddleware(container);
            app.UseAutofacMvc();
        }
    }
}