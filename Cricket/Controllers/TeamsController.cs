using Microsoft.AspNetCore.Mvc;
using Cricket.Data.Models;
using Cricket.Services;
using Cricket.Models;

namespace Cricket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly ITeamService _service;
        public TeamsController(ITeamService service)
        {
            _service = service;
        }

        // GET: api/Teams
        [HttpGet]
        public async Task<IEnumerable<TeamModel>> GetTeam()
        {
            return await _service.GetAll();
        }

        //[Route("[action]/{teamId}")]
        //[HttpGet]
        //public async Task<List<Team>> GetAllPlayersCountByTeam(int teamId)
        //{
        //    return await _service.GetAllPlayersCountByTeam(teamId);
        //}

        // GET: api/Teams/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TeamModel>> GetTeam(int id)
        {
            var team = await _service.GetById(id);

            if (team == null)
            {
                return NotFound();
            }

            return team;
        }

        // PUT: api/Teams/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<TeamModel> PutTeam(TeamModel team)
        {
            return await _service.Update(team);
        }

        // POST: api/Teams
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<TeamModel> PostTeam(TeamModel team)
        {
            return await _service.Add(team);
        }

        // DELETE: api/Teams/5
        [HttpDelete("{id}")]
        public async Task<bool> DeleteTeam(int id)
        {
            return await _service.Delete(id);
        }
    }
}
