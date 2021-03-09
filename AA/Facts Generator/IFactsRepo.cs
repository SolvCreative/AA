using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AA.Models;

namespace AA.Facts_Generator
{
    public interface IFactsRepo
    {
        public IEnumerable<FactViewModel> GetAllFacts();
        public FactViewModel GetRandomFact();
        public IEnumerable<FactViewModel> GetAllCategories();
        public FactViewModel GetOneCategory(string category);
       
    }
}
