using Cricket.Models;

namespace Cricket.Data.Repositories
{
    public interface ICountryRepository
    {
        Task<IEnumerable<Country>> GetAll();
        Task<Country> GetById(int id);
        bool Update(Country country);
        Task<Country> Add(Country country);
        bool Delete(int id);
    }
}
