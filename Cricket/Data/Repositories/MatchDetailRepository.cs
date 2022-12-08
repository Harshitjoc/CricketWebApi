using Cricket.Models;

namespace Cricket.Data.Repositories
{
    public class MatchDetailRepository : BaseRepository<MatchDetail>, IGenericRepository<MatchDetail>
    {
        private readonly CricketContext _context;
        public MatchDetailRepository(CricketContext context)
        {
            _context = context;
        }
    }
}
