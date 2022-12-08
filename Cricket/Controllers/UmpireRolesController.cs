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
    public class UmpireRolesController : ControllerBase
    {
        private readonly CricketContext _context;

        public UmpireRolesController(CricketContext context)
        {
            _context = context;
        }

        // GET: api/UmpireRoles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UmpireRole>>> GetUmpireRole()
        {
            return await _context.UmpireRole.ToListAsync();
        }

        // GET: api/UmpireRoles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UmpireRole>> GetUmpireRole(int id)
        {
            var umpireRole = await _context.UmpireRole.FindAsync(id);

            if (umpireRole == null)
            {
                return NotFound();
            }

            return umpireRole;
        }

        // PUT: api/UmpireRoles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUmpireRole(int id, UmpireRole umpireRole)
        {
            if (id != umpireRole.Id)
            {
                return BadRequest();
            }

            _context.Entry(umpireRole).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UmpireRoleExists(id))
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

        // POST: api/UmpireRoles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UmpireRole>> PostUmpireRole(UmpireRole umpireRole)
        {
            try
            {
                _context.UmpireRole.Add(umpireRole);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetUmpireRole", new { id = umpireRole.Id }, umpireRole);
            }
            catch (DbUpdateException ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        // DELETE: api/UmpireRoles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUmpireRole(int id)
        {
            var umpireRole = await _context.UmpireRole.FindAsync(id);
            if (umpireRole == null)
            {
                return NotFound();
            }

            _context.UmpireRole.Remove(umpireRole);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UmpireRoleExists(int id)
        {
            return _context.UmpireRole.Any(e => e.Id == id);
        }
    }
}
