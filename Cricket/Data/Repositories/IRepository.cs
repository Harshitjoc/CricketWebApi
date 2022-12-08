using Cricket.Models;

namespace Cricket.Data.Repositories
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        bool Update(T entity);
        Task<T> Add(T entity);
        bool Delete(int id);
    }
}
