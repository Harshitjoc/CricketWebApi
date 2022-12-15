using Cricket.Data.Models;
using Cricket.Data.Repositories;

namespace Cricket.Services
{
    public class SeriesService : BaseService<Series>, ISeriesService
    {
        public SeriesService(IGenericRepository<Series> repository) : base(repository)
        {
        }
    }
}
