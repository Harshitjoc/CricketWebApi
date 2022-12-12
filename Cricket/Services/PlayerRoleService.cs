using Cricket.Data.Repositories;
using Cricket.Models;

namespace Cricket.Services
{
    public class PlayerRoleService : IPlayerRoleService
    {
        private readonly PlayerRoleRepository _playerRoleRepository;
        public PlayerRoleService(PlayerRoleRepository playerRoleRepository)
        {
            _playerRoleRepository = playerRoleRepository;
        }

        public Task<PlayerRole> Add(PlayerRole playerRole)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PlayerRole>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<PlayerRole> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<PlayerRole> Update(PlayerRole playerRole)
        {
            throw new NotImplementedException();
        }
    }
}
