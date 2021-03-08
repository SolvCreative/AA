using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AA.Models;

namespace AA.Facts_Generator
{
    public interface IFactsRepo
    {
        public IEnumerable<facts> GetAllFacts();
        public facts GetRandomFact();
        public IEnumerable<facts> GetAllCategories();
        public facts GetOneCategory(string category);
       
    }
}
