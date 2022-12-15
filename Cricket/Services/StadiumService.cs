using Cricket.Data.Models;
using Cricket.Data.Repositories;

namespace Cricket.Services
{
    public class StadiumService : BaseService<Stadium>, IStadiumService
    {
        public StadiumService(IGenericRepository<Stadium> repository) : base(repository)
        {
        }
    }
}
