using Volo.Abp.Modularity;

namespace Acme.Book;

[DependsOn(
    typeof(BookDomainModule),
    typeof(BookTestBaseModule)
)]
public class BookDomainTestModule : AbpModule
{

}
