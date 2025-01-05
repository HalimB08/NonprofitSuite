using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace NonprofitSuite.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class NonprofitSuiteDbContextFactory : IDesignTimeDbContextFactory<NonprofitSuiteDbContext>
{
    public NonprofitSuiteDbContext CreateDbContext(string[] args)
    {
        // https://www.npgsql.org/efcore/release-notes/6.0.html#opting-out-of-the-new-timestamp-mapping-logic
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        
        var configuration = BuildConfiguration();
        
        NonprofitSuiteEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<NonprofitSuiteDbContext>()
            .UseNpgsql(configuration.GetConnectionString("Default"));
        
        return new NonprofitSuiteDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../NonprofitSuite.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
