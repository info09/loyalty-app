using Loyalty.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Loyalty.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(LoyaltyEntityFrameworkCoreModule),
    typeof(LoyaltyApplicationContractsModule)
)]
public class LoyaltyDbMigratorModule : AbpModule
{
}
