using Acme.Retail.BookStore.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.Retail.BookStore.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class BookStoreController : AbpControllerBase
{
    protected BookStoreController()
    {
        LocalizationResource = typeof(BookStoreResource);
    }
}
