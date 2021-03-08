using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AA.Models
{
    public class MarsData
    {
        public void GetMarsData()
        {
        }
        public int status { get; set; }
        public int sol { get; set; }
        public string season { get; set; }
        public int min_temp { get; set; }
        public int max_temp { get; set; }
        public string atmo_opacity { get; set; }
        public string sunset { get; set; }
        public string sunrise { get; set; }
        public int min_gts_temp { get; set; }
        public int max_gts_temp { get; set; }
        public string unitOfMeasure { get; set; }
        public string TZ_Data { get; set; }
    }
}
   

