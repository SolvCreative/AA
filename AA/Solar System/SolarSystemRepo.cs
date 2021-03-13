using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using AA.Models;
using AA.Controllers.Solar_System;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AA.Solar_System
{
    //public class SolarSystemRepo : ISolarSystemRepo
    //{
        
    //    public SolarSystemRepo()
    //    {
            
    //    }

    //    public IEnumerable<SolarSystemViewModel> GetData()
    //    {
          
    //        throw new Exception();

    //        //var url = "https://api.le-systeme-solaire.net/rest/bodies/";
    //        //var response = _client.GetStringAsync(url).Result;
    //        //var data = JsonConvert.DeserializeObject<SolarSystemList>(response);
    //        //return (IEnumerable<SolarSystemViewModel>)data;
    //    }
    //}
}