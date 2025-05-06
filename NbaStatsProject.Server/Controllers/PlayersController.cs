using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NbaStatsProject.Server.Data;
using NbaStatsProject.Server.Models;

namespace NbaStatsProject.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlayersController : ControllerBase
    {
        private readonly NbaStatsDbContext _context;

        public PlayersController(NbaStatsDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Player>>> GetPlayers()
        {
            return await _context.Players.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Player>> PostPlayer(PlayerDto dto)
        {
            var player = new Player
            {
                PlayerName = dto.PlayerName,
                Team = dto.Team,
                Position = dto.Position,
                GamesPlayed = dto.GamesPlayed,
                MinutesPlayed = dto.MinutesPlayed,
                Points = dto.Points,
                Assists = dto.Assists,
                Rebounds = dto.Rebounds
            };

            _context.Players.Add(player);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPlayers), new { id = player.Id }, player);
        }
    }
}
