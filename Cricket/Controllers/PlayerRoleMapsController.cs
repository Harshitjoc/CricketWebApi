using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Cricket.Data;
using Cricket.Data.Models;
using Cricket.Services;

namespace Cricket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerRoleMapsController : ControllerBase
    {
        private readonly IPlayerRoleMapService _service;
        public PlayerRoleMapsController(IPlayerRoleMapService service)
        {
            _service = service;
        }

        // GET: api/PlayerRoleMaps
        [HttpGet]
        public async Task<IEnumerable<PlayerRoleMap>> GetPlayerRoleMap()
        {
            return await _service.GetAll();
        }

        // GET: api/PlayerRoleMaps/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PlayerRoleMap>> GetPlayerRoleMap(int id)
        {
            var playerRoleMap = await _service.GetById(id);

            if (playerRoleMap == null)
            {
                return NotFound();
            }

            return playerRoleMap;
        }

        // PUT: api/PlayerRoleMaps/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async void PutPlayerRoleMap(PlayerRoleMap playerRoleMap)
        {
            await _service.Update(playerRoleMap);
        }

        // POST: api/PlayerRoleMaps
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public void PostPlayerRoleMap(PlayerRoleMap playerRoleMap)
        {
            _service.Add(playerRoleMap);
        }

        // DELETE: api/PlayerRoleMaps/5
        [HttpDelete("{id}")]
        public void DeletePlayerRoleMap(int id)
        {
            _service.Delete(id);
        }
    }
}
