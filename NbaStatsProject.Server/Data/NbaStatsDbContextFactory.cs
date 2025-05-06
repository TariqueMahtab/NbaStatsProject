using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace NbaStatsProject.Server.Data
{
    public class NbaStatsDbContextFactory : IDesignTimeDbContextFactory<NbaStatsDbContext>
    {
        public NbaStatsDbContext CreateDbContext(string[] args)
        {
            string conn = null;

            try
            {
                var basePath = Directory.GetCurrentDirectory();
                var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production";

                var config = new ConfigurationBuilder()
                    .SetBasePath(basePath)
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: false)
                    .AddJsonFile($"appsettings.{env}.json", optional: true, reloadOnChange: false)
                    .AddEnvironmentVariables()
                    .Build();

                conn = config.GetConnectionString("DefaultConnection");
            }
            catch
            {
                conn = null;
            }

            if (string.IsNullOrWhiteSpace(conn))
            {
                conn = "Server=(localdb)\\mssqllocaldb;Database=NbaStatsDb;Trusted_Connection=True;";
            }

            var opts = new DbContextOptionsBuilder<NbaStatsDbContext>()
                .UseSqlServer(conn)
                .Options;

            return new NbaStatsDbContext(opts);
        }
    }
}
