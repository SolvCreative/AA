using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Dapper;
using System.Threading.Tasks;

namespace AA.Facts_Generator
{
    public class factsRepo : IFactsRepo
    {
        private readonly IDbConnection _connection;
        public factsRepo(IDbConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<facts> GetFacts()
        {
            return _connection.Query<facts>("SELECT * FROM facts_list;").ToList();
        }

    }
}
