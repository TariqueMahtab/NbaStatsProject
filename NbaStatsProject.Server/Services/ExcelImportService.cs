using OfficeOpenXml;
using NbaStatsProject.Server.Data;
using NbaStatsProject.Server.Models;

namespace NbaStatsProject.Server.Services
{
    public class ExcelImportService
    {
        private readonly NbaStatsDbContext _context;

        public ExcelImportService(NbaStatsDbContext context)
        {
            _context = context;
        }

        public async Task ImportPlayersFromExcel(string filePath)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using var package = new ExcelPackage(new FileInfo(filePath));
            var worksheet = package.Workbook.Worksheets[0];

            int rowCount = worksheet.Dimension.Rows;

            for (int row = 2; row <= rowCount; row++)
            {
                var player = new Player
                {
                    Id = worksheet.Cells[row, 1].GetValue<double>(),
                    PlayerName = worksheet.Cells[row, 2].Text,
                    Team = worksheet.Cells[row, 3].Text,
                    Position = worksheet.Cells[row, 4].Text,
                    GamesPlayed = worksheet.Cells[row, 5].GetValue<double?>(),
                    MinutesPlayed = worksheet.Cells[row, 6].GetValue<double?>(),
                    Points = worksheet.Cells[row, 7].GetValue<double?>(),
                    Assists = worksheet.Cells[row, 8].GetValue<double?>(),
                    Rebounds = worksheet.Cells[row, 9].GetValue<double?>()
                };

                _context.Players.Add(player);
            }

            await _context.SaveChangesAsync();
        }
    }
}
