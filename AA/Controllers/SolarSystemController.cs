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

        public IActionResult Index()
        {
           
            return View();
        }


    }

}

