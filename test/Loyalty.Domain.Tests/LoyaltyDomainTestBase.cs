using Volo.Abp.Modularity;

namespace Loyalty;

/* Inherit from this class for your domain layer tests. */
public abstract class LoyaltyDomainTestBase<TStartupModule> : LoyaltyTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
