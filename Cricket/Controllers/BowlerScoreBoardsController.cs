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
    public class BowlerScoreBoardsController : ControllerBase
    {
        private readonly CricketContext _context;

        public BowlerScoreBoardsController(CricketContext context)
        {
            _context = context;
        }

        // GET: api/BowlerScoreBoards
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BowlerScoreBoard>>> GetBowlerScoreBoard()
        {
            return await _context.BowlerScoreBoard.ToListAsync();
        }

        // GET: api/BowlerScoreBoards/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BowlerScoreBoard>> GetBowlerScoreBoard(int id)
        {
            var bowlerScoreBoard = await _context.BowlerScoreBoard.FindAsync(id);

            if (bowlerScoreBoard == null)
            {
                return NotFound();
            }

            return bowlerScoreBoard;
        }

        // PUT: api/BowlerScoreBoards/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBowlerScoreBoard(int id, BowlerScoreBoard bowlerScoreBoard)
        {
            if (id != bowlerScoreBoard.Id)
            {
                return BadRequest();
            }

            _context.Entry(bowlerScoreBoard).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BowlerScoreBoardExists(id))
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

        // POST: api/BowlerScoreBoards
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BowlerScoreBoard>> PostBowlerScoreBoard(BowlerScoreBoard bowlerScoreBoard)
        {
            try
            {
                _context.BowlerScoreBoard.Add(bowlerScoreBoard);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetBowlerScoreBoard", new { id = bowlerScoreBoard.Id }, bowlerScoreBoard);
            }
            catch (DbUpdateException ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        // DELETE: api/BowlerScoreBoards/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBowlerScoreBoard(int id)
        {
            var bowlerScoreBoard = await _context.BowlerScoreBoard.FindAsync(id);
            if (bowlerScoreBoard == null)
            {
                return NotFound();
            }

            _context.BowlerScoreBoard.Remove(bowlerScoreBoard);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BowlerScoreBoardExists(int id)
        {
            return _context.BowlerScoreBoard.Any(e => e.Id == id);
        }
    }
}
