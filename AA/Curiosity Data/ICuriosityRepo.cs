using AA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AA.Curiosity_Data
{
    public interface ICuriosityRepo
    {
        public IEnumerable<MarsData> GetMarsData();
        
    }
}
