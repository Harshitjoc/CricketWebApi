using Cricket.Data.Models;

namespace Cricket.Services
{
    public interface IPlayerRoleMapService
    {
        Task<IEnumerable<PlayerRoleMap>> GetAll();
        Task<PlayerRoleMap> GetById(int id);
        Task<PlayerRoleMap> Update(PlayerRoleMap playerRoleMap);
        Task<PlayerRoleMap> Add(PlayerRoleMap playerRoleMap);
        Task<bool> Delete(int id);
    }
}
