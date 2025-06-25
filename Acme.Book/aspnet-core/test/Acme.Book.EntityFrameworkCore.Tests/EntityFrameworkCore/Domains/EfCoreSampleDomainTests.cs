using Acme.Book.Samples;
using Xunit;

namespace Acme.Book.EntityFrameworkCore.Domains;

[Collection(BookTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<BookEntityFrameworkCoreTestModule>
{

}
