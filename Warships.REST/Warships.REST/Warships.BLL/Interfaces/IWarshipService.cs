using Warships.BLL.Entities;

namespace Warships.BLL.Interfaces
{
    public interface IWarshipService
    {
        Task<IEnumerable<Warship>> GetAllAsync();
        Task<Warship?> GetByIdAsync(int id);
        Task CreateAsync(Warship warship);
        Task UpdateAsync(Warship warship);
        Task DeleteAsync(int id);
    }
}
