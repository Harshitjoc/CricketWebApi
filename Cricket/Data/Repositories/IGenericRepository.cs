using Cricket.Models;

namespace Cricket.Data.Repositories
{
    public interface IGenericRepository<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task<T> Update(T entity);
        Task<T> Add(T entity);
        void Delete(int id);
    }
}
