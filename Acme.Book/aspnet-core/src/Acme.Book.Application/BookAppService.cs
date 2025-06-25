using System;
using System.Collections.Generic;
using System.Text;
using Acme.Book.Localization;
using Volo.Abp.Application.Services;

namespace Acme.Book;

/* Inherit your application services from this class.
 */
public abstract class BookAppService : ApplicationService
{
    protected BookAppService()
    {
        LocalizationResource = typeof(BookResource);
    }
}
