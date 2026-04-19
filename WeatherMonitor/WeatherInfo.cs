using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace WeatherMonitor
{
    public class WeatherInfo
    {
        [JsonProperty("description")]
        public string Description { get; set; } = string.Empty;

        [JsonProperty("icon")]
        public string IconCode { get; set; } = string.Empty;
    }
}
