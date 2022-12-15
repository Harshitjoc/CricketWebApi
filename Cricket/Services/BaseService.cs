using Cricket.Data;
using Cricket.Data.Repositories;
using Cricket.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;

namespace Cricket.Services
{
    public class BaseService<T>
    {
        private readonly IGenericRepository<T> _repository;
        public BaseService(IGenericRepository<T> repository) 
        { 
            _repository = repository;
        }

        public Task<T> Add(T entity)
        {
            var result = _repository.Add(entity);
            return result;
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public Task<T> Get(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAll()
        {
            var result = _repository.GetAll();
            return result;
        }

        public Task<T> GetById(int id)
        {
            var result = _repository.GetById(id);
            return result;
        }

        public Task<T> Update(T entity)
        {
            var result = _repository.Update(entity);
            return result;
        }
    }
}
