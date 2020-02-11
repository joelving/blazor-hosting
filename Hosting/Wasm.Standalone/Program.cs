using System;
using System.Net.Http;
using System.Threading.Tasks;
using UI.Services;
using Microsoft.AspNetCore.Blazor.Hosting;
using Microsoft.Extensions.DependencyInjection;
using UI;
using Wasm.Standalone.Services;

namespace Wasm.Standalone
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");
            builder.Services.AddScoped<IWeatherForecastService, WeatherForecastService>();
            builder.Services.AddScoped(s => new HttpClient
            {
                // Base address of the API.
                BaseAddress = new Uri("https://localhost:44329")
            });

            await builder.Build().RunAsync();
        }
    }
}
