using Acme.Book.Author;
using Acme.Book.Dtos.AuthorDtos;
using Acme.Book.Dtos.BookDtos;
using Acme.Book.Entitis;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Book.Mapping
{
    public class BookStoreApplicationAutoMapperProfile : Profile
    {
        public BookStoreApplicationAutoMapperProfile()
        {
            CreateMap<BooktEntity, BookDto>();
            CreateMap<CreateUpdateBookDto, BooktEntity>();
            CreateMap<AuthorEntity, AuthorDto>();
        }
    }
}
