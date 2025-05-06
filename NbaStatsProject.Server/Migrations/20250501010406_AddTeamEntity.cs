using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NbaStatsProject.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddTeamEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Conference", "Name" },
                values: new object[,]
                {
                    { 1, "West", "Lakers" },
                    { 2, "East", "Celtics" }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "AssistsPerGame", "FullName", "PointsPerGame", "Position", "ReboundsPerGame", "TeamId" },
                values: new object[,]
                {
                    { 1, 6.7999999999999998, "LeBron James", 25.300000000000001, "SF", 7.4000000000000004, 1 },
                    { 2, 4.4000000000000004, "Jayson Tatum", 27.800000000000001, "SF", 8.1999999999999993, 2 }
                });
        }
    }
}
