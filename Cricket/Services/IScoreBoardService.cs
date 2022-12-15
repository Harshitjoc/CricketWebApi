using Cricket.Data.Models;

namespace Cricket.Services
{
    public interface IScoreBoardService
    {
        Task<IEnumerable<ScoreBoard>> GetAll();
        Task<ScoreBoard> GetById(int id);
        Task<ScoreBoard> Update(ScoreBoard scoreBoard);
        Task<ScoreBoard> Add(ScoreBoard scoreBoard);
        void Delete(int id);
    }
}
