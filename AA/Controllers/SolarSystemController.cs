using AA.Controllers;
using AA.Controllers.Solar_System;
using AA.Models;
using AA.Solar_System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public IActionResult Index()
        {
            var data = repo.GetData();
            return View(data);
        }

    }

}

