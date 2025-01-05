using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace NonprofitSuite.Data;

/* This is used if database provider does't define
 * INonprofitSuiteDbSchemaMigrator implementation.
 */
public class NullNonprofitSuiteDbSchemaMigrator : INonprofitSuiteDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
