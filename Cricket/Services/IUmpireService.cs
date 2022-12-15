using Cricket.Data.Models;

namespace Cricket.Services
{
    public interface IUmpireService
    {
        Task<IEnumerable<Umpire>> GetAll();
        Task<Umpire> GetById(int id);
        Task<Umpire> Update(Umpire umpire);
        Task<Umpire> Add(Umpire umpire);
        Task<bool> Delete(int id);
    }
}
