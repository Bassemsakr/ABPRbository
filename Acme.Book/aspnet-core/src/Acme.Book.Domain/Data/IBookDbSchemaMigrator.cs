using System.Threading.Tasks;

namespace Acme.Book.Data;

public interface IBookDbSchemaMigrator
{
    Task MigrateAsync();
}
