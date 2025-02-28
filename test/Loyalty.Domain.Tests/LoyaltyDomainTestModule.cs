using Volo.Abp.Modularity;

namespace Loyalty;

[DependsOn(
    typeof(LoyaltyDomainModule),
    typeof(LoyaltyTestBaseModule)
)]
public class LoyaltyDomainTestModule : AbpModule
{

}
