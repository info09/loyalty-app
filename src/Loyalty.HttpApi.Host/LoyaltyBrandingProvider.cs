using Microsoft.Extensions.Localization;
using Loyalty.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Loyalty;

[Dependency(ReplaceServices = true)]
public class LoyaltyBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<LoyaltyResource> _localizer;

    public LoyaltyBrandingProvider(IStringLocalizer<LoyaltyResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
