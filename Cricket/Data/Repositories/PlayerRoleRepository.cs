using Cricket.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Cricket.Data.Repositories
{
    public class PlayerRoleRepository : BaseRepository<PlayerRole>, IGenericRepository<PlayerRole>
    {
        public PlayerRoleRepository(CricketContext context) : base(context)
        {
        }
    }
}