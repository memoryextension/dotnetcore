using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            this._logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        [EnableCors("Fiddle")]
        public IEnumerable<WeatherForecast> Get(int days)
        {
            return Enumerable.Range(0, days - 1).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = DateTime.Now.AddDays(index).Day + 5,
            })
            .ToArray();
        }
    }
}