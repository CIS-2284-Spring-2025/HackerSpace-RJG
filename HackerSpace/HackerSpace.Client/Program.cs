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

            //For Api calls
            builder.Services.AddTransient(sp =>
            new HttpClient
            {
                BaseAddress = new Uri(builder.Configuration["FrontendUrl"] ?? "https://localhost:7170")
            });
            // TODO: Try Rocky's sollution bellow from https://blog.lhotka.net/2024/10/13/Accessing-User-Identity-on-a-Blazor-Wasm-Client
            //builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddAuthorizationCore();


            builder.Services.AddCascadingAuthenticationState();
            //builder.Services.AddSingleton<AuthenticationStateProvider, PersistentAuthenticationStateProvider>();  
            builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>(); //To get userid         

            //Add data services
            builder.Services.AddTransient<IBadgesPageDataService, BadgesPageDataService>();

            await builder.Build().RunAsync();
        }
    }
}
