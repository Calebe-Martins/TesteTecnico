using Microsoft.EntityFrameworkCore;
using TesteTecnico.Model;

namespace TesteTecnico
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Teste> Teste { get; set; }
        public DbSet<Blog> Blog { get; set; }
        public DbSet<User> User { get; set; }
    }
    
}
