using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BlazorApp.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            if (builder.HostEnvironment.BaseAddress.Contains(":5001")
                || builder.HostEnvironment.BaseAddress.Contains("blazor-ref.netlify.app"))
            {
                builder.RootComponents.Add<App>("#app");
            }

            await builder.Build().RunAsync();
        }
    }
}
