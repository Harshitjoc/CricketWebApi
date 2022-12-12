using Cricket.Data;
using Cricket.Data.Repositories;
using Cricket.Models;
using Microsoft.EntityFrameworkCore;

namespace Cricket.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly PlayerRepository _playerRepository;
        public PlayerService(PlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        public Task<Player> Add(Player player)
        {
            return _playerRepository.Add(player);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Player>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Player> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Player> Update(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
