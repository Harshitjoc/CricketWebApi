using Cricket.Data.Models;

namespace Cricket.Data.Repositories
{
    public class PlayerRoleMapRepository : BaseRepository<PlayerRoleMap>, IGenericRepository<PlayerRoleMap>
    {
        public PlayerRoleMapRepository(CricketContext context) : base(context)
        {
        }
    }
}
