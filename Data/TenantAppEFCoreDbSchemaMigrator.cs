using Microsoft.EntityFrameworkCore;
using Volo.Abp.DependencyInjection;

namespace FYJ.IOT.TenantApp.Data;

public class TenantAppEFCoreDbSchemaMigrator : ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public TenantAppEFCoreDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the TenantAppDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<TenantAppDbContext>()
            .Database
            .MigrateAsync();
    }
}
