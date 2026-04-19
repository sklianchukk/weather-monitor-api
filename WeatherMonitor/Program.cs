using System;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;

namespace WeatherMonitor
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Load configuration from appsettings.json
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            // Read API key and base URL from configuration
            string apiKey = configuration["OpenWeatherMap:ApiKey"] ?? throw new InvalidOperationException("API Key not found in configuration");
            string baseUrl = configuration["OpenWeatherMap:BaseUrl"] ?? throw new InvalidOperationException("Base URL not found in configuration");

            // Create components and run the application
            IView view = new Form1();
            WeatherModel model = new WeatherModel(apiKey, baseUrl);
            Presenter presenter = new Presenter(view, model);

            Application.Run((Form)view);
        }
    }
}