using System.Threading.Tasks;

namespace Loyalty.Data;

public interface ILoyaltyDbSchemaMigrator
{
    Task MigrateAsync();
}
