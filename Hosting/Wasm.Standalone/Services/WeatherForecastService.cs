using Microsoft.AspNetCore.Components;
using Common;
using UI.Services;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Wasm.Standalone.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly HttpClient Http;
        public WeatherForecastService(HttpClient http)
        {
            Http = http;
        }

        private const string url = "/WeatherForecast";
        public async Task<WeatherForecast[]> GetForecastAsync(DateTime? startDate = null)
        {
            return await Http.GetJsonAsync<WeatherForecast[]>(url);
        }
    }
}
