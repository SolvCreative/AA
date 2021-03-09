using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AA.Models
{
    public class NeoViewModel
    {
        public void GetNeo()
        {

        }       
        public int id { get; set; }
        public string name { get; set; }
        public float diameter { get; set; } //what is the unit of measure? Check the JPL site.
        public DateTime first_obs { get; set; }
        public DateTime last_obs { get; set; }
    }
}
