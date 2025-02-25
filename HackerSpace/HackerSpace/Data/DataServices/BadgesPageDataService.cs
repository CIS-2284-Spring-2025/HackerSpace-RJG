using Entities.Interfaces;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace HackerSpace.Data.DataServices
{
    public class BadgesPageDataService : IBadgesPageDataService
    {
        private ApplicationDbContext _context;

        public BadgesPageDataService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Badge>> GetAllAsync()
        {
            return await _context.Badges.ToListAsync();
        }

        public async Task<Badge?> GetBadgeAsync(Guid id)
        {
            return await _context.Badges.Where(b=>b.Id == id).FirstOrDefaultAsync();
        }
    }
}
