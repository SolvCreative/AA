using AA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AA.NEO_Locator
{
    public interface INeoRepo
    {
        public IEnumerable<Neo> GetAllNeos();

        public void GetRandomNeo();
    }
}
