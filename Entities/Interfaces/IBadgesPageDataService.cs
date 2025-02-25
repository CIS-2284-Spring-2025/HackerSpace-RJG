using Entities.Models;

namespace Entities.Interfaces
{
    public interface IBadgesPageDataService
    {
        public Task<List<Badge>> GetAllAsync();
        public Task<Badge?> GetBadgeAsync(Guid id);
    }
}
