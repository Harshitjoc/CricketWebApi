using Cricket.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Cricket.Data.Repositories
{
    public class MatchDetailRepository : BaseRepository<MatchDetail>, IGenericRepository<MatchDetail>
    {
        public MatchDetailRepository(CricketContext context) : base(context)
        {
        }
    }
}
