using Microsoft.EntityFrameworkCore;

namespace CRUD_NET6
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<SuperHero> SuperHeroes => Set<SuperHero>();   // utworz tabele
    }
}
