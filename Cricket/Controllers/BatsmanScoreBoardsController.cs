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
    public class BatsmanScoreBoardsController : ControllerBase
    {
        private readonly CricketContext _context;

        public BatsmanScoreBoardsController(CricketContext context)
        {
            _context = context;
        }

        // GET: api/BatsmanScoreBoards
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BatsmanScoreBoard>>> GetBatsmanScoreBoard()
        {
            return await _context.BatsmanScoreBoard.ToListAsync();
        }

        // GET: api/BatsmanScoreBoards/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BatsmanScoreBoard>> GetBatsmanScoreBoard(int id)
        {
            var batsmanScoreBoard = await _context.BatsmanScoreBoard.FindAsync(id);

            if (batsmanScoreBoard == null)
            {
                return NotFound();
            }

            return batsmanScoreBoard;
        }

        // PUT: api/BatsmanScoreBoards/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBatsmanScoreBoard(int id, BatsmanScoreBoard batsmanScoreBoard)
        {
            if (id != batsmanScoreBoard.Id)
            {
                return BadRequest();
            }

            _context.Entry(batsmanScoreBoard).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BatsmanScoreBoardExists(id))
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

        // POST: api/BatsmanScoreBoards
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BatsmanScoreBoard>> PostBatsmanScoreBoard(BatsmanScoreBoard batsmanScoreBoard)
        {
            try
            {
                _context.BatsmanScoreBoard.Add(batsmanScoreBoard);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetBatsmanScoreBoard", new { id = batsmanScoreBoard.Id }, batsmanScoreBoard);
            }
            catch (DbUpdateException ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        // DELETE: api/BatsmanScoreBoards/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBatsmanScoreBoard(int id)
        {
            var batsmanScoreBoard = await _context.BatsmanScoreBoard.FindAsync(id);
            if (batsmanScoreBoard == null)
            {
                return NotFound();
            }

            _context.BatsmanScoreBoard.Remove(batsmanScoreBoard);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BatsmanScoreBoardExists(int id)
        {
            return _context.BatsmanScoreBoard.Any(e => e.Id == id);
        }
    }
}
