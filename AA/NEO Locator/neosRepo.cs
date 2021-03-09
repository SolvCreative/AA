using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using AA.Models;
using Dapper;

namespace AA.NEO_Locator
{
    public class neosRepo : INeoRepo
    {
        private readonly IDbConnection _connection;
        public neosRepo(IDbConnection connection)
        {
            _connection = connection;
        }


        public IEnumerable<NeoViewModel> GetAllNeos()
        {
            return _connection.Query<NeoViewModel>("SELECT * FROM neo_db;").ToList();
        }

        public NeoViewModel GetRandomNeo()
        {
            return _connection.QuerySingle<NeoViewModel>("SELECT name, diameter, first_obs FROM neo_db ORDER BY RAND() LIMIT 1;");
        }

        public IEnumerable<NeoViewModel> SearchNeo(string search)
        {                
            //prevents sql injection
            return _connection.Query<NeoViewModel>("SELECT * FROM neo_db WHERE LIKE @name;",
                new { name = "%" + search + "%" });
        }

    }
}
