using Microsoft.AspNetCore.Mvc;
using Cricket.Services;
using Cricket.Data.Models;

namespace Cricket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BatsmanScoreBoardsController : ControllerBase
    {
        private readonly IBatsmanScoreBoardService _service;
        public BatsmanScoreBoardsController(IBatsmanScoreBoardService service)
        {
            _service = service;
        }

        // GET: api/BatsmanScoreBoards
        [HttpGet]
        public async Task<IEnumerable<BatsmanScoreBoard>> GetBatsmanScoreBoard()
        {
            return await _service.GetAll();
        }

        // GET: api/BatsmanScoreBoards/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BatsmanScoreBoard>> GetBatsmanScoreBoard(int id)
        {
            var batsmanScoreBoard = await _service.GetById(id);

            if (batsmanScoreBoard == null)
            {
                return NotFound();
            }

            return batsmanScoreBoard;
        }

        // PUT: api/BatsmanScoreBoards/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async void PutBatsmanScoreBoard(BatsmanScoreBoard batsmanScoreBoard)
        {
                await _service.Update(batsmanScoreBoard);
        }

        // POST: api/BatsmanScoreBoards
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public void PostBatsmanScoreBoard(BatsmanScoreBoard batsmanScoreBoard)
        {
            _service.Add(batsmanScoreBoard);
        }

        // DELETE: api/BatsmanScoreBoards/5
        [HttpDelete("{id}")]
        public void DeleteBatsmanScoreBoard(int id)
        {
            _service.Delete(id);
        }
    }
}
