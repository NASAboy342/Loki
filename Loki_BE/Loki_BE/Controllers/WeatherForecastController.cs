using System;
using Microsoft.AspNetCore.Mvc;

namespace Loki_BE.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }).ToArray();
        }

        [HttpGet("GetHelloWorld")]
        public string GetHelloWorld(int numOne, int numTwo)
        {

           //fjkldsa;jfkdlsjafkl;j
           //jjjkknkn
            var result = numOne + numTwo;
            return "HelloWorld" + result;
        }
        [HttpGet("GetRandomNumber")]
        public int GetRandomNumber() {
            Random random = new Random();

            int randomNumber = random.Next(1, 10);
            return randomNumber;
        }

    }
}
