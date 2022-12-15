using Cricket.Data.Models;

namespace Cricket.Services
{
    public interface ISeriesService
    {
        Task<IEnumerable<Series>> GetAll();
        Task<Series> GetById(int id);
        Task<Series> Update(Series series);
        Task<Series> Add(Series series);
        Task<bool> Delete(int id);
    }
}
