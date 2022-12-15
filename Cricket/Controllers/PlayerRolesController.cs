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
    public class PlayerRolesController : ControllerBase
    {
        private readonly IPlayerRoleService _service;
        public PlayerRolesController(IPlayerRoleService service)
        {
            _service = service;
        }

        // GET: api/PlayerRoles
        [HttpGet]
        public async Task<IEnumerable<PlayerRole>> GetPlayerRole()
        {
            return await _service.GetAll();
        }

        // GET: api/PlayerRoles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PlayerRole>> GetPlayerRole(int id)
        {
            var playerRole = await _service.GetById(id);

            if (playerRole == null)
            {
                return NotFound();
            }

            return playerRole;
        }

        // PUT: api/PlayerRoles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async void PutPlayerRole(PlayerRole playerRole)
        {
            await _service.Update(playerRole);
        }

        // POST: api/PlayerRoles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public void PostPlayerRole(PlayerRole playerRole)
        {
            _service.Add(playerRole);
        }

        // DELETE: api/PlayerRoles/5
        [HttpDelete("{id}")]
        public void DeletePlayerRole(int id)
        {
            _service.Delete(id);
        }
    }
}
