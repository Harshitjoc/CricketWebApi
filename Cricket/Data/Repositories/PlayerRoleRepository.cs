using Cricket.Models;

namespace Cricket.Data.Repositories
{
    public class PlayerRoleRepository : BaseRepository<PlayerRole>, IGenericRepository<PlayerRole>
    {
        private readonly CricketContext _context;
        public PlayerRoleRepository(CricketContext context)
        {
            _context = context;
        }
    }
}