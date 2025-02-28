using Loyalty.Samples;
using Xunit;

namespace Loyalty.EntityFrameworkCore.Applications;

[Collection(LoyaltyTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<LoyaltyEntityFrameworkCoreTestModule>
{

}
