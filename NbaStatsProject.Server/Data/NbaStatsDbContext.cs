using Microsoft.EntityFrameworkCore;
using NbaStatsProject.Server.Models;

namespace NbaStatsProject.Server.Data
{
    public class NbaStatsDbContext : DbContext
    {
        public NbaStatsDbContext(DbContextOptions<NbaStatsDbContext> options)
            : base(options)
        {
        }

        public DbSet<Player> Players { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>()
                .ToTable("PlayerStats"); // <-- this matches your actual SQL table

            base.OnModelCreating(modelBuilder);
        }
    }
}
