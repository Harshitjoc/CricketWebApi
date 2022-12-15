using Cricket.Data.Models;

namespace Cricket.Data.Repositories
{
    public class BatsmanScoreBoardRepository : BaseRepository<BatsmanScoreBoard>, IGenericRepository<BatsmanScoreBoard>
    {
        public BatsmanScoreBoardRepository(CricketContext context) : base(context)
        {
        }
    }
}
