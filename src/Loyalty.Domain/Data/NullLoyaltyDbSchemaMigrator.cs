using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Loyalty.Data;

/* This is used if database provider does't define
 * ILoyaltyDbSchemaMigrator implementation.
 */
public class NullLoyaltyDbSchemaMigrator : ILoyaltyDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
