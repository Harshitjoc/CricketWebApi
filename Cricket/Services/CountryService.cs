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

        public async Task<List<CountryModel>> GetById(int id)
        {
            var result = await Repository.GetById(id);
            List<CountryModel> countries = new List<CountryModel>();
            if (result != null)
            {
                countries.Add(new CountryModel
                {
                    Id = result.Id,
                    Name = result.Name
                });
            }

            return countries;
        }

        public async Task<CountryModel> Update(CountryModel country)
        {
            var Country = new Country
            {
                Id = country.Id,
                Name = country.Name
            };
            await Repository.Update(Country);
            country.Id = Country.Id;
            return country;
        }
    }
}
