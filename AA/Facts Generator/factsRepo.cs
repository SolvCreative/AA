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

        public IEnumerable<Fact> GetAllCategories()
        {
            return _connection.Query<Fact>("SELECT DISTINCT category FROM facts_list;").ToList();
        }

        public IEnumerable<Fact> GetAllFacts()
        {
            return _connection.Query<Fact>("SELECT * FROM facts_list;");
        }

        public Fact GetOneCategory(string category)
        {
            return _connection.QuerySingle<Fact>("SELECT * FROM facts_list WHERE CATEGORY = @category",
                new { category = category });
        }

        public Fact GetRandomFact()
        {
            return _connection.QuerySingle<Fact>("SELECT fact FROM facts_list ORDER BY RAND() LIMIT 1;");
        }

       
    }
}
