using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorApp.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            if (builder.HostEnvironment.BaseAddress.Contains(":5001"))
            {
                builder.RootComponents.Add<App>("#app");
            }

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:5003") });

            await builder.Build().RunAsync();
        }
    }
}
