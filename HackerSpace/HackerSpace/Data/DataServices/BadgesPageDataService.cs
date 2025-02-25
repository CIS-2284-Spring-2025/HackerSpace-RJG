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

        public async Task DeleteBadgeAsync(Guid id)
        {
            var badgeToDelete =  await _context.Badges.Where(b => b.Id == id).FirstOrDefaultAsync();
            if (badgeToDelete != null)
            {
                _context.Badges.Remove(badgeToDelete);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Badge>> GetAllAsync()
        {
            return await _context.Badges.ToListAsync();
        }

        public async Task<Badge?> GetBadgeAsync(Guid id)
        {
            return await _context.Badges.Where(b=>b.Id == id).FirstOrDefaultAsync();
        }

        public async Task UpdateBadge(Badge badge)
        {
            _context.Badges.Update(badge);
            await _context.SaveChangesAsync();
        }
    }
}
