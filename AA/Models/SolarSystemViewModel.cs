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
       
        public IEnumerable<SolarSystemList> SolarSystemList { get; set; }
        public string? id { get; set; }
        public string? englishName { get; set; }
        public bool? isPlanet { get; set; }
        public Array? moons { get; set; }
        public double? gravity { get; set; }
        public int? meanRadius { get; set; }
        public string? discoveryDate { get; set; }
    }
              
    }

    

