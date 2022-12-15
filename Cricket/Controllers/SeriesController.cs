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
    public class SeriesController : ControllerBase
    {
        private readonly ISeriesService _service;
        public SeriesController(ISeriesService service)
        {
            _service = service;
        }

        // GET: api/Series
        [HttpGet]
        public async Task<IEnumerable<Series>> GetSeries()
        {
            return await _service.GetAll();
        }

        // GET: api/Series/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Series>> GetSeries(int id)
        {
            var series = await _service.GetById(id);

            if (series == null)
            {
                return NotFound();
            }

            return series;
        }

        // PUT: api/Series/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async void PutSeries(Series series)
        {
            await _service.Update(series);
        }

        // POST: api/Series
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public void PostSeries(Series series)
        {
            _service.Add(series);
        }

        // DELETE: api/Series/5
        [HttpDelete("{id}")]
        public void DeleteSeries(int id)
        {
            _service.Delete(id);
        }
    }
}
