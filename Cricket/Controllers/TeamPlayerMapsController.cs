using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Cricket.Data;
using Cricket.Models;

namespace Cricket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamPlayerMapsController : ControllerBase
    {
        private readonly CricketContext _context;

        public TeamPlayerMapsController(CricketContext context)
        {
            _context = context;
        }

        // GET: api/TeamPlayerMaps
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TeamPlayerMap>>> GetTeamPlayerMap()
        {
            return await _context.TeamPlayerMap.ToListAsync();
        }

        // GET: api/TeamPlayerMaps/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TeamPlayerMap>> GetTeamPlayerMap(int id)
        {
            var teamPlayerMap = await _context.TeamPlayerMap.FindAsync(id);

            if (teamPlayerMap == null)
            {
                return NotFound();
            }

            return teamPlayerMap;
        }

        // PUT: api/TeamPlayerMaps/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTeamPlayerMap(int id, TeamPlayerMap teamPlayerMap)
        {
            if (id != teamPlayerMap.Id)
            {
                return BadRequest();
            }

            _context.Entry(teamPlayerMap).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeamPlayerMapExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TeamPlayerMaps
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TeamPlayerMap>> PostTeamPlayerMap(TeamPlayerMap teamPlayerMap)
        {
            try
            {
                _context.TeamPlayerMap.Add(teamPlayerMap);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetTeamPlayerMap", new { id = teamPlayerMap.Id }, teamPlayerMap);
            }
            catch (DbUpdateException ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        // DELETE: api/TeamPlayerMaps/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTeamPlayerMap(int id)
        {
            var teamPlayerMap = await _context.TeamPlayerMap.FindAsync(id);
            if (teamPlayerMap == null)
            {
                return NotFound();
            }

            _context.TeamPlayerMap.Remove(teamPlayerMap);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TeamPlayerMapExists(int id)
        {
            return _context.TeamPlayerMap.Any(e => e.Id == id);
        }
    }
}
