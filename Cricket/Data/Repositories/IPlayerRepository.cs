using Cricket.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cricket.Data.Repositories
{
    public interface IPlayerRepository
    {
        Task<IEnumerable<Player>> GetAll();
        Task<Player> GetById(int id);
        Task<Player> Update(Player player);
        Task<Player> Add(Player player);
        void Delete(int id);
    }
}
