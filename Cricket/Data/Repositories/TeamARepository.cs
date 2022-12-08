using Cricket.Models;

namespace Cricket.Data.Repositories
{
    public class TeamARepository : BaseRepository<TeamA>, IGenericRepository<TeamA>
    {
        private readonly CricketContext _context;
        public TeamARepository(CricketContext context)
        {
            _context = context;
        }
    }
}
