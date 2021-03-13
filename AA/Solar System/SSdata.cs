using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace AA.Solar_System
{
    public class SSdata
    {
        public void GetData()
        {
        }
        public IEnumerable<SSdata> SolarSystem { get; set; }

        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("englishName")]
        public string englishName { get; set; }

        [JsonProperty("isPlanet")]
        public bool isPlanet { get; set; }

        //[JsonProperty("moons")]
        //public Array moons { get; set; }

        [JsonProperty("gravity")]
        public double gravity { get; set; }

        [JsonProperty("meanRadius")]
        public decimal meanRadius { get; set; }

        [JsonProperty("discoveryDate")]
        public string discoveryDate { get; set; }
    }
}

