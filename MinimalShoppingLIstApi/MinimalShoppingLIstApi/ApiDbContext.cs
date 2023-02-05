using Microsoft.EntityFrameworkCore;

namespace MinimalShoppingLIstApi
{
    public class ApiDbContext : DbContext
    {
        public DbSet<Grocery>  Groceries => Set<Grocery>();

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
            
        }
    }
}
