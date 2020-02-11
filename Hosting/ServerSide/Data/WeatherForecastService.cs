using Domain;
using Common;
using UI.Services;
using System;
using System.Threading.Tasks;

namespace ServerSide.Data
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
