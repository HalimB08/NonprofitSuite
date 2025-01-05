using NonprofitSuite.Localization;
using Volo.Abp.AspNetCore.Components;

namespace NonprofitSuite.Blazor;

public abstract class NonprofitSuiteComponentBase : AbpComponentBase
{
    protected NonprofitSuiteComponentBase()
    {
        LocalizationResource = typeof(NonprofitSuiteResource);
    }
}
