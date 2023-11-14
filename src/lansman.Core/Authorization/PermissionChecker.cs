using Abp.Authorization;
using lansman.Authorization.Roles;
using lansman.Authorization.Users;

namespace lansman.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
