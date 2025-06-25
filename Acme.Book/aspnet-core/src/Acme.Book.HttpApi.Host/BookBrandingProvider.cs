using Microsoft.Extensions.Localization;
using Acme.Book.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Acme.Book;

[Dependency(ReplaceServices = true)]
public class BookBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<BookResource> _localizer;

    public BookBrandingProvider(IStringLocalizer<BookResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
