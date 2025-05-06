using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NbaStatsProject.Server.Models;

namespace NbaStatsProject.Server.Data
{
    public class NbaStatsDbContext : IdentityDbContext<NbaStatsUser>
    {
        public NbaStatsDbContext(DbContextOptions<NbaStatsDbContext> options)
            : base(options)
        {
        }

        public DbSet<Player> Players { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>()
                .ToTable("PlayerStats");

            base.OnModelCreating(modelBuilder);
        }
    }
}
