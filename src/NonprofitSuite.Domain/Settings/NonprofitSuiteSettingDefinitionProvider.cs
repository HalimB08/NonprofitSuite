using Volo.Abp.Settings;

namespace NonprofitSuite.Settings;

public class NonprofitSuiteSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(NonprofitSuiteSettings.MySetting1));
    }
}
