using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Cricket.Data;
using Cricket.Services;
using System.Numerics;
using Cricket.Data.Models;

namespace Cricket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BowlerScoreBoardsController : ControllerBase
    {
        private readonly IBowlerScoreBoardService _service;
        public BowlerScoreBoardsController(IBowlerScoreBoardService service)
        {
            _service = service;
        }

        // GET: api/BowlerScoreBoards
        [HttpGet]
        public async Task<IEnumerable<BowlerScoreBoard>> GetBowlerScoreBoard()
        {
            return await _service.GetAll();
        }

        // GET: api/BowlerScoreBoards/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BowlerScoreBoard>> GetBowlerScoreBoard(int id)
        {
            var bowlerScoreBoard = await _service.GetById(id);

            if (bowlerScoreBoard == null)
            {
                return NotFound();
            }

            return bowlerScoreBoard;
        }

        // PUT: api/BowlerScoreBoards/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async void PutBowlerScoreBoard( BowlerScoreBoard bowlerScoreBoard )
        {
            await _service.Update(bowlerScoreBoard);
        }

        // POST: api/BowlerScoreBoards
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public void PostBowlerScoreBoard(BowlerScoreBoard bowlerScoreBoard)
        {
            _service.Add(bowlerScoreBoard);
        }

        // DELETE: api/BowlerScoreBoards/5
        [HttpDelete("{id}")]
        public void DeleteBowlerScoreBoard(int id)
        {
            _service.Delete(id);
        }
    }
}
