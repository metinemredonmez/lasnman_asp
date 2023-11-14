using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace lansman.Controllers
{
    public abstract class lansmanControllerBase: AbpController
    {
        protected lansmanControllerBase()
        {
            LocalizationSourceName = lansmanConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
