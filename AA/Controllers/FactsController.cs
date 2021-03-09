using AA.Facts_Generator;
using AA.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AA.Controllers
{
    public class FactsController : Controller
    {
        private readonly IFactsRepo repo;

        public FactsController(IFactsRepo repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            var randomFact = repo.GetRandomFact();

            return View(randomFact);
        }

    }
}