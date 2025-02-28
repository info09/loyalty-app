using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Loyalty.Data;
using Volo.Abp.DependencyInjection;

namespace Loyalty.EntityFrameworkCore;

public class EntityFrameworkCoreLoyaltyDbSchemaMigrator
    : ILoyaltyDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreLoyaltyDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the LoyaltyDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<LoyaltyDbContext>()
            .Database
            .MigrateAsync();
    }
}
