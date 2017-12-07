using Microsoft.EntityFrameworkCore;

namespace aspnetcorecustomers
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
        {
            
        }
        public DbSet<Customer> Customers { get; set; }
    }
}