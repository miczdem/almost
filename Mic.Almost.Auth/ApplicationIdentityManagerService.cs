using IdentityManager.AspNetIdentity;
using Mic.Almost.Domain;

namespace Mic.Almost.Auth
{
    public class ApplicationIdentityManagerService : AspNetIdentityManagerService<ApplicationUser, string, ApplicationRole, string>
    {
        public ApplicationIdentityManagerService(ApplicationUserManager userMgr, ApplicationRoleManager roleMgr) : base(userMgr, roleMgr)
        {

        }
    }
}