using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RailDelay.Models
{
    public class TrainStation
    {
        [JsonProperty("locationX")]
        public string LocationX { get; set; }
        [JsonProperty("locationY")]
        public string LocationY { get; set; }
        [JsonProperty("id")]
        public string ID { get; set; }
        [JsonProperty("@id")]
        public string URL { get; set; }
        [JsonProperty("standardname")]
        public string Standardname { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
