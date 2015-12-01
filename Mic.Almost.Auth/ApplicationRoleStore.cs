using Mic.Almost.Domain;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Mic.Almost.Auth
{
    public class ApplicationRoleStore : RoleStore<ApplicationRole>
    {
        public ApplicationRoleStore(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}