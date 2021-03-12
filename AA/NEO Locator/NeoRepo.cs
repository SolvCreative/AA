using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using AA.Models;
using Dapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;

namespace AA.NEO_Locator
{
    public class NeoRepo : INeoRepo
    {
       
        private readonly IDbConnection _conn;
        public NeoRepo()
        {
            _conn = new MySqlConnection("Server=localhost;Database=neodb;uid=root;Pwd=password;Port=3306;");
        }

        public IEnumerable<NeoViewModel> GetAllNeos()
        {
            return _conn.Query<NeoViewModel>("SELECT * FROM neo_db;").ToList();
        }

        public IEnumerable<NeoViewModel> GetHundredNeos()
        {
            return _conn.Query<NeoViewModel>("SELECT full_name, name, diameter, first_obs FROM neo_db ORDER BY RAND() LIMIT 100;");
        }

        public NeoViewModel GetRandomNeo()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NeoViewModel> SearchNeo(string search)
        {                
            //prevents sql injection
            return _conn.Query<NeoViewModel>("SELECT * FROM neo_db WHERE LIKE @name;",
                new { name = "%" + search + "%" });
        }

       
    }
}
