
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Cricket.Data;
using Cricket.Data.Repositories;
using Cricket.Services;
using Cricket.Data.Models;
using Cricket.Models;

namespace Cricket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly IPlayerService _service;
        public PlayersController(IPlayerService service)
        {
            _service = service;
        }

        // GET: api/Players
        [HttpGet]
        public async Task<IEnumerable<PlayerModel>> GetPlayer()
        {
            return await _service.GetAll();
        }

        [Route("[action]/{id}")]
        [HttpGet]
        public async Task<IEnumerable<PlayerModel>> GetPlayersByCountry(int id)
        {
            return await _service.GetAllPlayersByCountry(id);
        }

        // GET: api/Players/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PlayerModel>> GetPlayer(int id)
        {
            var player = await _service.GetById(id);

            if (player == null)
            {
                return NotFound();
            }

            return player;
        }

        // PUT: api/Players/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<PlayerModel> Put(PlayerModel player)
        {
            return await _service.Update(player);
        }

        // POST: api/Players
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<PlayerModel> PostPlayer(PlayerModel player)
        {
            return await _service.Add(player);
        }

        // DELETE: api/Players/5
        [HttpDelete("{id}")]
        public async Task<bool> DeletePlayer(int id)
        {
            return await _service.Delete(id);
        }
    }
}
