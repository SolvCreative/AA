using AA.Curiosity_Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AA.Controllers
{
    public class MarsController : Controller
    {
        
        private readonly IWeatherRepo repo;

        public MarsController(IWeatherRepo repo)
        {
            this.repo = repo;
        }

        public ViewResult MarsData()
        {
            var data = repo.GetMarsData();

            return View(data);
        }
    }
}
