using Volo.Abp.Modularity;

namespace NonprofitSuite;

[DependsOn(
    typeof(NonprofitSuiteDomainModule),
    typeof(NonprofitSuiteTestBaseModule)
)]
public class NonprofitSuiteDomainTestModule : AbpModule
{

}
