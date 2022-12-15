using Cricket.Data;
using Cricket.Data.Models;
using Cricket.Data.Repositories;
using Cricket.Models;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;

namespace Cricket.Services
{
    public class TeamService : ITeamService
    {
        public TeamService(IGenericRepository<Team> repository, IGenericRepository<TeamPlayerMap> teamPlayerMapRepository)
        {
            Repository = repository;
            TeamPlayerMapRepository = teamPlayerMapRepository;
        }

        private IGenericRepository<Team> Repository { get; }
        public IGenericRepository<TeamPlayerMap> TeamPlayerMapRepository { get; }

        public async Task<TeamModel> Add(TeamModel team)
        {
            Team team1= new Team();
            team1.Name = team.Name;
            var result = await Repository.Add(team1);
            team.Id = result.Id;
            return team;
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TeamModel>> GetAll()
        {
            List<TeamModel> teams = new List<TeamModel>();
            var result = await Repository.GetAll();
           

            foreach (var team in result)
            {
                teams.Add(new TeamModel
                {
                    Id = team.Id,
                    Name = team.Name,
                    PlayerCount = team.TeamPlayerMaps.Count()
                });
            }
            
            return teams;
        }

        public Task<TeamModel> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TeamModel> Update(TeamModel team)
        {
            throw new NotImplementedException();
        }
    }
}
