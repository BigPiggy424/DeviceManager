using Abp.Authorization;
using DeviceManagement.Authorization.Roles;
using DeviceManagement.Authorization.Users;

namespace DeviceManagement.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
