using Tema_1.Entities;

namespace Tema_1.Services.StoveServices
{
    public interface IStoveService
    {
        Task<List<Stove>> GetAllStoves();
        Task<Stove?> GetStoveById(int id);
        Task<List<Stove>?> AddStove(Stove stove);
        Task<List<Stove>?> UpdateStove(Stove stove);
        Task<List<Stove>?> DeleteStove(int id);
    }
}
