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
    public class TossesController : ControllerBase
    {
        private readonly CricketContext _context;

        public TossesController(CricketContext context)
        {
            _context = context;
        }

        // GET: api/Tosses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Toss>>> GetToss()
        {
            return await _context.Toss.ToListAsync();
        }

        // GET: api/Tosses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Toss>> GetToss(int id)
        {
            var toss = await _context.Toss.FindAsync(id);

            if (toss == null)
            {
                return NotFound();
            }

            return toss;
        }

        // PUT: api/Tosses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutToss(int id, Toss toss)
        {
            if (id != toss.Id)
            {
                return BadRequest();
            }

            _context.Entry(toss).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TossExists(id))
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

        // POST: api/Tosses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Toss>> PostToss(Toss toss)
        {
            try
            {
                _context.Toss.Add(toss);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetToss", new { id = toss.Id }, toss);
            }
            catch (DbUpdateException ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        // DELETE: api/Tosses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteToss(int id)
        {
            var toss = await _context.Toss.FindAsync(id);
            if (toss == null)
            {
                return NotFound();
            }

            _context.Toss.Remove(toss);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TossExists(int id)
        {
            return _context.Toss.Any(e => e.Id == id);
        }
    }
}
