using Entities.Interfaces;
using Entities.Models;

namespace HackerSpace.Data.Mocks
{
    public class BadgesPageDataServiceMock : IBadgesPageDataService
    {
        private List<Badge> _badges = new List<Badge>()
        {
            new Badge()
            {
                Id = Guid.NewGuid(),
                Title  = "Beginner Hacker",
                Description = "Awarded for completing the beginner hacking course.",
                TurnInInstructions = "Submit your course completion certificate.",
                IsVisible = true,
            },
            new Badge()
            {
                Id = Guid.NewGuid(),
                Title  = "Security Expert",
                Description = "Awarded for demonstrating advanced security skills.",
                TurnInInstructions = "Submit a report on your security project.",
                IsVisible = false,
            },
            new Badge()
            {
                Id = Guid.NewGuid(),
                Title  = "Code Contributor",
                Description = "Awarded for contributing to open-source projects.",
                TurnInInstructions = "Submit your GitHub profile link.",
                IsVisible = true,
            },
            new Badge()
            {
                Id = Guid.NewGuid(),
                Title  = "Bug Hunter",
                Description = "Awarded for finding and reporting bugs.",
                TurnInInstructions = "Submit your bug report.",
                IsVisible = false,
            },
            new Badge
            {
                Id = Guid.NewGuid(),
                Title = "Community Helper",
                Description = "Awarded for helping others in the community.",
                TurnInInstructions = "Submit testimonials from community members.",
                IsVisible = true
            }
        };

        public Task DeleteBadgeAsync(Guid id)
        {
            var badgeToRemove = _badges.Where(b => b.Id == id).FirstOrDefault();
            if (badgeToRemove != null)
            {
                _badges.Remove(badgeToRemove);
            }
            return Task.CompletedTask;
        }

        public Task<List<Badge>> GetAllAsync()
        {
            return Task.FromResult(_badges);
        }

        public Task<Badge?> GetBadgeAsync(Guid id)
        {
            return Task.FromResult(_badges.Where(b => b.Id == id).FirstOrDefault());
        }

        public Task UpdateBadge(Badge badge)
        {
            var existingBadge = _badges.FirstOrDefault(b=>b.Id == badge.Id);
            if (existingBadge != null)
            {
                _badges.Remove(existingBadge);
                _badges.Add(badge);
            } 
            else
            {
                badge.Id = Guid.NewGuid();
                _badges.Add(badge);
            }
            return Task.CompletedTask;
        }
    }
}
