using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AA.Star_Locator
{
    public class stars
    {
        
        public int id { get; set; }
        public string name { get; set; }
        public bool neo { get; set; }
        public float diameter { get; set; } //what is the unit of measure? Check the JPL site.
        public DateTime last_obs { get; set; }
    }   

}
