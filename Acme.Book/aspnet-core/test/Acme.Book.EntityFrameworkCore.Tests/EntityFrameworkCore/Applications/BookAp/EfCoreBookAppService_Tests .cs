using Acme.Book.Booktest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Acme.Book.EntityFrameworkCore.Applications.BookAp
{
    [Collection(BookTestConsts.CollectionDefinitionName)]
    public class EfCoreBookAppService_Tests : BookAppService_Tests<BookEntityFrameworkCoreTestModule>
    {
    }
}
