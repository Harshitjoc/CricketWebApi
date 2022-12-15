using Cricket.Data.Models;

namespace Cricket.Data.Repositories
{
    public class UmpireRoleMapRepository : BaseRepository<UmpireRoleMap>, IGenericRepository<UmpireRoleMap>
    {
        public UmpireRoleMapRepository(CricketContext context) : base(context)
        {
        }
    }
}
