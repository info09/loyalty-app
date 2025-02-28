using Loyalty.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace Loyalty.Permissions;

public class LoyaltyPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(LoyaltyPermissions.GroupName);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(LoyaltyPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<LoyaltyResource>(name);
    }
}
