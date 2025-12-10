using Microsoft.EntityFrameworkCore;

namespace EstoqueAPI.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {}
    }
}
