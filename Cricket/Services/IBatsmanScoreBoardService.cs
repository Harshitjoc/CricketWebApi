using Cricket.Data.Models;

namespace Cricket.Services
{
    public interface IBatsmanScoreBoardService
    {
        Task<IEnumerable<BatsmanScoreBoard>> GetAll();
        Task<BatsmanScoreBoard> GetById(int id);
        Task<BatsmanScoreBoard> Update(BatsmanScoreBoard batsmanScoreBoard);
        Task<BatsmanScoreBoard> Add(BatsmanScoreBoard batsmanScoreBoard);
        Task<bool> Delete(int id);
    }
}
