using Volo.Abp.Modularity;

namespace Acme.Book;

/* Inherit from this class for your domain layer tests. */
public abstract class BookDomainTestBase<TStartupModule> : BookTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
