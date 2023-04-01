using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace FYJ.IOT.TenantApp.Data;

public class TenantAppDbContextFactory : IDesignTimeDbContextFactory<TenantAppDbContext>
{
    public TenantAppDbContext CreateDbContext(string[] args)
    {

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<TenantAppDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new TenantAppDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
