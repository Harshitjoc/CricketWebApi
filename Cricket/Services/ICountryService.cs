using Cricket.Data.Models;
using Cricket.Models;

namespace Cricket.Services
{
    public interface ICountryService
    {
        Task<IEnumerable<CountryModel>> GetAll();
        Task<CountryModel> GetById(int id);
        Task<CountryModel> Update(CountryModel country);
        Task<CountryModel> Add(CountryModel country);
        Task<bool> Delete(int id);
    }
}
