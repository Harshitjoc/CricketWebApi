using Cricket.Data.Repositories;
using Cricket.Models;

namespace Cricket.Services
{
    public class CountryService : ICountryService
    {
        private readonly CountryRepository _countryRepository;
        public CountryService(CountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public Task<Country> Add(Country entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Country>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Country> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Country> Update(Country entity)
        {
            throw new NotImplementedException();
        }
    }
}
