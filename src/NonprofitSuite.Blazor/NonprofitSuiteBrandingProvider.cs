using Microsoft.Extensions.Localization;
using NonprofitSuite.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace NonprofitSuite.Blazor;

[Dependency(ReplaceServices = true)]
public class NonprofitSuiteBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<NonprofitSuiteResource> _localizer;

    public NonprofitSuiteBrandingProvider(IStringLocalizer<NonprofitSuiteResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
