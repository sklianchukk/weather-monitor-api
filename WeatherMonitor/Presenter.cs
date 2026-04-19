using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WeatherMonitor
{
    public class Presenter
    {
        private readonly IView _view;
        private readonly WeatherModel _model;

        public Presenter(IView view, WeatherModel model)
        {
            _view = view;
            _model = model;

            _view.SearchByCityClicked += OnSearchByCityClicked;
            _view.CapitalSelectionChanged += OnCapitalSelectionChanged;

            LoadCapitals();
        }

        private void LoadCapitals()
        {
            _view.EuropeanCapitals = new List<string>
            {
                "Warsaw", "Berlin", "Paris", "Madrid", "Rome",
                "London", "Vienna", "Prague", "Budapest", "Bratislava",
                "Stockholm", "Oslo", "Helsinki", "Copenhagen", "Athens",
                "Lisbon", "Dublin", "Amsterdam", "Brussels", "Bern"
            };
        }

        private async void OnSearchByCityClicked()
        {
            string cityToSearch = _view.CityInput;
            await FetchAndDisplayWeatherAsync(cityToSearch);
        }

        private async void OnCapitalSelectionChanged()
        {
            string selectedCity = _view.SelectedCapital;
            await FetchAndDisplayWeatherAsync(selectedCity);
        }

        private async Task FetchAndDisplayWeatherAsync(string cityName)
        {
            if (string.IsNullOrWhiteSpace(cityName))
            {
                DisplayError("Please enter a city name.");
                return;
            }

            _view.TemperatureDisplay = "Fetching...";
            _view.PressureDisplay = "-";
            _view.HumidityDisplay = "-";

            var weatherData = await _model.GetWeatherForCityAsync(cityName);

            if (weatherData != null)
            {
                _view.TemperatureDisplay = $"{weatherData.Main.Temperature} °C";
                _view.PressureDisplay = $"{weatherData.Main.Pressure} hPa";
                _view.HumidityDisplay = $"{weatherData.Main.Humidity} %";

                if (weatherData.Weather != null && weatherData.Weather.Count > 0)
                {
                    string iconCode = weatherData.Weather[0].IconCode;
                    _view.WeatherIconUrl = $"http://openweathermap.org/img/wn/{iconCode}@2x.png";
                }
            }
            else
            {
                DisplayError("City not found or network error.");
            }
        }

        private void DisplayError(string message)
        {
            _view.TemperatureDisplay = message;
            _view.PressureDisplay = "";
            _view.HumidityDisplay = "";
            _view.WeatherIconUrl = "";
        }
    }
}