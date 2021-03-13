using AA.Models;
using AA.Solar_System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace AA
{
    public class Program    
    {
        public static IHostBuilder CreateHostBuilder(string[] args) =>
           Host.CreateDefaultBuilder(args)
               .ConfigureWebHostDefaults(webBuilder =>
               {
                   webBuilder.UseStartup<Startup>();
               });
        

        public static void Main(string[] args)
        {
            //string connectionKey = File.ReadAllText("appsettings.json");
            //JObject jsonObject = JObject.Parse(connectionKey);
            //JToken token = jsonObject["DefaultConnection"];
            //string connString = token.ToString();
            //curiosityRepo.connectionString = connString;

            CreateHostBuilder(args).Build().Run();         

            
            var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();


            string connString2 = config.GetConnectionString("DefaultConnection");
            IDbConnection conn = new MySqlConnection(connString2);
                       
            //Space facts from SQL DB space_facts schema
            var fRepo = new Facts_Generator.FactsRepo(conn);
            var facts = fRepo.GetAllFacts();

            // Solar system API

            //var client = new HttpClient();
            
            //var url = "https://api.le-systeme-solaire.net/rest/bodies/";
            //var response = client.GetStringAsync(url).Result;
            //var bodies = JsonConvert.DeserializeObject<SolarSystemViewModel>(response);
           
            
        }

    }
        }
           


