namespace LAB5;

using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

[ApiController]
[Route("[controller]")]
public class WeatherController : ControllerBase
{
    private readonly IWeatherService _weatherService;

    public WeatherController(IWeatherService weatherService)
    {
        _weatherService = weatherService;
    }

    [HttpGet("coordinates")]
    public async Task<IActionResult> GetWeatherByCoordinates(double lat, double lon)
    {
        var weatherData = await _weatherService.GetWeatherByCoordinatesAsync(lat, lon);
        return Ok(weatherData);
    }
}
