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
    public class ScoreBoardsController : ControllerBase
    {
        private readonly CricketContext _context;

        public ScoreBoardsController(CricketContext context)
        {
            _context = context;
        }

        // GET: api/ScoreBoards
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ScoreBoard>>> GetScoreBoard()
        {
            return await _context.ScoreBoard.ToListAsync();
        }

        // GET: api/ScoreBoards/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ScoreBoard>> GetScoreBoard(int id)
        {
            var scoreBoard = await _context.ScoreBoard.FindAsync(id);

            if (scoreBoard == null)
            {
                return NotFound();
            }

            return scoreBoard;
        }

        // PUT: api/ScoreBoards/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutScoreBoard(int id, ScoreBoard scoreBoard)
        {
            if (id != scoreBoard.Id)
            {
                return BadRequest();
            }

            _context.Entry(scoreBoard).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ScoreBoardExists(id))
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

        // POST: api/ScoreBoards
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ScoreBoard>> PostScoreBoard(ScoreBoard scoreBoard)
        {
            try
            {
                _context.ScoreBoard.Add(scoreBoard);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetScoreBoard", new { id = scoreBoard.Id }, scoreBoard);
            }
            catch (DbUpdateException ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        // DELETE: api/ScoreBoards/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteScoreBoard(int id)
        {
            var scoreBoard = await _context.ScoreBoard.FindAsync(id);
            if (scoreBoard == null)
            {
                return NotFound();
            }

            _context.ScoreBoard.Remove(scoreBoard);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ScoreBoardExists(int id)
        {
            return _context.ScoreBoard.Any(e => e.Id == id);
        }
    }
}
