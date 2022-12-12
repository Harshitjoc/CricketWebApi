using Cricket.Models;

namespace Cricket.Services
{
    public interface IPlayerService
    {
        Task<IEnumerable<Player>> GetAll();
        Task<Player> GetById(int id);
        Task<Player> Update(Player player);
        Task<Player> Add(Player player);
        void Delete(int id);
    }
}
