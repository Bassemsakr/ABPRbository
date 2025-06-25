using Acme.Book.Samples;
using Xunit;

namespace Acme.Book.EntityFrameworkCore.Applications;

[Collection(BookTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<BookEntityFrameworkCoreTestModule>
{

}
