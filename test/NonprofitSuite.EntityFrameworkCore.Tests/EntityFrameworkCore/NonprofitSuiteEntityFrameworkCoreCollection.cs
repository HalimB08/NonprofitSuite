using Xunit;

namespace NonprofitSuite.EntityFrameworkCore;

[CollectionDefinition(NonprofitSuiteTestConsts.CollectionDefinitionName)]
public class NonprofitSuiteEntityFrameworkCoreCollection : ICollectionFixture<NonprofitSuiteEntityFrameworkCoreFixture>
{

}
