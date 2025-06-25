using Acme.Book.Dtos.BookDtos;
using Acme.Book.Entitis;
using Acme.Book.IServise;
using Acme.Book.Permissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.Book.Servises
{
    public class BookService :
    CrudAppService<
        BooktEntity, 
        BookDto, 
        Guid, 
        PagedAndSortedResultRequestDto, 
        CreateUpdateBookDto>, 
    IBookAppService 
    {
        public BookService(IRepository<BooktEntity, Guid> repository)
            : base(repository)
        {
           
        }

    }

}
