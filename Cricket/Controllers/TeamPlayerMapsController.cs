using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Cricket.Data.Models;
using Cricket.Services;

namespace Cricket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamPlayerMapsController : ControllerBase
    {
        private readonly ITeamPlayerMapService _service;
        public TeamPlayerMapsController(ITeamPlayerMapService service)
        {
            _service = service;
        }

        // GET: api/TeamPlayerMaps
        [HttpGet]
        public async Task<IEnumerable<TeamPlayerMap>> GetTeamPlayerMap()
        {
            return await _service.GetAll();
        }

        // GET: api/TeamPlayerMaps/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TeamPlayerMap>> GetTeamPlayerMap(int id)
        {
            var teamPlayerMap = await _service.GetById(id);

            if (teamPlayerMap == null)
            {
                return NotFound();
            }

            return teamPlayerMap;
        }

        // PUT: api/TeamPlayerMaps/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<TeamPlayerMap> PutTeamPlayerMap(TeamPlayerMap teamPlayerMap)
        {
            return await _service.Update(teamPlayerMap);
        }

        // POST: api/TeamPlayerMaps
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<TeamPlayerMap> PostTeamPlayerMap(TeamPlayerMap teamPlayerMap)
        {
            return await _service.Add(teamPlayerMap);
        }

        // DELETE: api/TeamPlayerMaps/5
        [HttpDelete("{id}")]
        public async Task<bool> DeleteTeamPlayerMap(int id)
        {
            return await _service.Delete(id);
        }
    }
}
