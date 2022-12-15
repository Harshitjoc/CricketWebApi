using Cricket.Data.Models;
using Cricket.Data.Repositories;
using Cricket.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cricket.Services
{
    public interface IPlayerService
    {
        Task<IEnumerable<PlayerModel>> GetAll();
        Task<PlayerModel> GetById(int id);

        Task<List<PlayerModel>> GetAllPlayersByCountry(int countryId);
        Task<PlayerModel> Update(PlayerModel player);
        Task<PlayerModel> Add(PlayerModel player);
        Task<bool> Delete(int id);
    }
}
