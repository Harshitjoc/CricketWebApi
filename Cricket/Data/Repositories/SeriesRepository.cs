using Cricket.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Cricket.Data.Repositories
{
    public class SeriesRepository : BaseRepository<Series>, IGenericRepository<Series>
    {
        public SeriesRepository(CricketContext context) : base(context)
        {
        }
    }
}
