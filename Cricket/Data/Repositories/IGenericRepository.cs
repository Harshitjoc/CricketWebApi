using Cricket.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Linq.Expressions;

namespace Cricket.Data.Repositories
{
    public interface IGenericRepository<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task<List<T>> Get(Expression<Func<T,bool>> expression);
        Task<T> Update(T entity);
        Task<T> Add(T entity);
        Task<bool> Delete(int id);
    }
}
