using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Dapper;
using System.Threading.Tasks;
using AA.Models;

namespace AA.Facts_Generator
{
    public class FactsRepo : IFactsRepo
    {
        private readonly IDbConnection _conn1;
        public FactsRepo(IDbConnection conn1)
        {
            _conn1 = conn1;
        }

        public IEnumerable<FactViewModel> GetAllCategories()
        {
            return _conn1.Query<FactViewModel>("SELECT DISTINCT category FROM facts_list;").ToList();
        }

        public IEnumerable<FactViewModel> GetAllFacts()
        {
            return _conn1.Query<FactViewModel>("SELECT * FROM facts_list;");
        }

        public FactViewModel GetOneCategory(string category)
        {
            return _conn1.QuerySingle<FactViewModel>("SELECT * FROM facts_list WHERE CATEGORY = @category",
                new { category = category });
        }

        public FactViewModel GetRandomFact()
        {
            return _conn1.QuerySingle<FactViewModel>("SELECT fact FROM facts_list ORDER BY RAND() LIMIT 1;");
        }

       
    }
}
