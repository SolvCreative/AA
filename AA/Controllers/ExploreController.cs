using AA.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace AA.Controllers
{
    public class ExploreController : Controller
    {
        private readonly ILogger<ExploreController> _logger;

        public ExploreController(ILogger<ExploreController> logger)
        {
            _logger = logger;
        }

        public IActionResult ExploreIndex()
        {
            return View("Explore/Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
