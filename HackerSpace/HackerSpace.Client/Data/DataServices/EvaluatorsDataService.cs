using Entities.Interfaces;
using Entities.Models;
using HackerSpace.Data;
using System.Net.Http.Json;

namespace HackerSpace.Client.Data.DataServices
{
    public class EvaluatorsDataService:IEvaluatorsDataService
    {
        private HttpClient _http;
        public EvaluatorsDataService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Evaluator>?> GetAllAsync()
        {
            return await _http.GetFromJsonAsync<List<Evaluator>>("api/Evaluators");
        }

        public Task<Evaluator?> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(Evaluator evaluator)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Evaluator evaluator)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ApplicationUser>> GetApplicationUsersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<Badge>> GetBadgesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
