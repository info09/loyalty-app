using Loyalty.Samples;
using Xunit;

namespace Loyalty.EntityFrameworkCore.Domains;

[Collection(LoyaltyTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<LoyaltyEntityFrameworkCoreTestModule>
{

}
