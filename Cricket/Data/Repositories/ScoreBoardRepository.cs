using Cricket.Data.Models;

namespace Cricket.Data.Repositories
{
    public class ScoreBoardRepository : BaseRepository<ScoreBoard>, IGenericRepository<ScoreBoard>
    {
        public ScoreBoardRepository(CricketContext context) : base(context)
        {
        }
    }
}
