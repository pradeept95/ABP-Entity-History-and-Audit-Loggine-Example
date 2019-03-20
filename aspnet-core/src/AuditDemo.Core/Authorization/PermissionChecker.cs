using Abp.Authorization;
using AuditDemo.Authorization.Roles;
using AuditDemo.Authorization.Users;

namespace AuditDemo.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
