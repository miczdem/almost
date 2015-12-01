using IdentityManager.Configuration;
using IdentityManager.AspNetIdentity;
using IdentityManager;
using Mic.Almost.WebUI.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
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

            app.Map("/idm", idm =>
            {
                var factory = new IdentityManagerServiceFactory();
                factory.IdentityManagerService = new Registration<IIdentityManagerService,ApplicationIdentityManagerService>();
                factory.Register(new Registration<ApplicationUserManager>());
                factory.Register(new Registration<ApplicationUserStore>());
                factory.Register(new Registration<ApplicationRoleManager>());
                factory.Register(new Registration<ApplicationRoleStore>());
                factory.Register(new Registration<ApplicationDbContext>());

                idm.UseIdentityManager(new IdentityManagerOptions {
                    Factory = factory
                });            
            });
        }
    }


    public class ApplicationUserStore : UserStore<ApplicationUser>
    {
        public ApplicationUserStore(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
    public class ApplicationRoleStore : RoleStore<IdentityRole>
    {
        public ApplicationRoleStore(ApplicationDbContext dbContext):base(dbContext)
        {
            
        }       
    }

    public class ApplicationRoleManager : RoleManager<IdentityRole>
    {
        public ApplicationRoleManager(ApplicationRoleStore roleStore):base(roleStore)
        {
            
        }
    }

    public class ApplicationIdentityManagerService : AspNetIdentityManagerService<ApplicationUser, string, IdentityRole, string>
    {
        public ApplicationIdentityManagerService(ApplicationUserManager userMgr, ApplicationRoleManager roleMgr) : base(userMgr,roleMgr)
        {
            
        }
    }
}
