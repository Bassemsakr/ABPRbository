using Acme.Book.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Acme.Book;

[DependsOn(
    typeof(BookEntityFrameworkCoreModule),
    typeof(BookApplicationModule),
    typeof(BookDomainTestModule)
)]
public class BookApplicationTestModule : AbpModule
{

}
