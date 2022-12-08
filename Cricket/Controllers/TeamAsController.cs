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
    public class TeamAsController : ControllerBase
    {
        private readonly CricketContext _context;

        public TeamAsController(CricketContext context)
        {
            _context = context;
        }

        // GET: api/TeamAs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TeamA>>> GetTeamA()
        {
            return await _context.TeamA.ToListAsync();
        }

        // GET: api/TeamAs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TeamA>> GetTeamA(int id)
        {
            var teamA = await _context.TeamA.FindAsync(id);

            if (teamA == null)
            {
                return NotFound();
            }

            return teamA;
        }

        // PUT: api/TeamAs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTeamA(int id, TeamA teamA)
        {
            if (id != teamA.Id)
            {
                return BadRequest();
            }

            _context.Entry(teamA).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeamAExists(id))
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

        // POST: api/TeamAs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TeamA>> PostTeamA(TeamA teamA)
        {
            try
            {
                _context.TeamA.Add(teamA);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetTeamA", new { id = teamA.Id }, teamA);
            }
            catch (DbUpdateException ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        // DELETE: api/TeamAs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTeamA(int id)
        {
            var teamA = await _context.TeamA.FindAsync(id);
            if (teamA == null)
            {
                return NotFound();
            }

            _context.TeamA.Remove(teamA);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TeamAExists(int id)
        {
            return _context.TeamA.Any(e => e.Id == id);
        }
    }
}
