using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using AA.Models;
using Dapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MySql.Data.MySqlClient;

namespace AA.NEO_Locator
{
    public class NeoRepo : INeoRepo
    {
        public NeoRepo(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IDbConnection>((s) =>
            {
                IDbConnection conn2 = new MySqlConnection(Configuration.GetConnectionString("neodb"));
                conn2.Open();
                return conn2;
            });

            services.AddTransient<INeoRepo, NeoRepo>();
            services.AddControllersWithViews();
        }
        
        private readonly IDbConnection _conn2;
        public NeoRepo(IDbConnection conn2)
        {
            _conn2 = conn2;
        }

        public IEnumerable<NeoViewModel> GetAllNeos()
        {
            return _conn2.Query<NeoViewModel>("SELECT * FROM neo_db;").ToList();
        }

        public IEnumerable<NeoViewModel> GetHundredNeos()
        {
            return _conn2.Query<NeoViewModel>("SELECT name, diameter, first_obs FROM neo_db ORDER BY RAND() LIMIT 100;");
        }

        public NeoViewModel GetRandomNeo()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NeoViewModel> SearchNeo(string search)
        {                
            //prevents sql injection
            return _conn2.Query<NeoViewModel>("SELECT * FROM neo_db WHERE LIKE @name;",
                new { name = "%" + search + "%" });
        }

       
    }
}
