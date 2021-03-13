using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AA.Models;
using Newtonsoft.Json;

namespace AA.Solar_System
{
    public class SolarSystemData : Data
    {       
        

        [JsonProperty("id")]
        public string? id { get; set; }

        [JsonProperty("englishName")]
        public string? englishName { get; set; }

        [JsonProperty("isPlanet")]
        public bool? isPlanet { get; set; }

        //[JsonProperty("moons")]
        //public Array moons { get; set; }

        [JsonProperty("gravity")]
        public double? gravity { get; set; }

        [JsonProperty("meanRadius")]
        public decimal? meanRadius { get; set; }

        [JsonProperty("discoveryDate")]
        public string? discoveryDate { get; set; }
    }

}
