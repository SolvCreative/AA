using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AA.Models
{
    public class WeatherViewModel 
    {
        public void GetWeather()
        {
        }
        public float SOL { get; set; }
        public object AT { get; set; }
        public object HWS { get; set; }
        public object PRE { get; set; }
        public object WD { get; set; }
        public string Season { get; set; }
        public DateTime First_UTC { get; set; }
        public DateTime Last_UTC { get; set; }
    
    }
}
