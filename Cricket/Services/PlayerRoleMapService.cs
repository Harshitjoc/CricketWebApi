using Cricket.Data.Models;
using Cricket.Data.Repositories;

namespace Cricket.Services
{
    public class PlayerRoleMapService : BaseService<PlayerRoleMap>, IPlayerRoleMapService
    {
        public PlayerRoleMapService(IGenericRepository<PlayerRoleMap> repository) : base(repository)
        {
        }
    }
}
