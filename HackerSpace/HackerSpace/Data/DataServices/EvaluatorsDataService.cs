using Entities.Interfaces;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace HackerSpace.Data.DataServices
{
    public class EvaluatorsDataService : IEvaluatorsPageDataService
    {
        private static ApplicationDbContext _context = default!;

        public EvaluatorsDataService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Evaluator>> GetAllAsync()
        {
            return await _context.Evaluators.ToListAsync();
        }
    }
}
