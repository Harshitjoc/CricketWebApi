using Microsoft.AspNetCore.Mvc;
using Cricket.Data.Models;
using Cricket.Services;
using Cricket.Models;

namespace Cricket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private readonly ICountryService _service;
        public CountriesController(ICountryService service)
        {
            _service = service;
        }

        // GET: api/Countries
        [HttpGet]
        public async Task<IEnumerable<CountryModel>> GetCountry()
        {
            return await _service.GetAll();
        }

        // GET: api/Countries/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CountryModel>> GetCountry(int id)
        {
            var CountryModel = await _service.GetById(id);

            if (CountryModel == null)
            {
                return NotFound();
            }

            return CountryModel;
        }

        // PUT: api/Countries/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async void PutCountry(CountryModel country)
        {
            await _service.Update(country);
        }

        // POST: api/Countries
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public void PostCountry(CountryModel country)
        {
            _service.Add(country);
        }

        // DELETE: api/Countries/5
        [HttpDelete("{id}")]
        public void DeleteCountry(int id)
        {
            _service.Delete(id);
        }
    }
}
