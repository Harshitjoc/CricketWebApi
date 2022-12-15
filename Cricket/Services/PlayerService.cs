using Cricket.Data;
using Cricket.Data.Models;
using Cricket.Data.Repositories;
using Cricket.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cricket.Services
{
    public class PlayerService : IPlayerService
    {
        public PlayerService(IGenericRepository<Player> repository)
        {
            Repository = repository;
        }

        private IGenericRepository<Player> Repository { get; }

        public Task<PlayerModel> Add(PlayerModel player)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<PlayerModel>> GetAll()
        {
            List<PlayerModel> players = new List<PlayerModel>();
            var result = await Repository.GetAll();
            foreach (var player in result)
            {
                players.Add(new PlayerModel
                {
                    Id = player.Id,
                    Age = player.Age,
                    FirstName = player.FirstName,
                    LastName = player.LastName,
                    Country = player.Country.Name
                });
            }
            
            return players;
        }

        public async Task<List<PlayerModel>> GetAllPlayersByCountry(int countryId)
        {
            List<PlayerModel> players = new List<PlayerModel>();
            var result = await Repository.Get(p => p.Country.Id == countryId);
            foreach (var player in result)
            {
                players.Add(new PlayerModel
                {
                    Id = player.Id,
                    Age = player.Age,
                    FirstName = player.FirstName,
                    LastName = player.LastName,
                    Country = player.Country.Name
                });
            }

            return players;
        }

        public Task<PlayerModel> GetById(int id)
        {
            throw new NotImplementedException();
            
        }

        public Task<PlayerModel> Update(PlayerModel player)
        {
            throw new NotImplementedException();
        }
    }
}
