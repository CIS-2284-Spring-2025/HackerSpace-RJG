using Entities.Models;

namespace Entities.Interfaces
{
    public interface IEvaluatorsPageDataService
    {
        Task<List<Evaluator>> GetAllAsync();
    }
}
