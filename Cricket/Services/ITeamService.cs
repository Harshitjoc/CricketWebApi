using Cricket.Models;

namespace Cricket.Services
{
    public interface ITeamService
    {
        Task<IEnumerable<TeamModel>> GetAll();
        //Task<List<Team>> GetAllPlayersCountByTeam(int teamId);
        Task<TeamModel> GetById(int id);
        Task<TeamModel> Update(TeamModel team);
        Task<TeamModel> Add(TeamModel team);
        Task<bool> Delete(int id);
        
    }
}
