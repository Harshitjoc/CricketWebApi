using Cricket.Data.Models;

namespace Cricket.Data.Repositories
{
    public class TeamPlayerMapRepository : BaseRepository<TeamPlayerMap>, IGenericRepository<TeamPlayerMap>
    {
        public TeamPlayerMapRepository(CricketContext context) : base(context)
        {
        }
    }
}
