using Cricket.Data.Models;

namespace Cricket.Data.Repositories
{
    public class BowlerScoreBoardRepository : BaseRepository<BowlerScoreBoard>, IGenericRepository<BowlerScoreBoard>
    {
        public BowlerScoreBoardRepository(CricketContext context) : base(context)
        {
        }
    }
}
