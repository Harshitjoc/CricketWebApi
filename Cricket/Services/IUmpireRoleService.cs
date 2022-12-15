using Cricket.Data.Models;

namespace Cricket.Services
{
    public interface IUmpireRoleService
    {
        Task<IEnumerable<UmpireRole>> GetAll();
        Task<UmpireRole> GetById(int id);
        Task<UmpireRole> Update(UmpireRole umpireRole);
        Task<UmpireRole> Add(UmpireRole umpireRole);
        void Delete(int id);
    }
}
