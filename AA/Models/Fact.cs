using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AA.Models
{
    public class Fact
    {    
        public Fact()
        {
        }

        public int id { get; set; }
        public string category { get; set; }
        public string fact { get; set; }
        public string source { get; set; }
    }
}
