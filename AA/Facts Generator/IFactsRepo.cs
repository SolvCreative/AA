using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AA.Facts_Generator
{
    public interface IFactsRepo
    {
        IEnumerable<facts> GetFacts();
    }
}
