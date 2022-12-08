using Cricket.Models;

namespace Cricket.Data.Repositories
{
    public class SeriesRepository : BaseRepository<Series>, IGenericRepository<Series>
    {
        private readonly CricketContext _context;
        public SeriesRepository(CricketContext context)
        {
            _context = context;
        }
    }
}
