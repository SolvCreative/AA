using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Dapper;
using System.Threading.Tasks;

namespace AA.Facts_Generator
{
    public class FactsRepo : IFactsRepo
    {
        private readonly IDbConnection _connection;
        public FactsRepo(IDbConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<facts> GetAllCategories()
        {
            return _connection.Query<facts>("SELECT DISTINCT category FROM facts_list;").ToList();
        }

        public IEnumerable<facts> GetAllFacts()
        {
            return _connection.Query<facts>("SELECT * FROM facts_list;").ToList();
        }

        public facts GetOneCategory(string category)
        {
            return _connection.QuerySingle<facts>("SELECT * FROM facts_list WHERE CATEGORY = @category",
                new { category = category });
        }

        public facts GetRandomFact()
        {
            return _connection.QuerySingle<facts>("SELECT fact FROM facts_list ORDER BY RAND() LIMIT 1");
        }

    }
}
