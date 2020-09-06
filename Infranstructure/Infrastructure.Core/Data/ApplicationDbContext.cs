
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Core.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) :base(options){}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Test;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

            // public DbSet<>
        }
}
