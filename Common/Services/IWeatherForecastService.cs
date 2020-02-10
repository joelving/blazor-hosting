using System;
using System.Threading.Tasks;

namespace Common.Services
{
    public interface IWeatherForecastService
    {
        Task<WeatherForecast[]> GetForecastAsync(DateTime? startDate = null);
    }
}
