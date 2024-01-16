using Microsoft.EntityFrameworkCore;

namespace PharmaPlus.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Medicine>? med { get; set; }
    }
}
