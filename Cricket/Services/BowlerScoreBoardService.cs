using Cricket.Data.Models;
using Cricket.Data.Repositories;

namespace Cricket.Services
{
    public class BowlerScoreBoardService : BaseService<BowlerScoreBoard>, IBowlerScoreBoardService
    {
        public BowlerScoreBoardService(IGenericRepository<BowlerScoreBoard> repository) : base(repository)
        {
        }
    }
}
