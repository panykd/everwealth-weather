using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using restapi_dotnet.Models;

namespace restapi_dotnet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Weather : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Sunny"
        };

        private readonly ILogger<Weather> _logger;

        public Weather(ILogger<Weather> logger)
        {
            _logger = logger;
        }

        [HttpGet("{location}")]
        public CurrentWeather Get(string location)
        {
            var rng = new Random();

            return new CurrentWeather
            {
                Timestamp = DateTime.UtcNow,
                
                Summary = Summaries[rng.Next(Summaries.Length)],

                Location = location,

                Temperature = Convert.ToDecimal(rng.NextDouble() * 30) + 10m,
                Humidity = Convert.ToDecimal(rng.NextDouble()),
                Visibility = Convert.ToDecimal(rng.NextDouble() * 4),
                UVIndex = rng.Next(1, 15)
            };
        }
    }
}
