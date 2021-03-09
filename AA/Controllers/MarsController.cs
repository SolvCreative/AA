﻿using AA.Mars_Weather;
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

        public IActionResult ViewWeather(float SOL)
        {
            var data = repo.GetWeather();

            return View(data);
        }
    }
}
