using System.Threading.Tasks;

namespace NonprofitSuite.Data;

public interface INonprofitSuiteDbSchemaMigrator
{
    Task MigrateAsync();
}
