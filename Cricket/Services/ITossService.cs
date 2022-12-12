using Cricket.Models;

namespace Cricket.Services
{
    public interface ITossService
    {
        Task<IEnumerable<Toss>> GetAll();
        Task<Toss> GetById(int id);
        Task<Toss> Update(Toss toss);
        Task<Toss> Add(Toss toss);
        void Delete(int id);
    }
}
