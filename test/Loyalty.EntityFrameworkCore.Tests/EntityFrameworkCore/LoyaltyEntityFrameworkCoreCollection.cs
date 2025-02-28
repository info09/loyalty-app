using Xunit;

namespace Loyalty.EntityFrameworkCore;

[CollectionDefinition(LoyaltyTestConsts.CollectionDefinitionName)]
public class LoyaltyEntityFrameworkCoreCollection : ICollectionFixture<LoyaltyEntityFrameworkCoreFixture>
{

}
