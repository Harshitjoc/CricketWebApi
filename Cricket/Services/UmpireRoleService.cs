using Cricket.Data.Models;
using Cricket.Data.Repositories;
using Cricket.Models;

namespace Cricket.Services
{
    public class UmpireRoleService : BaseService<UmpireRole>, IUmpireRoleService
    {
        public UmpireRoleService(IGenericRepository<UmpireRole> repository) : base(repository)
        {
        }
    }
}
