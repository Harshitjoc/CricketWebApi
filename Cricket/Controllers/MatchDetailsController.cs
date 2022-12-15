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
using Cricket.Models;
using System.Numerics;

namespace Cricket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchDetailsController : ControllerBase
    {
        private readonly IMatchDetailService _service;
        public MatchDetailsController(IMatchDetailService service)
        {
            _service = service;
        }

        // GET: api/MatchDetails
        [HttpGet]
        public async Task<IEnumerable<MatchDetail>> GetMatchDetail()
        {
            return await _service.GetAll();
        }

        // GET: api/MatchDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MatchDetail>> GetMatchDetail(int id)
        {
            var matchDetail = await _service.GetById(id);

            if (matchDetail == null)
            {
                return NotFound();
            }

            return matchDetail;
        }

        // PUT: api/MatchDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async void PutMatchDetail(MatchDetail matchDetail)
        {
            await _service.Update(matchDetail);
        }

        // POST: api/MatchDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public void PostMatchDetail(MatchDetail matchDetail)
        {
            _service.Add(matchDetail);
        }

        // DELETE: api/MatchDetails/5
        [HttpDelete("{id}")]
        public void DeleteMatchDetail(int id)
        {
            _service.Delete(id);
        }
    }
}
