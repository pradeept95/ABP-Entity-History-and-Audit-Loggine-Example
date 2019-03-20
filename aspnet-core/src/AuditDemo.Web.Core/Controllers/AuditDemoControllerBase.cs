using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace AuditDemo.Controllers
{
    public abstract class AuditDemoControllerBase: AbpController
    {
        protected AuditDemoControllerBase()
        {
            LocalizationSourceName = AuditDemoConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
