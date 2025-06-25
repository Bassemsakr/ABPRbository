using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.Book.Data;

/* This is used if database provider does't define
 * IBookDbSchemaMigrator implementation.
 */
public class NullBookDbSchemaMigrator : IBookDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
