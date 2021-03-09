using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AA.Models;

namespace AA.Facts_Generator
{
    public interface IFactsRepo
    {
        public IEnumerable<Fact> GetAllFacts();
        public Fact GetRandomFact();
        public IEnumerable<Fact> GetAllCategories();
        public Fact GetOneCategory(string category);
       
    }
}
