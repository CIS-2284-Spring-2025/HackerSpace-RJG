using Entities.Models;

namespace Entities.Interfaces
{
    public interface IBadgesPageDataService
    {
        public Task<List<Badge>> GetAllAsync();
        public Task<Badge?> GetBadgeAsync(Guid id);
        public Task UpdateBadge(Badge badge);
        public Task DeleteBadgeAsync(Guid id);
    }
}
