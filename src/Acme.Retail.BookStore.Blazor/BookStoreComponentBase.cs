using Acme.Retail.BookStore.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Acme.Retail.BookStore.Blazor;

public abstract class BookStoreComponentBase : AbpComponentBase
{
    protected BookStoreComponentBase()
    {
        LocalizationResource = typeof(BookStoreResource);
    }
}
