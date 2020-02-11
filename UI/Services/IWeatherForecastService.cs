using Common;
using System;
using System.Threading.Tasks;

namespace UI.Services
{
    public interface IWeatherForecastService
    {
        Task<WeatherForecast[]> GetForecastAsync(DateTime? startDate = null);
    }
}
