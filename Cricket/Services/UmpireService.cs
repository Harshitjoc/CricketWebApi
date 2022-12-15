using Cricket.Data.Models;
using Cricket.Data.Repositories;

namespace Cricket.Services
{
    public class UmpireService : BaseService<Umpire>, IUmpireService
    {
        public UmpireService(IGenericRepository<Umpire> repository) : base(repository)
        {
        }
    }
}
