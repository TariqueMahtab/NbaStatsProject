using Microsoft.EntityFrameworkCore;
using NbaStatsProject.Server.Models;

namespace NbaStatsProject.Server.Data
{
    public class NbaStatsDbContext : DbContext
    {
        public NbaStatsDbContext(DbContextOptions<NbaStatsDbContext> options) : base(options) { }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data example
            modelBuilder.Entity<Team>().HasData(
                new Team { Id = 1, Name = "Lakers", Conference = "West" },
                new Team { Id = 2, Name = "Celtics", Conference = "East" }
            );

            modelBuilder.Entity<Player>().HasData(
                new Player { Id = 1, FullName = "LeBron James", Position = "SF", PointsPerGame = 25.3, ReboundsPerGame = 7.4, AssistsPerGame = 6.8, TeamId = 1 },
                new Player { Id = 2, FullName = "Jayson Tatum", Position = "SF", PointsPerGame = 27.8, ReboundsPerGame = 8.2, AssistsPerGame = 4.4, TeamId = 2 }
            );
        }
    }
}
