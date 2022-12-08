using Cricket.Models;

namespace Cricket.Data.Repositories
{
    public class UmpireRepository : BaseRepository<Umpire>, IGenericRepository<Umpire>
    {
        private readonly CricketContext _context;
        public UmpireRepository(CricketContext context)
        {
            _context = context;
        }
    }
}
