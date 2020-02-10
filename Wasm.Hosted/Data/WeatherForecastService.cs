using Domain;
using Common;
using Common.Services;
using System;
using System.Threading.Tasks;

namespace Wasm.Hosted.Data
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly WeatherForecastProvider _provider;

        public WeatherForecastService(WeatherForecastProvider provider)
        {
            _provider = provider;
        }

        public Task<WeatherForecast[]> GetForecastAsync(DateTime? startDate = null)
            => Task.FromResult(_provider.GetForecast(startDate));
    }
}
