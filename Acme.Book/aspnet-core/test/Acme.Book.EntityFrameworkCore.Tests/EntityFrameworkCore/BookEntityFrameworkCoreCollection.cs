using Xunit;

namespace Acme.Book.EntityFrameworkCore;

[CollectionDefinition(BookTestConsts.CollectionDefinitionName)]
public class BookEntityFrameworkCoreCollection : ICollectionFixture<BookEntityFrameworkCoreFixture>
{

}
