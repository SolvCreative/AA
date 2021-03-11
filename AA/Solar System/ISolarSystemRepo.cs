using AA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AA.Controllers.Solar_System
{
    public interface ISolarSystemRepo
    {
        public IEnumerable<SolarSystemViewModel> GetData();
    }
}
