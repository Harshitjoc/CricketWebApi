using Cricket.Data.Models;
using Cricket.Data.Repositories;

namespace Cricket.Services
{
    public class PlayerRoleService : BaseService<PlayerRole>, IPlayerRoleService
    {
        public PlayerRoleService(IGenericRepository<PlayerRole> repository) : base(repository)
        {
        }
    }
}
