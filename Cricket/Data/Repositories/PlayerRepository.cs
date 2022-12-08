using Cricket.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cricket.Data.Repositories
{
    public class PlayerRepository : BaseRepository<Player>, IGenericRepository<Player>
    {
        private readonly CricketContext _context;
        public PlayerRepository(CricketContext context)
        {
            _context = context;
        }


    }
}
