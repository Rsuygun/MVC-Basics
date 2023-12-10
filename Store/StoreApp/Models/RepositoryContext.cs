using Microsoft.EntityFrameworkCore;
// Bu kurulan yapı veri tabanı işlemi görecek şekilde ayarlandı.
namespace StoreApp.Models
{
    public class RepositoryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}