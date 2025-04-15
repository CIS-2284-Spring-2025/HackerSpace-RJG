using Entities.Models;

namespace Entities.Interfaces
{
    public interface IEvaluatorsDataService
    {
        public Task AddAsync(Evaluator evaluator);
        public Task DeleteAsync(Guid id);
        public Task<List<Evaluator>?> GetAllAsync();
        public Task<Evaluator?> GetAsync(Guid id);
        public Task UpdateAsync(Evaluator evaluator);
        public Task<List<ApplicationUser>> GetApplicationUsersAsync();
        public Task<List<Badge>> GetBadgesAsync();
    }
}
