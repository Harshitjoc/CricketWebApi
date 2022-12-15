using Cricket.Data.Models;

namespace Cricket.Services
{
    public interface IUmpireRoleMapService
    {
        Task<IEnumerable<UmpireRoleMap>> GetAll();
        Task<UmpireRoleMap> GetById(int id);
        Task<UmpireRoleMap> Update(UmpireRoleMap umpireRoleMap);
        Task<UmpireRoleMap> Add(UmpireRoleMap umpireRoleMap);
        Task<bool> Delete(int id);
    }
}
