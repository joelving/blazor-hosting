using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Domain;
using Common;

namespace Wasm.Hosted.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly WeatherForecastProvider _provider;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(WeatherForecastProvider provider, ILogger<WeatherForecastController> logger)
        {
            _provider = provider;
            _logger = logger;
        }

        [HttpGet]
        public WeatherForecast[] Get()
            => _provider.GetForecast();
    }
}
