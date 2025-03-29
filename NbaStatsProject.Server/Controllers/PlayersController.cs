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
            return await _context.Players.Include(p => p.Team).ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Player>> PostPlayer(PlayerDto dto)
        {
            var team = await _context.Teams.FindAsync(dto.TeamId);
            if (team == null)
            {
                return BadRequest("Team not found.");
            }

            var player = new Player
            {
                FullName = dto.FullName,
                Position = dto.Position,
                PointsPerGame = dto.PointsPerGame,
                ReboundsPerGame = dto.ReboundsPerGame,
                AssistsPerGame = dto.AssistsPerGame,
                Team = team
            };

            _context.Players.Add(player);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPlayers), new { id = player.Id }, player);
        }
    }
}
