using Cricket.Models;

namespace Cricket.Services
{
    public interface IStadiumService
    {
        Task<IEnumerable<Stadium>> GetAll();
        Task<Stadium> GetById(int id);
        Task<Stadium> Update(Stadium stadium);
        Task<Stadium> Add(Stadium stadium);
        void Delete(int id);
    }
}
