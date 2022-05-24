using Acme.Retail.BookStore.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Acme.Retail.BookStore;

[DependsOn(
    typeof(BookStoreEntityFrameworkCoreTestModule)
    )]
public class BookStoreDomainTestModule : AbpModule
{

}
