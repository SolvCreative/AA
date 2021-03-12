using AA.Controllers.Solar_System;
using AA.Solar_System;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AA.Models
{
    public class SolarSystemViewModel
    {
        public void GetData()
        {
        }

        public IEnumerable<SolarSystemList> SolarSystemList { get; set; }

        [JsonProperty("id")]
        public string id { get; set; }
        
        [JsonProperty("englishName")]
        public string englishName { get; set; }

        [JsonProperty("isPlanet")]
        public bool isPlanet { get; set; }

        [JsonProperty("moons")]
        public Array moons { get; set; }

        [JsonProperty("gravity")]
        public double gravity { get; set; }

        [JsonProperty("meanRadius")]
        public int meanRadius { get; set; }

        [JsonProperty("discoveryDate")]
        public string discoveryDate { get; set; }
    }
              
    }

    

