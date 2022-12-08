using Cricket.Models;

namespace Cricket.Data.Repositories
{
    public class TeamBRepository : BaseRepository<TeamB>, IGenericRepository<TeamB>
    {
        private readonly CricketContext _context;
        public TeamBRepository(CricketContext context)
        {
            _context = context;
        }
    }
}
