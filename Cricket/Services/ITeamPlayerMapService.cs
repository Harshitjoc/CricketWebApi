using Cricket.Data.Models;

namespace Cricket.Services
{
    public interface ITeamPlayerMapService
    {
        Task<IEnumerable<TeamPlayerMap>> GetAll();
        Task<TeamPlayerMap> GetById(int id);
        Task<TeamPlayerMap> Update(TeamPlayerMap teamPlayerMap);
        Task<TeamPlayerMap> Add(TeamPlayerMap teamPlayerMap);
        void Delete(int id);
    }
}
