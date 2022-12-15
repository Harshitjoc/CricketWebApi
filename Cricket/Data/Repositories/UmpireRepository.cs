using Cricket.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Cricket.Data.Repositories
{
    public class UmpireRepository : BaseRepository<Umpire>, IGenericRepository<Umpire>
    {
        public UmpireRepository(CricketContext context) : base(context)
        {
        }
    }
}
