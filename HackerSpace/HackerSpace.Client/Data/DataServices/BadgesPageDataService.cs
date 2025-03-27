using Entities.Interfaces;
using Entities.Models;
using System.Net.Http.Json;

namespace HackerSpace.Client.Data.DataServices
{
    public class BadgesPageDataService : IBadgesPageDataService
    {

        private HttpClient _http;
        public BadgesPageDataService(HttpClient http)
        {
            _http = http;
        }

        public Task DeleteBadgeAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Badge>?> GetAllAsync()
        {
            return await _http.GetFromJsonAsync<List<Badge>>("api/Badges");
        }

        public async Task<Badge?> GetBadgeAsync(Guid id)
        {
            return await _http.GetFromJsonAsync<Badge>($"api/Badges/{id.ToString()}/");
        }

        public Task UpdateBadge(Badge badge)
        {
            throw new NotImplementedException();
        }
    }
}
