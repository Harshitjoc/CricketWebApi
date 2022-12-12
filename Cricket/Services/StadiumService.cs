using Cricket.Data.Repositories;
using Cricket.Models;

namespace Cricket.Services
{
    public class StadiumService : IStadiumService
    {
        private readonly StadiumRepository _stadiumRepository;
        public StadiumService(StadiumRepository stadiumRepository)
        {
            _stadiumRepository = stadiumRepository;
        }
        public Task<Stadium> Add(Stadium stadium)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Stadium>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Stadium> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Stadium> Update(Stadium stadium)
        {
            throw new NotImplementedException();
        }
    }
}
