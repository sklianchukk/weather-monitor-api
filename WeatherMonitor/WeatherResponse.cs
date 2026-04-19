using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace WeatherMonitor
{
    public class WeatherResponse
    {
        [JsonProperty("name")]
        public string CityName { get; set; } = string.Empty;

        [JsonProperty("main")]
        public MainData Main { get; set; } = new MainData();

        [JsonProperty("weather")]
        public List<WeatherInfo> Weather { get; set; } = new List<WeatherInfo>();
    }
}
