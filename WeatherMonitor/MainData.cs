using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace WeatherMonitor
{
    public class MainData
    {
        [JsonProperty("temp")]
        public double Temperature { get; set; }

        [JsonProperty("pressure")]
        public int Pressure { get; set; }

        [JsonProperty("humidity")]
        public int Humidity { get; set; }
    }
}
