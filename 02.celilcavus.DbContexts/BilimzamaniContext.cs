using _01.celilcavus.Entity;
using _02.celilcavus.DbContexts.Configurations;
using Microsoft.EntityFrameworkCore;

namespace _02.celilcavus.DbContexts
{
    public class BilimzamaniContext:DbContext
    {
        public DbSet<Authors> Authors { get; set; }
        public DbSet<Categories> Categories { get; set; }

        public DbSet<Posts> Posts { get; set; }


        public BilimzamaniContext(DbContextOptions<BilimzamaniContext> dbContextOptions) : base(dbContextOptions)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AuthorsConfigurations());
            modelBuilder.ApplyConfiguration(new PostsConfigurations());
            modelBuilder.ApplyConfiguration(new CategoriesConfigurations());
        }

    }
}
