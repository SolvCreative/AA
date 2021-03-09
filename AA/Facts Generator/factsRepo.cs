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
        private readonly IDbConnection _connection;
        public FactsRepo(IDbConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<FactViewModel> GetAllCategories()
        {
            return _connection.Query<FactViewModel>("SELECT DISTINCT category FROM facts_list;").ToList();
        }

        public IEnumerable<FactViewModel> GetAllFacts()
        {
            return _connection.Query<FactViewModel>("SELECT * FROM facts_list;");
        }

        public FactViewModel GetOneCategory(string category)
        {
            return _connection.QuerySingle<FactViewModel>("SELECT * FROM facts_list WHERE CATEGORY = @category",
                new { category = category });
        }

        public FactViewModel GetRandomFact()
        {
            return _connection.QuerySingle<FactViewModel>("SELECT fact FROM facts_list ORDER BY RAND() LIMIT 1;");
        }

       
    }
}
