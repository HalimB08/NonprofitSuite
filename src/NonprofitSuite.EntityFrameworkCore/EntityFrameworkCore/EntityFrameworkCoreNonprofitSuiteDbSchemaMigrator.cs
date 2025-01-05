using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NonprofitSuite.Data;
using Volo.Abp.DependencyInjection;

namespace NonprofitSuite.EntityFrameworkCore;

public class EntityFrameworkCoreNonprofitSuiteDbSchemaMigrator
    : INonprofitSuiteDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreNonprofitSuiteDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the NonprofitSuiteDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<NonprofitSuiteDbContext>()
            .Database
            .MigrateAsync();
    }
}
