using Cricket.Data.Models;

namespace Cricket.Services
{
    public interface IPlayerRoleService
    {
        Task<IEnumerable<PlayerRole>> GetAll();
        Task<PlayerRole> GetById(int id);
        Task<PlayerRole> Update(PlayerRole playerRole);
        Task<PlayerRole> Add(PlayerRole playerRole);
        Task<bool> Delete(int id);
    }
}
