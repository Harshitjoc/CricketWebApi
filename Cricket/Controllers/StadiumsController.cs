using Microsoft.AspNetCore.Mvc;
using Cricket.Data.Models;
using Cricket.Services;

namespace Cricket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StadiumsController : ControllerBase
    {
        private readonly IStadiumService _service;
        public StadiumsController(IStadiumService service)
        {
            _service = service;
        }

        // GET: api/Stadia
        [HttpGet]
        public async Task<IEnumerable<Stadium>> GetStadium()
        {
            return await _service.GetAll();
        }

        // GET: api/Stadia/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Stadium>> GetStadium(int id)
        {
            var stadium = await _service.GetById(id);

            if (stadium == null)
            {
                return NotFound();
            }

            return stadium;
        }

        // PUT: api/Stadia/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async void PutStadium(Stadium stadium)
        {
            await _service.Update(stadium);
        }

        // POST: api/Stadia
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public void PostStadium(Stadium stadium)
        {
            _service.Add(stadium);
        }

        // DELETE: api/Stadia/5
        [HttpDelete("{id}")]
        public void DeleteStadium(int id)
        {
            _service.Delete(id);
        }
    }
}
