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
    public class PlayerRolesController : ControllerBase
    {
        private readonly CricketContext _context;

        public PlayerRolesController(CricketContext context)
        {
            _context = context;
        }

        // GET: api/PlayerRoles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PlayerRole>>> GetPlayerRole()
        {
            return await _context.PlayerRole.ToListAsync();
        }

        // GET: api/PlayerRoles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PlayerRole>> GetPlayerRole(int id)
        {
            var playerRole = await _context.PlayerRole.FindAsync(id);

            if (playerRole == null)
            {
                return NotFound();
            }

            return playerRole;
        }

        // PUT: api/PlayerRoles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPlayerRole(int id, PlayerRole playerRole)
        {
            if (id != playerRole.Id)
            {
                return BadRequest();
            }

            _context.Entry(playerRole).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlayerRoleExists(id))
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

        // POST: api/PlayerRoles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PlayerRole>> PostPlayerRole(PlayerRole playerRole)
        {
            try
            {
                _context.PlayerRole.Add(playerRole);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetPlayerRole", new { id = playerRole.Id }, playerRole);
            }
            catch (DbUpdateException ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        // DELETE: api/PlayerRoles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePlayerRole(int id)
        {
            var playerRole = await _context.PlayerRole.FindAsync(id);
            if (playerRole == null)
            {
                return NotFound();
            }

            _context.PlayerRole.Remove(playerRole);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PlayerRoleExists(int id)
        {
            return _context.PlayerRole.Any(e => e.Id == id);
        }
    }
}
