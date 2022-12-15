using Cricket.Data;
using Cricket.Data.Models;
using Cricket.Data.Repositories;
using Cricket.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cricket.Services
{
    public class PlayerService : IPlayerService
    {
        public PlayerService(IGenericRepository<Player> repository, IGenericRepository<Country> countryRepository)
        {
            Repository = repository;
            CountryRepository = countryRepository;
        }

        private IGenericRepository<Player> Repository { get; }
        private IGenericRepository<Country> CountryRepository { get; }

        public async Task<PlayerModel> Add(PlayerModel player)
        {
            var pl1 = new Player
            {
                FirstName = player.FirstName,
                LastName = player.LastName,
                Age = player.Age,
                
            };
            var country =(await CountryRepository.Get(c => c.Name.Equals(player.Country))).SingleOrDefault();
            if (country == null)
            {
                throw new Exception("Country does not exist");
            }
            else
            {
                pl1.CountryId = country.Id;
            }
            await Repository.Add(pl1);
            player.Id= pl1.Id;
            return player;
        }

        public Task<bool> Delete(int id)
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
