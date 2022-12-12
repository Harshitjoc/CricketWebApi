using Cricket.Data.Repositories;
using Cricket.Models;

namespace Cricket.Services
{
    public class SeriesService : ISeriesService
    {
        private readonly SeriesRepository _seriesRepository;
        public SeriesService(SeriesRepository seriesRepository)
        {
            _seriesRepository = seriesRepository;
        }
        public Task<Series> Add(Series series)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Series>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Series> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Series> Update(Series series)
        {
            throw new NotImplementedException();
        }
    }
}
