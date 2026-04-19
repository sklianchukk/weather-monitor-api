using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System;

namespace WeatherMonitor
{
    public class WeatherModel
    {
        private static readonly HttpClient _httpClient = new HttpClient();

        private readonly string _apiKey;
        private readonly string _baseUrl;

        public WeatherModel(string apiKey, string baseUrl)
        {
            _apiKey = apiKey;
            _baseUrl = baseUrl;
        }

        // async - await pattern to avoid blocking the UI thread during network calls
        public async Task<WeatherResponse?> GetWeatherForCityAsync(string cityName)
        {
            if (string.IsNullOrWhiteSpace(cityName))
            {
                return null;
            }

            string requestUrl = $"{_baseUrl}?q={cityName}&appid={_apiKey}&units=metric&lang=en";

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(requestUrl);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResult = await response.Content.ReadAsStringAsync();
                    WeatherResponse? data = JsonConvert.DeserializeObject<WeatherResponse>(jsonResult);
                    return data;
                }

                LogError($"API returned status code: {response.StatusCode} for city: {cityName}");
                return null;
            }
            catch (HttpRequestException ex)
            {
                LogError($"Network error while fetching weather for {cityName}: {ex.Message}");
                return null;
            }
            catch (JsonException ex)
            {
                LogError($"JSON parsing error for city {cityName}: {ex.Message}");
                return null;
            }
            catch (Exception ex)
            {
                LogError($"Unexpected error while fetching weather for {cityName}: {ex.Message}");
                return null;
            }
        }

        private void LogError(string message)
        {
            Console.WriteLine($"[ERROR] {DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}");
            System.Diagnostics.Debug.WriteLine($"[ERROR] {message}");
        }
    }
}
