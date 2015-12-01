using IdentityManager.AspNetIdentity;
using Mic.Almost.Domain;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Mic.Almost.Auth
{
    public class ApplicationIdentityManagerService : AspNetIdentityManagerService<ApplicationUser, string, ApplicationRole, string>
    {
        public ApplicationIdentityManagerService(ApplicationUserManager userMgr, ApplicationRoleManager roleMgr) : base(userMgr, roleMgr)
        {

        }
    }
}