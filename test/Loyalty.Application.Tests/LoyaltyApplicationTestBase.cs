using Volo.Abp.Modularity;

namespace Loyalty;

public abstract class LoyaltyApplicationTestBase<TStartupModule> : LoyaltyTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
