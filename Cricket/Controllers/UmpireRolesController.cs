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
    public class UmpireRolesController : ControllerBase
    {
        private readonly IUmpireRoleService _service;
        public UmpireRolesController(IUmpireRoleService service)
        {
            _service = service;
        }

        // GET: api/UmpireRoles
        [HttpGet]
        public async Task<IEnumerable<UmpireRole>> GetUmpireRole()
        {
            return await _service.GetAll();
        }

        // GET: api/UmpireRoles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UmpireRole>> GetUmpireRole(int id)
        {
            var umpireRole = await _service.GetById(id);

            if (umpireRole == null)
            {
                return NotFound();
            }

            return umpireRole;
        }

        // PUT: api/UmpireRoles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async void PutUmpireRole(UmpireRole umpireRole)
        {
            await _service.Update(umpireRole);
        }

        // POST: api/UmpireRoles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public void PostUmpireRole(UmpireRole umpireRole)
        {
            _service.Add(umpireRole);
        }

        // DELETE: api/UmpireRoles/5
        [HttpDelete("{id}")]
        public void DeleteUmpireRole(int id)
        {
            _service.Delete(id);
        }
    }
}
