using IdentityManager.AspNetIdentity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Mic.Almost.Auth
{
    public class ApplicationIdentityManagerService : AspNetIdentityManagerService<ApplicationUser, string, IdentityRole, string>
    {
        public ApplicationIdentityManagerService(ApplicationUserManager userMgr, ApplicationRoleManager roleMgr) : base(userMgr, roleMgr)
        {

        }
    }
}