using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RailDelay.Models
{
    public class StationApi
    {
        [JsonProperty("version")]
        public string Version { get; set; }
        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
        [JsonProperty("station")]
        public List<TrainStation> Station { get; set; }
    }
}
