using Cricket.Data.Repositories;
using Cricket.Models;

namespace Cricket.Services
{
    public class MatchDetailService : IMatchDetailService
    {
        private readonly MatchDetailRepository _matchDetailRepository;
        public MatchDetailService(MatchDetailRepository matchDetailRepository)
        {
            _matchDetailRepository = matchDetailRepository;
        }
        public Task<MatchDetail> Add(MatchDetail matchDetail)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MatchDetail>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<MatchDetail> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<MatchDetail> Update(MatchDetail matchDetail)
        {
            throw new NotImplementedException();
        }
    }
}
