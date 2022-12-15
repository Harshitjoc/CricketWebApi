using Cricket.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Cricket.Data.Repositories
{
    public class CountryRepository : BaseRepository<Country>, IGenericRepository<Country>
    {
        public CountryRepository(CricketContext context) : base(context)
        {
        }
    }
}
