using Cricket.Data.Models;
using Cricket.Data.Repositories;

namespace Cricket.Services
{
    public class ScoreBoardService : BaseService<ScoreBoard>, IScoreBoardService
    {
        public ScoreBoardService(IGenericRepository<ScoreBoard> repository) : base(repository)
        {
        }
    }
}
