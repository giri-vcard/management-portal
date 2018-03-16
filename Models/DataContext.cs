using Microsoft.EntityFrameworkCore;

namespace ManagementPortal.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }
        
        public DbSet<Account> account { get; set; }
        public virtual DbSet<AccountSubscription> account_subscription { get; set; }
    }
}
