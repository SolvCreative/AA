using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AA.Curiosity_Data
{
    public class curiosity_api 
    {
        private HttpClient _client;
        public curiosity_api(HttpClient client)
        {
            _client = client;
        }
             

        public string output()
        {
            string apiURL = "https://api.maas2.apollorion.com";
            var apiResult = _client.GetStringAsync(apiURL).Result;


            var data = JObject.Parse(apiResult).GetValue("Latest").ToString();
            return data;
            
        }
    }
}
