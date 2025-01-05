using NonprofitSuite.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace NonprofitSuite.Permissions;

public class NonprofitSuitePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(NonprofitSuitePermissions.GroupName);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(NonprofitSuitePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<NonprofitSuiteResource>(name);
    }
}
