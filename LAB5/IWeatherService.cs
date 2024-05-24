namespace LAB5;

public interface IWeatherService
{
    Task<string> GetWeatherByCoordinatesAsync(double latitude, double longitude);
}