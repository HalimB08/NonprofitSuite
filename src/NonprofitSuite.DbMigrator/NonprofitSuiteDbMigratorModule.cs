using NonprofitSuite.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace NonprofitSuite.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(NonprofitSuiteEntityFrameworkCoreModule),
    typeof(NonprofitSuiteApplicationContractsModule)
)]
public class NonprofitSuiteDbMigratorModule : AbpModule
{
}
