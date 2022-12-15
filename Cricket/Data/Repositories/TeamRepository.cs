using Cricket.Data.Models;
using Cricket.Models;
using Microsoft.EntityFrameworkCore;

namespace Cricket.Data.Repositories
{
    public class TeamRepository : BaseRepository<Team>, IGenericRepository<Team>
    {
        public TeamRepository(CricketContext context) : base(context)
        {
        }
        
    }
}
