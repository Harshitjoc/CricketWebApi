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
        public TeamService(IGenericRepository<Team> repository)
        {
            Repository = repository;
        }

        private IGenericRepository<Team> Repository { get; }
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
            List<TeamPlayerMap> teamPlayerMaps= new List<TeamPlayerMap>();
            var count = teamPlayerMaps.Where(x=> x.IsEnabled == true && x.TeamId == 1).Count();

            foreach (var team in result)
            {
                
                teams.Add(new TeamModel
                {
                    Id = team.Id,
                    Name = team.Name,
                    PlayerCount = count
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
