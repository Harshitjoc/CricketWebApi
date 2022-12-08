using Cricket.Models;

namespace Cricket.Data.Repositories
{
    public interface IUmpireRepository
    {
        Task<IEnumerable<Umpire>> GetAll();
        Task<Umpire> GetById(int id);
        bool Update(Umpire umpire);
        Task<Umpire> Add(Umpire umpire);
        bool Delete(int id);
    }
}
