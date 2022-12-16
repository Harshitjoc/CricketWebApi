using Cricket.Data.Models;
using Cricket.Data.Repositories;
using Cricket.Models;

namespace Cricket.Services
{
    public class CountryService : ICountryService
    {
        public CountryService(IGenericRepository<Country> repository)
        {
            Repository = repository;
        }
        private IGenericRepository<Country> Repository { get; }

        public async Task<CountryModel> Add(CountryModel country)
        {
            var Country = new Country()
            {
                Name = country.Name
            };
            var result = await Repository.Add(Country);
            country.Id = result.Id;
            return country;
        }

        public async Task<bool> Delete(int id)
        {
            var Country = await Repository.Get(c=> c.Id == id);
            var result = await Repository.Delete(id);
            return result;
        }

        public async Task<IEnumerable<CountryModel>> GetAll()
        {
            List<CountryModel> countries = new List<CountryModel>();
            var result = await Repository.GetAll();
            foreach (var country in result)
            {
                countries.Add(new CountryModel
                {
                    Id = country.Id,
                    Name= country.Name
                });
            }

            return countries;
        }

        public Task<CountryModel> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<CountryModel> Update(CountryModel country)
        {
            throw new NotImplementedException();
        }
    }
}
