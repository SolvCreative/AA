using System;

namespace AA.Models
{
    public class NeoViewModel
    {
        public void GetNeoData()
        {
        }

        public int id { get; set; }
        public string full_name { get; set; }
        public string name { get; set; }
        public float diameter { get; set; } //what is the unit of measure? Check the JPL site.
        public DateTime first_obs { get; set; }
        public DateTime last_obs { get; set; }
    }
}
