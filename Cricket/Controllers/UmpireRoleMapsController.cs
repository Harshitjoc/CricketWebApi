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
    public class UmpireRoleMapsController : ControllerBase
    {
        private readonly CricketContext _context;

        public UmpireRoleMapsController(CricketContext context)
        {
            _context = context;
        }

        // GET: api/UmpireRoleMaps
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UmpireRoleMap>>> GetUmpireRoleMap()
        {
            return await _context.UmpireRoleMap.ToListAsync();
        }

        // GET: api/UmpireRoleMaps/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UmpireRoleMap>> GetUmpireRoleMap(int id)
        {
            var umpireRoleMap = await _context.UmpireRoleMap.FindAsync(id);

            if (umpireRoleMap == null)
            {
                return NotFound();
            }

            return umpireRoleMap;
        }

        // PUT: api/UmpireRoleMaps/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUmpireRoleMap(int id, UmpireRoleMap umpireRoleMap)
        {
            if (id != umpireRoleMap.Id)
            {
                return BadRequest();
            }

            _context.Entry(umpireRoleMap).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UmpireRoleMapExists(id))
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

        // POST: api/UmpireRoleMaps
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UmpireRoleMap>> PostUmpireRoleMap(UmpireRoleMap umpireRoleMap)
        {
            try
            {
                _context.UmpireRoleMap.Add(umpireRoleMap);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetUmpireRoleMap", new { id = umpireRoleMap.Id }, umpireRoleMap);
            }
            catch (DbUpdateException ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        // DELETE: api/UmpireRoleMaps/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUmpireRoleMap(int id)
        {
            var umpireRoleMap = await _context.UmpireRoleMap.FindAsync(id);
            if (umpireRoleMap == null)
            {
                return NotFound();
            }

            _context.UmpireRoleMap.Remove(umpireRoleMap);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UmpireRoleMapExists(int id)
        {
            return _context.UmpireRoleMap.Any(e => e.Id == id);
        }
    }
}
