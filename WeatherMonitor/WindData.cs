using System;
using Newtonsoft.Json;

namespace WeatherMonitor
{
    public class WindData
    {
        [JsonProperty("speed")]
        public double Speed { get; set; }
    }
}
