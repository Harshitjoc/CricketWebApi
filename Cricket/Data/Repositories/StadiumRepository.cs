using Cricket.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Cricket.Data.Repositories
{
    public class StadiumRepository : BaseRepository<Stadium>, IGenericRepository<Stadium>
    {
        public StadiumRepository(CricketContext context) : base(context)
        {
        }
    }
}
