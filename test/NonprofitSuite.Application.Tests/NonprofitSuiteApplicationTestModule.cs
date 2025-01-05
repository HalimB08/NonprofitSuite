using Volo.Abp.Modularity;

namespace NonprofitSuite;

[DependsOn(
    typeof(NonprofitSuiteApplicationModule),
    typeof(NonprofitSuiteDomainTestModule)
)]
public class NonprofitSuiteApplicationTestModule : AbpModule
{

}
