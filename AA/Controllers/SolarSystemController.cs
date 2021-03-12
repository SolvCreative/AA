using AA.Controllers;
using AA.Controllers.Solar_System;
using AA.Models;
using AA.Solar_System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace AA.Controllers
{
    public class SolarSystemController : Controller
    {
        private readonly ISolarSystemRepo repo;

        public SolarSystemController(ISolarSystemRepo repo)
        {
            this.repo = repo;
        }

        public async Task<ActionResult> Index()
        {
            List<SolarSystemList> dataList = new List<SolarSystemList>();

            using (var client = new HttpClient())
            {
                string url = "https://api.le-systeme-solaire.net/rest/bodies/";
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync(url);

                if (Res.IsSuccessStatusCode)
                {
                    var responseContent = Res.Content;
                    var responseString = Res.Content.ReadAsStringAsync().Result;
                    var json = JObject.Parse(responseString);
                }
                return View();
            }
        }
     
  

        //public IActionResult Index()
        //{
        //    var data = repo.GetData();
        //    return View(data);
        //}

    }

}

