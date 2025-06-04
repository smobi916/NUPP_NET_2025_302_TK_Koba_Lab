using Warships.BLL.Entities;
using Warships.BLL.Interfaces;
using Warships.DAL.Interfaces;

namespace Warships.BLL.Services
{
    public class WarshipService : IWarshipService
    {
        private readonly IRepository<Warship> _repository;

        public WarshipService(IRepository<Warship> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Warship>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Warship?> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task CreateAsync(Warship warship)
        {
            await _repository.CreateAsync(warship);
        }

        public async Task UpdateAsync(Warship warship)
        {
            await _repository.UpdateAsync(warship);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
