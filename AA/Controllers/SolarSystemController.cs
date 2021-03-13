using AA.Controllers;
using AA.Solar_System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Net.Http;

namespace AA.Controllers
{
    public class SolarSystemController : Controller
    {

        public IActionResult Index()
        {
            using (var client = new HttpClient())
            {
                var infoURL = "https://api.le-systeme-solaire.net/rest/bodies/";
                var infoResponse = client.GetStringAsync(infoURL).Result;
                var solarList = JsonConvert.DeserializeObject<Data>(infoResponse);
                return View();

            }

        }
    }

}

