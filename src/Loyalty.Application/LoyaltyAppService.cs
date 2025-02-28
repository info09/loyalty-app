using Loyalty.Localization;
using Volo.Abp.Application.Services;

namespace Loyalty;

/* Inherit your application services from this class.
 */
public abstract class LoyaltyAppService : ApplicationService
{
    protected LoyaltyAppService()
    {
        LocalizationResource = typeof(LoyaltyResource);
    }
}
