using NonprofitSuite.Samples;
using Xunit;

namespace NonprofitSuite.EntityFrameworkCore.Domains;

[Collection(NonprofitSuiteTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<NonprofitSuiteEntityFrameworkCoreTestModule>
{

}
