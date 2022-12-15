using Cricket.Data.Models;

namespace Cricket.Services
{
    public interface IBowlerScoreBoardService
    {
        Task<IEnumerable<BowlerScoreBoard>> GetAll();
        Task<BowlerScoreBoard> GetById(int id);
        Task<BowlerScoreBoard> Update(BowlerScoreBoard bowlerScoreBoard);
        Task<BowlerScoreBoard> Add(BowlerScoreBoard bowlerScoreBoard);
        Task<bool> Delete(int id);
    }
}
