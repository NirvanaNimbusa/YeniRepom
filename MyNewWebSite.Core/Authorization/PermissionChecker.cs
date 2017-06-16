using Abp.Authorization;
using MyNewWebSite.Authorization.Roles;
using MyNewWebSite.MultiTenancy;
using MyNewWebSite.Users;

namespace MyNewWebSite.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
