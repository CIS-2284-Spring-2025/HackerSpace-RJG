using Entities.Interfaces;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HackerSpace.Data.DataServices
{
    public class EvaluatorsDataService //: IEvaluatorsDataService
    {
        private ApplicationDbContext _context;
        private UserManager<ApplicationUser> _userManager;

        public EvaluatorsDataService(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<List<Evaluator>?> GetAllAsync()
        {
            var evaluators = await _context.Evaluators.Include(e=>e.Badge).ToListAsync();
            foreach (Evaluator evaluator in evaluators)
            {
                var user = await _userManager.FindByIdAsync(evaluator.ApplicationUserId.ToString());
                evaluator.Email = user?.Email;
            }
            return evaluators;
        }

        public async Task<Evaluator?> GetAsync(Guid id)
        {
            return await _context.Evaluators.Include(e=>e.Badge).Where(b => b.Id == id).FirstOrDefaultAsync();
        }

        public async Task AddAsync(Evaluator evaluator)
        {
            _context.Evaluators.Add(evaluator);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Evaluator evaluator)
        {
            _context.Evaluators.Update(evaluator);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var evaluator = await _context.Evaluators.Where(b => b.Id == id).FirstOrDefaultAsync();
            if (evaluator != null)
            {
                _context.Evaluators.Remove(evaluator);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<ApplicationUser>> GetApplicationUsersAsync()
        {
            return await _userManager.Users.ToListAsync();
        }

        public async Task<List<Badge>> GetBadgesAsync()
        {
            return await _context.Badges.ToListAsync();
        }
    }
}
