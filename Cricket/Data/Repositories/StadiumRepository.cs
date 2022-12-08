using Cricket.Models;

namespace Cricket.Data.Repositories
{
    public class StadiumRepository : BaseRepository<Stadium>, IGenericRepository<Stadium>
    {
        private readonly CricketContext _context;
        public StadiumRepository(CricketContext context)
        {
            _context = context;
        }
    }
}
