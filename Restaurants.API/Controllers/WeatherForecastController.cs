using Microsoft.AspNetCore.Mvc;

namespace Restaurants.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly WeatherForecastServices _weatherForecastServices;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,
                                        WeatherForecastServices weatherForecastServices)
        {
            _logger = logger;
            _weatherForecastServices = weatherForecastServices;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var result = _weatherForecastServices.Get();
            return result;
        }
    }
}
