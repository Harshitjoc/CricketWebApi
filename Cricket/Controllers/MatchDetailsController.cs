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
    public class MatchDetailsController : ControllerBase
    {
        private readonly CricketContext _context;

        public MatchDetailsController(CricketContext context)
        {
            _context = context;
        }

        // GET: api/MatchDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MatchDetail>>> GetMatchDetail()
        {
            return await _context.MatchDetail.ToListAsync();
        }

        // GET: api/MatchDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MatchDetail>> GetMatchDetail(int id)
        {
            var matchDetail = await _context.MatchDetail.FindAsync(id);

            if (matchDetail == null)
            {
                return NotFound();
            }

            return matchDetail;
        }

        // PUT: api/MatchDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMatchDetail(int id, MatchDetail matchDetail)
        {
            if (id != matchDetail.Id)
            {
                return BadRequest();
            }

            _context.Entry(matchDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MatchDetailExists(id))
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

        // POST: api/MatchDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MatchDetail>> PostMatchDetail(MatchDetail matchDetail)
        {
            matchDetail.PlayerCount = (from TeamPlayerMap in _context.TeamPlayerMap
                                       where TeamPlayerMap.Counter == true && TeamPlayerMap.TeamId == matchDetail.TeamId
                                       select TeamPlayerMap.TeamId).Count();

            try
            {
                _context.MatchDetail.Add(matchDetail);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetMatchDetail", new { id = matchDetail.Id }, matchDetail);
            }
            catch (DbUpdateException ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        // DELETE: api/MatchDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMatchDetail(int id)
        {
            var matchDetail = await _context.MatchDetail.FindAsync(id);
            if (matchDetail == null)
            {
                return NotFound();
            }

            _context.MatchDetail.Remove(matchDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MatchDetailExists(int id)
        {
            return _context.MatchDetail.Any(e => e.Id == id);
        }
    }
}
