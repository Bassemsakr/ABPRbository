using Acme.Book.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Acme.Book.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(BookEntityFrameworkCoreModule),
    typeof(BookApplicationContractsModule)
    )]
public class BookDbMigratorModule : AbpModule
{
}
