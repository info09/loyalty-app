using Loyalty.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Loyalty.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class LoyaltyController : AbpControllerBase
{
    protected LoyaltyController()
    {
        LocalizationResource = typeof(LoyaltyResource);
    }
}
