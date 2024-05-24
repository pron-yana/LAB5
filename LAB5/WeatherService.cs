namespace LAB5;

using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

public class WeatherService : IWeatherService
{
    private readonly HttpClient _httpClient;
    private string _apiKey = "036fef810dd6dcc0852a2777598e890d"; 

    public WeatherService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<string> GetWeatherByCoordinatesAsync(double latitude, double longitude)
    {
        var url = $"https://api.openweathermap.org/data/2.5/weather?lat={latitude}&lon={longitude}&appid={_apiKey}";
        var response = await _httpClient.GetAsync(url);

        response.EnsureSuccessStatusCode();

        var responseBody = await response.Content.ReadAsStringAsync();
        var weatherData = JObject.Parse(responseBody);

        return weatherData.ToString();
    }
}
