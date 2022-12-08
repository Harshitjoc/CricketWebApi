using Cricket.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cricket.Data.Repositories
{
    public interface IPlayerRepository
    {
        Task<IEnumerable<Player>> GetAll();
        Task<Player> GetById(int id);
        bool Update(Player player);
        Task<Player> Add(Player player);
        bool Delete(int id);
    }
}
