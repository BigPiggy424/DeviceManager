using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace DeviceManagement.Controllers
{
    public abstract class DeviceManagementControllerBase: AbpController
    {
        protected DeviceManagementControllerBase()
        {
            LocalizationSourceName = DeviceManagementConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
