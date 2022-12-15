using Cricket.Data.Models;
using Cricket.Data.Repositories;

namespace Cricket.Services
{
    public class UmpireRoleMapService : BaseService<UmpireRoleMap>, IUmpireRoleMapService
    {
        public UmpireRoleMapService(IGenericRepository<UmpireRoleMap> repository) : base(repository)
        {
        }
    }
}
