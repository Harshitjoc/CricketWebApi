using Cricket.Models;

namespace Cricket.Data.Repositories
{
    public class TossRepository : BaseRepository<Toss>, IGenericRepository<Toss>
    {
        private readonly CricketContext _context;
        public TossRepository(CricketContext context)
        {
            _context = context;
        }
    }
}
