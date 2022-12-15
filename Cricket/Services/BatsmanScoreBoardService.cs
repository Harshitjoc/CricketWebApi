using Cricket.Data.Models;
using Cricket.Data.Repositories;

namespace Cricket.Services
{
    public class BatsmanScoreBoardService : BaseService<BatsmanScoreBoard>, IBatsmanScoreBoardService
    {
        public BatsmanScoreBoardService(IGenericRepository<BatsmanScoreBoard> repository) : base(repository)
        {
        }
    }
}
