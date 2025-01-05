using NonprofitSuite.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace NonprofitSuite.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class NonprofitSuiteController : AbpControllerBase
{
    protected NonprofitSuiteController()
    {
        LocalizationResource = typeof(NonprofitSuiteResource);
    }
}
