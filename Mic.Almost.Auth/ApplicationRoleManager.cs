using Mic.Almost.Domain;
using Microsoft.AspNet.Identity;

namespace Mic.Almost.Auth
{
    public class ApplicationRoleManager : RoleManager<ApplicationRole>
    {
        public ApplicationRoleManager(ApplicationRoleStore roleStore) : base(roleStore)
        {

        }
    }
}