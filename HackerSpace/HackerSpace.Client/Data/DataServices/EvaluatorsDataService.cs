using Entities.Interfaces;
using Entities.Models;
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

        public async Task<Evaluator?> GetAsync(Guid id)
        {
            return await _http.GetFromJsonAsync<Evaluator>($"api/Evaluators/{id}");
        }

        public async Task AddAsync(Evaluator evaluator)
        {
            await _http.PostAsJsonAsync($"api/Evaluators", evaluator);
        }

        public Task UpdateAsync(Evaluator evaluator)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(Guid id)
        {
            await _http.DeleteAsync($"api/Evaluators/{id}");
        }

        public async Task<List<ApplicationUser>> GetApplicationUsersAsync()
        {
            return await _http.GetFromJsonAsync<List<ApplicationUser>>($"api/Evaluators/AppUsers")??new List<ApplicationUser>();
        }

        public async Task<List<Badge>> GetBadgesAsync()
        {
            return await _http.GetFromJsonAsync<List<Badge>>($"api/Evaluators/Badges") ?? new List<Badge>();
        }
    }
}
