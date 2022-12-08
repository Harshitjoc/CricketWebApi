﻿using Cricket.Models;

namespace Cricket.Data.Repositories
{
    public interface ICountryRepository
    {
        Task<IEnumerable<Country>> GetAll();
        Task<Country> GetById(int id);
        Task<Country> Update(Country country);
        Task<Country> Add(Country country);
        void Delete(int id);
    }
}
