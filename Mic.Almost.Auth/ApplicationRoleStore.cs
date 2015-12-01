using Microsoft.AspNet.Identity.EntityFramework;

namespace Mic.Almost.Auth
{
    public class ApplicationRoleStore : RoleStore<IdentityRole>
    {
        public ApplicationRoleStore(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}