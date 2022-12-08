using Cricket.Models;

namespace Cricket.Data.Repositories
{
    public class CountryRepository : BaseRepository<Country>, IGenericRepository<Country>
    {
        private readonly CricketContext _context;
        public CountryRepository(CricketContext context)
        {
            _context = context;
        }
    }
}
