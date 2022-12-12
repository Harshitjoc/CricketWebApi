using Cricket.Data.Repositories;
using Cricket.Models;

namespace Cricket.Services
{
    public class TossService : ITossService
    {
        private readonly TossRepository _tossRepository;
        public TossService(TossRepository tossRepository)
        {
            _tossRepository = tossRepository;
        }

        public Task<Toss> Add(Toss toss)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Toss>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Toss> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Toss> Update(Toss toss)
        {
            throw new NotImplementedException();
        }
    }
}
