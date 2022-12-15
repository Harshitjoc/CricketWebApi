using Cricket.Data.Models;
using Cricket.Models;
using Microsoft.EntityFrameworkCore;

namespace Cricket.Data.Repositories
{
    public class TeamRepository : BaseRepository<Team>, IGenericRepository<Team>
    {
        public TeamRepository(CricketContext context) : base(context)
        {
        }
        public override async Task<IEnumerable<Team>> GetAll()
        {
            return await _context.Team.Include(t => t.TeamPlayerMaps).ToListAsync();
        }
    }
}
