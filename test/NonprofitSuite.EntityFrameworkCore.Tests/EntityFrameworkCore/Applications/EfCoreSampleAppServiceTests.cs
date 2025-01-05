using NonprofitSuite.Samples;
using Xunit;

namespace NonprofitSuite.EntityFrameworkCore.Applications;

[Collection(NonprofitSuiteTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<NonprofitSuiteEntityFrameworkCoreTestModule>
{

}
