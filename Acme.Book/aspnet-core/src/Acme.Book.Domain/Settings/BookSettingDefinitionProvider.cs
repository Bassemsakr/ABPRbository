using Volo.Abp.Settings;

namespace Acme.Book.Settings;

public class BookSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(BookSettings.MySetting1));
    }
}
