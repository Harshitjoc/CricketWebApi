using Cricket.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Cricket.Data.Repositories
{
    public class UmpireRoleRepository : BaseRepository<UmpireRole>, IGenericRepository<UmpireRole>
    {
        public UmpireRoleRepository(CricketContext context) : base(context)
        {
        }
    }
}
