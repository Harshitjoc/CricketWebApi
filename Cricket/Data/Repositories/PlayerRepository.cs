using Cricket.Models;

namespace Cricket.Data.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        public Task<Player> Add(Player player)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
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

        public bool Update(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
