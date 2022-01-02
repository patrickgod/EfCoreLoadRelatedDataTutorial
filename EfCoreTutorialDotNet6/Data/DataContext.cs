using Microsoft.EntityFrameworkCore;

namespace EfCoreTutorialDotNet6.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comic>().Navigation(c => c.Teams).AutoInclude();
            modelBuilder.Entity<Team>().Navigation(t => t.SuperHeroes).AutoInclude();

            modelBuilder.Entity<Comic>().HasData(
                new Comic { Id = 1, Name = "Marvel" },
                new Comic { Id = 2, Name = "DC" });

            modelBuilder.Entity<Team>().HasData(
                new Team { Id = 1, Name = "Avengers", ComicId = 1 },
                new Team { Id = 2, Name = "Justice League", ComicId = 2 });

            modelBuilder.Entity<SuperHero>().HasData(
                new SuperHero { Id = 1, Name = "Spiderman", TeamId = 1 },
                new SuperHero { Id = 2, Name = "Iron Man", TeamId = 1 },
                new SuperHero { Id = 3, Name = "Batman", TeamId = 2 },
                new SuperHero { Id = 4, Name = "Wonder Woman", TeamId = 2 });
        }

        public DbSet<Comic>? Comics { get; set; }
        public DbSet<Team>? Teams { get; set; }
        public DbSet<SuperHero>? SuperHeroes { get; set; }
    }
}
