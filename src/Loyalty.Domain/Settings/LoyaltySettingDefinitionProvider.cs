using Volo.Abp.Settings;

namespace Loyalty.Settings;

public class LoyaltySettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(LoyaltySettings.MySetting1));
    }
}
