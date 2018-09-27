using Microsoft.EntityFrameworkCore;

namespace NewsApp.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<News> News { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }
    }
}
