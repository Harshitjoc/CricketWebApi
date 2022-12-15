using Cricket.Data.Models;
using Cricket.Data.Repositories;

namespace Cricket.Services
{
    public class TeamPlayerMapService : BaseService<TeamPlayerMap>, ITeamPlayerMapService
    {
        public TeamPlayerMapService(IGenericRepository<TeamPlayerMap> repository) : base(repository)
        {
        }
    }
}
