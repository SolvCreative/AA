using AA.Controllers.Solar_System;
using AA.Solar_System;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AA.Models
{
    public class SolarSystemViewModel
    {
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

    //    public IEnumerator<SolarSystemData> GetEnumerator()
    //    {
    //        return SolarSystemData.GetEnumerator();
    //    }

    //    IEnumerator IEnumerable.GetEnumerator()
    //    {
    //        return Bodies.GetEnumerator();
    //    }

    //    public IEnumerable<SolarSystemData> SolarSystemData { get; set; }






}




