using Entities.Interfaces;
using HackerSpace.Client;
using HackerSpace.Client.Data.DataServices;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace HackerSpace.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.Services.AddAuthorizationCore();
            builder.Services.AddCascadingAuthenticationState();
            builder.Services.AddSingleton<AuthenticationStateProvider, PersistentAuthenticationStateProvider>();

            //For Api calls
            builder.Services.AddTransient(sp =>
            new HttpClient
            {
                BaseAddress = new Uri(builder.Configuration["FrontendUrl"] ?? "https://localhost:7170")
            });

            //Add data services
            builder.Services.AddTransient<IBadgesPageDataService, BadgesPageDataService>();

            await builder.Build().RunAsync();
        }
    }
}
