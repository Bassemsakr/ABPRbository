using Acme.Book.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Acme.Book.Permissions;

public class BookPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var bookStoreGroup = context.AddGroup(BookPermissions.GroupName, L("Permission:BookStore"));

        var booksPermission = bookStoreGroup.AddPermission(BookPermissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(BookPermissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(BookPermissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(BookPermissions.Books.Delete, L("Permission:Books.Delete"));

        var authorsPermission = bookStoreGroup.AddPermission(
    BookPermissions.Authors.Default, L("Permission:Authors"));
        authorsPermission.AddChild(
            BookPermissions.Authors.Create, L("Permission:Authors.Create"));
        authorsPermission.AddChild(
            BookPermissions.Authors.Edit, L("Permission:Authors.Edit"));
        authorsPermission.AddChild(
            BookPermissions.Authors.Delete, L("Permission:Authors.Delete"));

    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BookResource>(name);
    }
}
