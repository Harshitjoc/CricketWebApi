using Cricket.Models;

namespace Cricket.Data.Repositories
{
    public class UmpireRoleRepository : BaseRepository<UmpireRole>, IGenericRepository<UmpireRole>
    {
        private readonly CricketContext _context;
        public UmpireRoleRepository(CricketContext context)
        {
            _context = context;
        }
    }
}
