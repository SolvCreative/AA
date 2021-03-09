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


        public IEnumerable<Neo> GetAllNeos()
        {
            return _connection.Query<Neo>("SELECT * FROM neo_db;").ToList();
        }

        public Neo GetRandomNeo()
        {
            return _connection.QuerySingle<Neo>("SELECT name, diameter, first_obs FROM neo_db ORDER BY RAND() LIMIT 1;");
        }

        IEnumerable<Neo> INeoRepo.GetAllNeos()
        {
            throw new NotImplementedException();
        }

        void INeoRepo.GetRandomNeo()
        {
            throw new NotImplementedException();
        }
    }
}
