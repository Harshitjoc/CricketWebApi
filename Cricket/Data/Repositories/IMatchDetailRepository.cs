using Cricket.Models;

namespace Cricket.Data.Repositories
{
    public interface IMatchDetailRepository
    {
        Task<IEnumerable<MatchDetail>> GetAll();
        Task<MatchDetail> GetById(int id);
        bool Update(MatchDetail matchDetail);
        Task<MatchDetail> Add(MatchDetail matchDetail);
        bool Delete(int id);
    }
}
