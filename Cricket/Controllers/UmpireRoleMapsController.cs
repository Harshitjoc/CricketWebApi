using Microsoft.AspNetCore.Mvc;
using Cricket.Data.Models;
using Cricket.Services;

namespace Cricket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UmpireRoleMapsController : ControllerBase
    {
        private readonly IUmpireRoleMapService _service;
        public UmpireRoleMapsController(IUmpireRoleMapService service)
        {
            _service = service;
        }

        // GET: api/UmpireRoleMaps
        [HttpGet]
        public async Task<IEnumerable<UmpireRoleMap>> GetUmpireRoleMap()
        {
            return await _service.GetAll();
        }

        // GET: api/UmpireRoleMaps/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UmpireRoleMap>> GetUmpireRoleMap(int id)
        {
            var umpireRoleMap = await _service.GetById(id);

            if (umpireRoleMap == null)
            {
                return NotFound();
            }

            return umpireRoleMap;
        }

        // PUT: api/UmpireRoleMaps/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async void PutUmpireRoleMap(UmpireRoleMap umpireRoleMap)
        {
            await _service.Update(umpireRoleMap);
        }

        // POST: api/UmpireRoleMaps
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public void PostUmpireRoleMap(UmpireRoleMap umpireRoleMap)
        {
            _service.Add(umpireRoleMap);
        }

        // DELETE: api/UmpireRoleMaps/5
        [HttpDelete("{id}")]
        public void DeleteUmpireRoleMap(int id)
        {
            _service.Delete(id);
        }
    }
}
