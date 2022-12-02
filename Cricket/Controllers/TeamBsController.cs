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
    public class TeamBsController : ControllerBase
    {
        private readonly CricketContext _context;

        public TeamBsController(CricketContext context)
        {
            _context = context;
        }

        // GET: api/TeamBs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TeamB>>> GetTeamB()
        {
            return await _context.TeamB.ToListAsync();
        }

        // GET: api/TeamBs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TeamB>> GetTeamB(int id)
        {
            var teamB = await _context.TeamB.FindAsync(id);

            if (teamB == null)
            {
                return NotFound();
            }

            return teamB;
        }

        // PUT: api/TeamBs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTeamB(int id, TeamB teamB)
        {
            if (id != teamB.Id)
            {
                return BadRequest();
            }

            _context.Entry(teamB).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeamBExists(id))
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

        // POST: api/TeamBs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TeamB>> PostTeamB(TeamB teamB)
        {
            _context.TeamB.Add(teamB);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTeamB", new { id = teamB.Id }, teamB);
        }

        // DELETE: api/TeamBs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTeamB(int id)
        {
            var teamB = await _context.TeamB.FindAsync(id);
            if (teamB == null)
            {
                return NotFound();
            }

            _context.TeamB.Remove(teamB);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TeamBExists(int id)
        {
            return _context.TeamB.Any(e => e.Id == id);
        }
    }
}
