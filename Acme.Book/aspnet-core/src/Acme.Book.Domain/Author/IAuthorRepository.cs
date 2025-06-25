using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using Volo.Abp.Domain.Repositories;

namespace Acme.Book.Author
{
    public interface IAuthorRepository : IRepository<AuthorEntity, Guid>
    {
        Task<AuthorEntity> FindByNameAsync(string name);

        Task<List<AuthorEntity>> GetListAsync(
            int skipCount,
            int maxResultCount,
            string sorting,
            string filter = null
        );
    }
}