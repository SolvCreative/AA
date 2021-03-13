using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AA.Solar_System
{
    public class GetData
    {
        public GetData()
        {
            var client = new HttpClient();
            var connection = "https://api.le-systeme-solaire.net/rest/bodies/";
            var ssResponse = client.GetStringAsync(connection).Result;
            var solarSystemData = JsonConvert.DeserializeObject<Data>(ssResponse);
            
        }

        
    }
}
