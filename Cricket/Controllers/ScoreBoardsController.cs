using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Cricket.Data.Models;
using Cricket.Services;

namespace Cricket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScoreBoardsController : ControllerBase
    {
        private readonly IScoreBoardService _service;
        public ScoreBoardsController(IScoreBoardService service)
        {
            _service = service;
        }

        // GET: api/ScoreBoards
        [HttpGet]
        public async Task<IEnumerable<ScoreBoard>> GetScoreBoard()
        {
            return await _service.GetAll();
        }

        // GET: api/ScoreBoards/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ScoreBoard>> GetScoreBoard(int id)
        {
            var scoreBoard = await _service.GetById(id);

            if (scoreBoard == null)
            {
                return NotFound();
            }

            return scoreBoard;
        }

        // PUT: api/ScoreBoards/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async void PutScoreBoard(ScoreBoard scoreBoard)
        {
            await _service.Update(scoreBoard);
        }

        // POST: api/ScoreBoards
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public void PostScoreBoard(ScoreBoard scoreBoard)
        {
            _service.Add(scoreBoard);
        }

        // DELETE: api/ScoreBoards/5
        [HttpDelete("{id}")]
        public void DeleteScoreBoard(int id)
        {
            _service.Delete(id);
        }
    }
}
