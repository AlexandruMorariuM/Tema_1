using Tema_1.Entities;
using Tema_1.Repository;
using Tema_1.Services.StoveServices;

namespace Tema_1.Services.StoveService
{
    public class StoveService : IStoveService
    {
        private readonly StoveRepository _stoveRepository;

        public StoveService(StoveRepository stoveRepository)
        {
            _stoveRepository = stoveRepository;
        }

        public async Task<List<Stove>?> AddStove(Stove stove)
        {
            _stoveRepository.AddStove(stove);
            return _stoveRepository.GetAllStoves();
        }

        public async Task<List<Stove>?> DeleteStove(int id)
        {
            var result = _stoveRepository.GetStoveById(id);
            if (result is null)
            {
                return null;
            }
            _stoveRepository.DeleteStove(id);

            return _stoveRepository.GetAllStoves();
        }

        public async Task<List<Stove>> GetAllStoves()
        {
            return _stoveRepository.GetAllStoves();
        }

        public async Task<Stove?> GetStoveById(int id)
        {
            var result = _stoveRepository.GetStoveById(id);
            if (result is null)
            {
                return null;
            }

            return result;
        }

        public async Task<List<Stove>?> UpdateStove(Stove stove)
        {
            var result = _stoveRepository.GetStoveById(stove.Id);

            if (result is null)
            {
                return null;
            }

            result.Name = stove.Name;
            result.Weight = stove.Weight;
            result.Width = stove.Width;
            result.Height = stove.Height;
            result.Depth = stove.Depth;
            result.Type = stove.Type;
            result.HasGrill = stove.HasGrill;
            result.HasRoaster = stove.HasRoaster;

            return _stoveRepository.GetAllStoves();
        }
    }
}
