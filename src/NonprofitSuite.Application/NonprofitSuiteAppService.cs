using NonprofitSuite.Localization;
using Volo.Abp.Application.Services;

namespace NonprofitSuite;

/* Inherit your application services from this class.
 */
public abstract class NonprofitSuiteAppService : ApplicationService
{
    protected NonprofitSuiteAppService()
    {
        LocalizationResource = typeof(NonprofitSuiteResource);
    }
}
