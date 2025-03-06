using Entities.Interfaces;
using Entities.Models;

namespace HackerSpace.Data.Mocks
{
    public class EvaluatorsPageDataServiceMock : IEvaluatorsPageDataService
    {
        private List<Evaluator> evaluators = new List<Evaluator>()
        {
            new Evaluator() {
                Id=Guid.NewGuid(),
                FirstName = "Rob",
                LastName = "Garner",
                UserId=Guid.Parse("c92c0fc7-d0c9-48d0-8182-f9715637e9a6"),
                Badges = new List<Badge>()
                {
                    new Badge()
                    {
                        Id = Guid.NewGuid(),
                        Description= "Badge 1 Description",
                        Title = "Badge 1",
                        TurnInInstructions = "Badge Turn in instructions",
                    },
                    new Badge()
                    {
                        Id = Guid.NewGuid(),
                        Description= "Badge 2 Description",
                        Title = "Badge 2",
                        TurnInInstructions = "Badge Turn in instructions",
                    },
                },
            },
            new Evaluator() 
            {
                Id=Guid.NewGuid(), 
                FirstName = "A", 
                LastName = "Person", 
                UserId=Guid.Parse("3169477b-dbb8-4628-a61e-e7d30814e39a"),
                Badges = new List<Badge>()
                {
                    new Badge()
                    {
                        Id = Guid.NewGuid(),
                        Description= "Badge 3 Description",
                        Title = "Badge 3",
                        TurnInInstructions = "Badge Turn in instructions",
                    },
                    new Badge()
                    {
                        Id = Guid.NewGuid(),
                        Description= "Badge 4 Description",
                        Title = "Badge 4",
                        TurnInInstructions = "Badge Turn in instructions",
                    },
                },            
            },
        };

        public Task<List<Evaluator>> GetAllAsync()
        {
            return Task.FromResult(evaluators);
        }
    }
}
