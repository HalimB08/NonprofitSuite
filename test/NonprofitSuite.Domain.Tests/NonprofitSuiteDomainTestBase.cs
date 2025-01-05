using Volo.Abp.Modularity;

namespace NonprofitSuite;

/* Inherit from this class for your domain layer tests. */
public abstract class NonprofitSuiteDomainTestBase<TStartupModule> : NonprofitSuiteTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
