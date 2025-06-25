using Volo.Abp.Modularity;

namespace Acme.Book;

public abstract class BookApplicationTestBase<TStartupModule> : BookTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
