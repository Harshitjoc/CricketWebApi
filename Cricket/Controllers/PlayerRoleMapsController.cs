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
    public class PlayerRoleMapsController : ControllerBase
    {
        private readonly CricketContext _context;

        public PlayerRoleMapsController(CricketContext context)
        {
            _context = context;
        }

        // GET: api/PlayerRoleMaps
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PlayerRoleMap>>> GetPlayerRoleMap()
        {
            return await _context.PlayerRoleMap.ToListAsync();
        }

        // GET: api/PlayerRoleMaps/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PlayerRoleMap>> GetPlayerRoleMap(int id)
        {
            var playerRoleMap = await _context.PlayerRoleMap.FindAsync(id);

            if (playerRoleMap == null)
            {
                return NotFound();
            }

            return playerRoleMap;
        }

        // PUT: api/PlayerRoleMaps/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPlayerRoleMap(int id, PlayerRoleMap playerRoleMap)
        {
            if (id != playerRoleMap.Id)
            {
                return BadRequest();
            }

            _context.Entry(playerRoleMap).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlayerRoleMapExists(id))
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

        // POST: api/PlayerRoleMaps
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PlayerRoleMap>> PostPlayerRoleMap(PlayerRoleMap playerRoleMap)
        {
            try
            {
                _context.PlayerRoleMap.Add(playerRoleMap);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetPlayerRoleMap", new { id = playerRoleMap.Id }, playerRoleMap);
            }
            catch (DbUpdateException ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        // DELETE: api/PlayerRoleMaps/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePlayerRoleMap(int id)
        {
            var playerRoleMap = await _context.PlayerRoleMap.FindAsync(id);
            if (playerRoleMap == null)
            {
                return NotFound();
            }

            _context.PlayerRoleMap.Remove(playerRoleMap);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PlayerRoleMapExists(int id)
        {
            return _context.PlayerRoleMap.Any(e => e.Id == id);
        }
    }
}
