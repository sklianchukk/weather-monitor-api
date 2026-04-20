using System;
using System.Collections.Generic;

namespace WeatherMonitor
{
    public interface IView
    {
        string CityInput { get; set; }
        string SelectedCapital { get; }

        string TemperatureDisplay { get; set; }
        string PressureDisplay { get; set; }
        string HumidityDisplay { get; set; }
        string WindDisplay { get; set; }
        string WeatherIconUrl { get; set; }

        List<string> EuropeanCapitals { set; }

        event Action? SearchByCityClicked;
        event Action? CapitalSelectionChanged;
    }
}
