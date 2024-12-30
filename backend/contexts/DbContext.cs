using Microsoft.EntityFrameworkCore;

namespace AspireSQLEFCore
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<User> Users => Set<User>();
    }
}

