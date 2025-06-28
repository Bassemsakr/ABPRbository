using Acme.Book.Dtos.AuthorDtos;
using Acme.Book.Dtos.BookDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.Book.IServise
{
    public interface IBookAppService :
    ICrudAppService< 
        BookDto, 
        Guid, 
        PagedAndSortedResultRequestDto, 
        CreateUpdateBookDto> 
    {
        Task<ListResultDto<ActiveAuthorLookupDto>> GetActiveAuthorLookupAsync();
        Task<ListResultDto<AuthorLookupDto>> GetAuthorLookupAsync();
    }
}
