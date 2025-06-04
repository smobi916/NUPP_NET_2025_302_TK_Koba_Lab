using Microsoft.EntityFrameworkCore;
using Warships.BLL.Entities;
using Warships.DAL.Context;
using Warships.DAL.Interfaces;

namespace Warships.DAL.Repositories
{
    public class WarshipRepository : IRepository<Warship>
    {
        private readonly AppDbContext _context;

        public WarshipRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Warship>> GetAllAsync()
        {
            return await _context.Warships.ToListAsync();
        }

        public async Task<Warship?> GetByIdAsync(int id)
        {
            return await _context.Warships.FindAsync(id);
        }

        public async Task CreateAsync(Warship warship)
        {
            _context.Warships.Add(warship);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Warship warship)
        {
            _context.Warships.Update(warship);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var warship = await _context.Warships.FindAsync(id);
            if (warship != null)
            {
                _context.Warships.Remove(warship);
                await _context.SaveChangesAsync();
            }
        }
    }
}
