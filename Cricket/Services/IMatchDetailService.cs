using Cricket.Data.Models;

namespace Cricket.Services
{
    public interface IMatchDetailService
    {
        Task<IEnumerable<MatchDetail>> GetAll();
        Task<MatchDetail> GetById(int id);
        Task<MatchDetail> Update(MatchDetail matchDetail);
        Task<MatchDetail> Add(MatchDetail matchDetail);
        void Delete(int id);
    }
}
