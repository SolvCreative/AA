using AA.Controllers;
using AA.NEO_Locator;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AA.Controllers
{
    public class NeoController : Controller
    {
        
        private readonly INeoRepo repo;

        public NeoController(INeoRepo repo)
        {
            this.repo = repo;
        }

        public IActionResult SearchNeo(string search)
        {
            var searchNeo = repo.SearchNeo(search);
            return View("SearchNEO");
        }
    }
}
