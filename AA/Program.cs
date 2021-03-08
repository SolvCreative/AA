using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using AA.Curiosity_Data;

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

            Console.WriteLine("Hey Armchair Astronauts! Check out these fun facts about space:");

            foreach (var f in facts)
            {
                Console.WriteLine($"Category: {f.category}\n" +
                    $"Fun Fact: {f.fact}");
                Console.WriteLine(".................");
            }

            Console.WriteLine("____________________________________");

        

            //MAAS2 REST API - data from Mars Rover Curiosity
            var client = new HttpClient();
            string apiURL = "https://api.maas2.apollorion.com";
            var apiResult = client.GetStringAsync(apiURL).Result;
            var latestSol = JObject.Parse(apiResult).GetValue("Latest").ToString();
            var data = latestSol;

            Console.WriteLine($"Here is the latest data from Mars Rover Curiosity: {data}");
 

        }
        }
           
}

