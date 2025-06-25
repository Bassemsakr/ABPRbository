using Acme.Book.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.Book.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class BookController : AbpControllerBase
{
    protected BookController()
    {
        LocalizationResource = typeof(BookResource);
    }
}
