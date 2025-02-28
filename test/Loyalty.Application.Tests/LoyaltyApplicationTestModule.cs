using Volo.Abp.Modularity;

namespace Loyalty;

[DependsOn(
    typeof(LoyaltyApplicationModule),
    typeof(LoyaltyDomainTestModule)
)]
public class LoyaltyApplicationTestModule : AbpModule
{

}
