using Cricket.Data.Models;
using Cricket.Data.Repositories;

namespace Cricket.Services
{
    public class MatchDetailService : BaseService<MatchDetail>, IMatchDetailService
    {
        public MatchDetailService(IGenericRepository<MatchDetail> repository) : base(repository)
        {
        }
    }
}
