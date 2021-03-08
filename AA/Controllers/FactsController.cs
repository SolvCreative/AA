using AA.Facts_Generator;
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

        public IActionResult ViewAllFacts()
        {
            var facts = repo.GetAllFacts();

            return View(facts);
        }

        public IActionResult GenerateFact()
        {
            var randomFact = repo.GetRandomFact();

            return View(randomFact);
        }

    }
}
