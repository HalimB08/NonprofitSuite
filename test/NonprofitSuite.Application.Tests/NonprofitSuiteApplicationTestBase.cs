using Volo.Abp.Modularity;

namespace NonprofitSuite;

public abstract class NonprofitSuiteApplicationTestBase<TStartupModule> : NonprofitSuiteTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
