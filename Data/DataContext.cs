using Microsoft.EntityFrameworkCore;

namespace Web_API___ENtity_Framework.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) { }

        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}
