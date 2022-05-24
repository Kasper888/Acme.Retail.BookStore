using System.Threading.Tasks;

namespace Acme.Retail.BookStore.Data;

public interface IBookStoreDbSchemaMigrator
{
    Task MigrateAsync();
}
