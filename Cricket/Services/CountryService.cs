using Cricket.Data.Models;
using Cricket.Data.Repositories;
using Cricket.Models;
using NuGet.Protocol.Core.Types;
using System.Diagnostics.Metrics;
using System.Numerics;

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
           return await Repository.Delete(id);
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

        public Task<CountryModel> Update(CountryModel country)
        {
            throw new NotImplementedException();
        }
    }
}
