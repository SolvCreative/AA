using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AA.Star_Locator
{
    public interface IStarsRepo
    {
        IEnumerable<stars> GetStars();
    }
}
