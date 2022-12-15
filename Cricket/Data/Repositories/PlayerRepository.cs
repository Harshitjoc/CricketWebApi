using Cricket.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cricket.Data.Repositories
{
    public class PlayerRepository : BaseRepository<Player>, IGenericRepository<Player>
    {
        public PlayerRepository(CricketContext context) : base(context)
        {
        }
        public override async Task<IEnumerable<Player>> GetAll()
        {
            return await _context.Set<Player>().Include("Country").ToListAsync();
        }

    }
}
