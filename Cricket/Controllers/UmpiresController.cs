using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Cricket.Data;
using Cricket.Data.Models;
using Cricket.Services;

namespace Cricket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UmpiresController : ControllerBase
    {
        private readonly IUmpireService _service;
        public UmpiresController(IUmpireService service)
        {
            _service = service;
        }

        // GET: api/Umpires
        [HttpGet]
        public async Task<IEnumerable<Umpire>> GetUmpire()
        {
            return await _service.GetAll();
        }

        // GET: api/Umpires/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Umpire>> GetUmpire(int id)
        {
            var umpire = await _service.GetById(id);

            if (umpire == null)
            {
                return NotFound();
            }

            return umpire;
        }

        // PUT: api/Umpires/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async void PutUmpire(Umpire umpire)
        {
            await _service.Update(umpire);
        }

        // POST: api/Umpires
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public void PostUmpire(Umpire umpire)
        {
            _service.Add(umpire);
        }

        // DELETE: api/Umpires/5
        [HttpDelete("{id}")]
        public void DeleteUmpire(int id)
        {
            _service.Delete(id);
        }
    }
}
